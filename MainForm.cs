using Envision.Library;
using OSGeo.GDAL;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace MagicBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "MagicBox 1.1";
            //恢复设置
            numLayer.Value = Properties.Settings.Default.ImageLayer;
            numScale.Value = numScale2.Value = Properties.Settings.Default.ImageScale;
            numQuality.Value = numQuality2.Value = Properties.Settings.Default.ImageQuality;
            //设置GDAL路径
            string GDAL_HOME = Path.Combine(Application.StartupPath, "gdal", "x64"); 
            string path = Environment.GetEnvironmentVariable("PATH");
            path += ";" + GDAL_HOME;
            Environment.SetEnvironmentVariable("PATH", path);
            //TODO 转固定像素
            //TODO 转换进度百分比
        }

        bool StopConvertKfb = false;
        bool StopConvertTif = false;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "*.ab1|*.ab1",
                Multiselect = true,
                Title = "选择基因测序结果文件（支持多选）"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dgvData.Rows.Clear();
                ColID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                foreach (var file in dialog.FileNames)
                {
                    var fileInfo = new FileInfo(file);
                    var row = dgvData.Rows[dgvData.Rows.Add()];
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                    row.Tag = fileInfo;
                    row.Cells[0].Value = fileInfo.Name.Replace(fileInfo.Extension, "");
                }
                ColID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvData.ClearSelection();
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    var startInfo = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Maximized,
                        FileName = ((FileInfo)((DataGridView)sender).Rows[e.RowIndex].Tag).FullName
                    };
                    Process.Start(startInfo);
                }
                else if (e.ColumnIndex == 1)
                {
                    var startInfo = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Maximized,
                        FileName = ((FileInfo)((DataGridView)sender).Rows[e.RowIndex].Tag).DirectoryName
                    };
                    Process.Start(startInfo);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount == 0) return;
            var dialog = new SaveFileDialog
            {
                Filter = "xlsx|*.xlsx",
                FileName = $"基因型_{DateTime.Now:yyyyMMdd}.xlsx"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Tag");
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
                }
                ExcelHelper.Instance.DataTableToFile(dialog.FileName, dt);
                if (DialogResult.OK == MessageBox.Show("保存成功，是否打开文件？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                {
                    Process.Start(dialog.FileName);
                }
            }
        }

        private void btnLoadKfb_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "*.kfb|*.kfb",
                Multiselect = true,
                Title = "选择kfb文件（支持多选）"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dgvKfb.Rows.Clear();
                ColKfb.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                foreach (var file in dialog.FileNames)
                {
                    var fileInfo = new FileInfo(file);
                    var row = dgvKfb.Rows[dgvKfb.Rows.Add()];
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                    row.Tag = fileInfo;
                    row.Cells[0].Value = fileInfo.Name;
                }
                ColKfb.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvKfb.ClearSelection();
            }
        }

        private void checkBox2Jpg_CheckedChanged(object sender, EventArgs e)
        {
            lbQuality.Visible = numQuality.Visible = lbScale.Visible = numScale.Visible = lbPercent.Visible = checkBox2Jpg.Checked;
        }

        private void btnConvertKfb2Tif_Click(object sender, EventArgs e)
        {
            string toolPath = Path.Combine(Application.StartupPath, "KFbioConverter", "KFbioConverter.exe");
            if (!File.Exists(toolPath))
            {
                MessageBox.Show("KFbioConverter.exe不存在，请重新获取工具", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            StopConvertKfb = false;
            int layer = (int)numLayer.Value;
            bool convert2jpg = checkBox2Jpg.Checked;
            double scale = (double)numScale.Value / 100.0;
            int quality = (int)numQuality.Value;
            new Thread(() =>
            {
                foreach (DataGridViewRow row in dgvKfb.Rows)
                {
                    if (StopConvertKfb) break;
                    Process process = null;
                    try
                    {
                        Invoke(new Action(() =>
                        {
                            row.Cells[1].Value = "转换中...";
                            row.Cells[1].Style.ForeColor = Color.Black;
                            dgvKfb.Refresh();
                        }));
                        var srcFileInfo = (FileInfo)row.Tag;
                        if (!srcFileInfo.Exists) throw new Exception($"{srcFileInfo.Name}文件不存在");
                        var dstFileInfo = new FileInfo(srcFileInfo.FullName.Replace(srcFileInfo.Extension, ".tif"));
                        if (dstFileInfo.Exists) dstFileInfo.Delete();
                        var startInfo = new ProcessStartInfo
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            FileName = toolPath,
                            Arguments = $"\"{srcFileInfo.FullName}\" \"{dstFileInfo.FullName}\" {layer}"
                        };
                        process = Process.Start(startInfo);
                        process.WaitForExit();
                        int retryCounter = 3;
                        while (retryCounter > 0)
                        {
                            if (!File.Exists(dstFileInfo.FullName))
                            {
                                retryCounter--;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (!File.Exists(dstFileInfo.FullName)) throw new Exception($"{dstFileInfo.Name}文件不存在");
                        string msg = "转换完成：" + dstFileInfo.Name;
                        if (convert2jpg)
                        {
                            try
                            {
                                ConvertIamgeByGdal(dstFileInfo.FullName, dstFileInfo.FullName.Replace(dstFileInfo.Extension, ".jpg"), scale, quality);
                                //Convert2Jpeg(dstFile.FullName, dstFile.FullName.Replace(dstFileInfo.Extension, ".jpg"));
                                msg += "、" + dstFileInfo.Name.Replace(dstFileInfo.Extension, ".jpg");
                            }
                            catch (Exception ex)
                            {
                                msg += "，jpg转换失败：" + ex.Message;
                            }
                        }
                        Invoke(new Action(() =>
                        {
                            row.Cells[1].Value = msg;
                            row.Cells[1].Style.ForeColor = Color.Green;
                            dgvKfb.Refresh();
                        }));
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            row.Cells[1].Value = "转换失败：" + ex.Message;
                            row.Cells[1].Style.ForeColor = Color.Red;
                            dgvKfb.Refresh();
                        }));
                    }
                    finally
                    {
                        process?.Close();
                        process?.Dispose();
                    }
                    GC.Collect();
                }
            }).Start();
        }

        private void btnLoadTif_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "*.tif|*.tif",
                Multiselect = true,
                Title = "选择tif文件（支持多选）"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dgvTif.Rows.Clear();
                ColTif.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                foreach (var file in dialog.FileNames)
                {
                    var fileInfo = new FileInfo(file);
                    var row = dgvTif.Rows[dgvTif.Rows.Add()];
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                    row.Tag = fileInfo;
                    row.Cells[0].Value = fileInfo.Name;
                }
                ColTif.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvTif.ClearSelection();
            }
        }

        private void btnConvertTif2Jpg_Click(object sender, EventArgs e)
        {
            StopConvertTif = false;
            double scale = (double)numScale2.Value / 100.0;
            int quality = (int)numQuality2.Value;
            new Thread(() =>
            {
                foreach (DataGridViewRow row in dgvTif.Rows)
                {
                    if (StopConvertTif) break;
                    try
                    {
                        Invoke(new Action(() =>
                        {
                            row.Cells[1].Value = "转换中...";
                            row.Cells[1].Style.ForeColor = Color.Black;
                            dgvTif.Refresh();
                        }));
                        var srcFileInfo = (FileInfo)row.Tag;
                        if (!srcFileInfo.Exists) throw new Exception($"{srcFileInfo.Name}文件不存在");
                        var dstFileInfo = new FileInfo(srcFileInfo.FullName.Replace(srcFileInfo.Extension, ".jpg"));
                        if (dstFileInfo.Exists) dstFileInfo.Delete();
                        ConvertIamgeByGdal(srcFileInfo.FullName, dstFileInfo.FullName, scale, quality);
                        //Convert2Jpeg(srcFileInfo.FullName, dstFileInfo.FullName, quality);
                        Invoke(new Action(() =>
                        {
                            row.Cells[1].Value = "转换完成：" + dstFileInfo.Name;
                            row.Cells[1].Style.ForeColor = Color.Green;
                            dgvTif.Refresh();
                        }));
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            row.Cells[1].Value = "转换失败：" + ex.Message;
                            row.Cells[1].Style.ForeColor = Color.Red;
                            dgvTif.Refresh();
                        }));
                    }
                    GC.Collect();
                }
            }).Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopConvertKfb = true;
            MessageBox.Show("已停止转换kfb", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStopTif_Click(object sender, EventArgs e)
        {
            StopConvertTif = true;
            MessageBox.Show("已停止转换tif", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numLayer_ValueChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ImageLayer != (int)numLayer.Value)
            {
                Properties.Settings.Default.ImageLayer = (int)numLayer.Value;
                Properties.Settings.Default.Save();
            }
        }

        private void numScale_ValueChanged(object sender, EventArgs e)
        {
            if (sender == numScale)
            {
                numScale2.Value = (int)numScale.Value;
            }
            else if (sender == numScale2)
            {
                numScale.Value = (int)numScale2.Value;
            }
            if (Properties.Settings.Default.ImageScale != (int)numScale.Value)
            {
                Properties.Settings.Default.ImageScale = (int)numScale.Value;
                Properties.Settings.Default.Save();
            }
        }

        private void numQuality_ValueChanged(object sender, EventArgs e)
        {
            if (sender == numQuality)
            {
                numQuality2.Value = (int)numQuality.Value;
            }
            else if (sender == numQuality2)
            {
                numQuality.Value = (int)numQuality2.Value;
            }
            if (Properties.Settings.Default.ImageQuality != (int)numQuality.Value)
            {
                Properties.Settings.Default.ImageQuality = (int)numQuality.Value;
                Properties.Settings.Default.Save();
            }
        }

        #region 图片格式转换
        public static void ConvertImage(string srcFilename, string dstFilename, double percent = 1, int qualityLevel = 100, bool throwException = false)
        {
            var image = new Bitmap(srcFilename);

            try
            {
                //期望的宽度
                int dstWidth = (int)(image.Width * percent);
                //期望的高度
                int dstHeight = (int)(image.Height * percent);

                image = new Bitmap(image, dstWidth, dstHeight);
                //var dstImage = new Bitmap(dstWidth, dstHeight);
                //using (Graphics g = Graphics.FromImage(dstImage))
                //{
                //    //g.InterpolationMode = InterpolationMode.Low;
                //    //g.CompositingQuality = CompositingQuality.HighSpeed;
                //    //绘制图像
                //    g.DrawImage(image, 0, 0, dstWidth, dstHeight);
                //}
                GC.Collect();
            }
            catch
            {
                if (throwException) throw;
            }

            var encoders = ImageCodecInfo.GetImageEncoders();
            var encoder = encoders.FirstOrDefault(i => i.FilenameExtension.IndexOf(Path.GetExtension(dstFilename), StringComparison.OrdinalIgnoreCase) >= 0);

            // Save the bitmap as a JPEG file with quality level.
            var myEncoderParameter = new EncoderParameter(Encoder.Quality, qualityLevel);
            var myEncoderParameters = new EncoderParameters(1);
            myEncoderParameters.Param[0] = myEncoderParameter;

            image.Save(dstFilename, encoder, myEncoderParameters);
        }

        public static void Convert2Jpeg(string srcFilename, string dstFilename, int qualityLevel = 100)
        {
            using (FileStream fs = new FileStream(srcFilename, FileMode.Open))
            {
                var decoder = BitmapDecoder.Create(fs, BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                //BitmapSource bitmapSource = decoder.Frames[0];//此处只取tiff中的第一帧，可以根据情况取多帧，从Frames.Count中取
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                foreach (var frame in decoder.Frames)
                {
                    encoder.Frames.Add(frame);
                }
                encoder.QualityLevel = qualityLevel;
                using (FileStream stream = new FileStream(dstFilename, FileMode.Create))
                {
                    encoder.Save(stream);
                    stream.Close();
                }
                fs.Close();
            }
        }

        public static void ConvertIamgeByGdal(string srcFilename, string dstFilename, double percent = 1, int qualityLevel = 75)
        {
            Gdal.AllRegister();

            Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");

            Dataset ds = Gdal.Open(srcFilename, Access.GA_ReadOnly);

            //Driver drv = Gdal.GetDriverByName("GTiff");
            //Driver drv = ds.GetDriver();
            //string[] options = new string[] { "TILED=YES", $"QUALITY={qualityLevel}", "BLOCK=1" };
            //drv.CreateCopy(dstFilename, ds, 0, options, null, null); //tif转换成jpg

            int width = (int)(ds.RasterXSize * percent);
            int height = (int)(ds.RasterYSize * percent);

            var bitmap = SaveBitmap(ds, 0, 0, ds.RasterXSize, ds.RasterYSize, width, height);

            var encoders = ImageCodecInfo.GetImageEncoders();
            var encoder = encoders.FirstOrDefault(i => i.FilenameExtension.IndexOf(Path.GetExtension(dstFilename), StringComparison.OrdinalIgnoreCase) >= 0);

            // Save the bitmap as a JPEG file with quality level.
            var myEncoderParameter = new EncoderParameter(Encoder.Quality, qualityLevel);
            var myEncoderParameters = new EncoderParameters(1);
            myEncoderParameters.Param[0] = myEncoderParameter;

            bitmap.Save(dstFilename, encoder, myEncoderParameters);

            //using (FileStream srcStream = new FileStream(srcFilename, FileMode.Open))
            //{
            //    using (var image = SixLabors.ImageSharp.Image.Load(srcStream))
            //    {
            //        int width = (int)(image.Width * percent);
            //        int height = (int)(image.Height * percent);
            //        image.Mutate(x => x.Resize(width, height, KnownResamplers.Lanczos3));

            //        using (FileStream dstStream = new FileStream(dstFilename, FileMode.Create))
            //        {
            //            image.Save(dstStream, new JpegEncoder());
            //            dstStream.Close();
            //        }
            //    }
            //}
        }

        private static Bitmap SaveBitmap(Dataset ds, int xOff, int yOff, int width, int height, int imageWidth, int imageHeight)
        {
            if (ds.RasterCount == 0)
                return null;

            int[] bandMap = new int[4] { 1, 1, 1, 1 };
            int channelCount = 1;
            bool hasAlpha = false;
            bool isIndexed = false;
            int channelSize = 8;
            ColorTable ct = null;
            // Evaluate the bands and find out a proper image transfer format
            for (int i = 0; i < ds.RasterCount; i++)
            {
                Band band = ds.GetRasterBand(i + 1);
                if (Gdal.GetDataTypeSize(band.DataType) > 8)
                    channelSize = 16;
                switch (band.GetRasterColorInterpretation())
                {
                    case ColorInterp.GCI_AlphaBand:
                        channelCount = 4;
                        hasAlpha = true;
                        bandMap[3] = i + 1;
                        break;
                    case ColorInterp.GCI_BlueBand:
                        if (channelCount < 3)
                            channelCount = 3;
                        bandMap[0] = i + 1;
                        break;
                    case ColorInterp.GCI_RedBand:
                        if (channelCount < 3)
                            channelCount = 3;
                        bandMap[2] = i + 1;
                        break;
                    case ColorInterp.GCI_GreenBand:
                        if (channelCount < 3)
                            channelCount = 3;
                        bandMap[1] = i + 1;
                        break;
                    case ColorInterp.GCI_PaletteIndex:
                        ct = band.GetRasterColorTable();
                        isIndexed = true;
                        bandMap[0] = i + 1;
                        break;
                    case ColorInterp.GCI_GrayIndex:
                        isIndexed = true;
                        bandMap[0] = i + 1;
                        break;
                    default:
                        // we create the bandmap using the dataset ordering by default
                        if (i < 4 && bandMap[i] == 0)
                        {
                            if (channelCount < i)
                                channelCount = i;
                            bandMap[i] = i + 1;
                        }
                        break;
                }
            }

            // find out the pixel format based on the gathered information
            PixelFormat pixelFormat;
            DataType dataType;
            int pixelSpace;

            if (isIndexed)
            {
                pixelFormat = PixelFormat.Format8bppIndexed;
                dataType = DataType.GDT_Byte;
                pixelSpace = 1;
            }
            else
            {
                if (channelCount == 1)
                {
                    if (channelSize > 8)
                    {
                        pixelFormat = PixelFormat.Format16bppGrayScale;
                        dataType = DataType.GDT_Int16;
                        pixelSpace = 2;
                    }
                    else
                    {
                        pixelFormat = PixelFormat.Format24bppRgb;
                        channelCount = 3;
                        dataType = DataType.GDT_Byte;
                        pixelSpace = 3;
                    }
                }
                else
                {
                    if (hasAlpha)
                    {
                        if (channelSize > 8)
                        {
                            pixelFormat = PixelFormat.Format64bppArgb;
                            dataType = DataType.GDT_UInt16;
                            pixelSpace = 8;
                        }
                        else
                        {
                            pixelFormat = PixelFormat.Format32bppArgb;
                            dataType = DataType.GDT_Byte;
                            pixelSpace = 4;
                        }
                        channelCount = 4;
                    }
                    else
                    {
                        if (channelSize > 8)
                        {
                            pixelFormat = PixelFormat.Format48bppRgb;
                            dataType = DataType.GDT_UInt16;
                            pixelSpace = 6;
                        }
                        else
                        {
                            pixelFormat = PixelFormat.Format24bppRgb;
                            dataType = DataType.GDT_Byte;
                            pixelSpace = 3;
                        }
                        channelCount = 3;
                    }
                }
            }

            // Create a Bitmap to store the GDAL image in
            Bitmap bitmap = new Bitmap(imageWidth, imageHeight, pixelFormat);

            if (isIndexed)
            {
                // setting up the color table
                if (ct != null)
                {
                    int iCol = ct.GetCount();
                    ColorPalette pal = bitmap.Palette;
                    for (int i = 0; i < iCol; i++)
                    {
                        ColorEntry ce = ct.GetColorEntry(i);
                        pal.Entries[i] = Color.FromArgb(ce.c4, ce.c1, ce.c2, ce.c3);
                    }
                    bitmap.Palette = pal;
                }
                else
                {
                    // grayscale
                    ColorPalette pal = bitmap.Palette;
                    for (int i = 0; i < 256; i++)
                        pal.Entries[i] = Color.FromArgb(255, i, i, i);
                    bitmap.Palette = pal;
                }
            }

            // Use GDAL raster reading methods to read the image data directly into the Bitmap
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, imageWidth, imageHeight), ImageLockMode.ReadWrite, pixelFormat);

            try
            {
                int stride = bitmapData.Stride;
                IntPtr buf = bitmapData.Scan0;

                ds.ReadRaster(xOff, yOff, width, height, buf, imageWidth, imageHeight, dataType,
                    channelCount, bandMap, pixelSpace, stride, 1);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return bitmap;
        }
        #endregion 图片格式转换

    }
}
