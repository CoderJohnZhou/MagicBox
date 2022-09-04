namespace MagicBox
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMarker = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageKfb2Tif = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadKfb = new System.Windows.Forms.Button();
            this.btnConvertKfb2Tif = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbLayer = new System.Windows.Forms.Label();
            this.numLayer = new System.Windows.Forms.NumericUpDown();
            this.checkBox2Jpg = new System.Windows.Forms.CheckBox();
            this.lbScale = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbQuality = new System.Windows.Forms.Label();
            this.numQuality = new System.Windows.Forms.NumericUpDown();
            this.dgvKfb = new System.Windows.Forms.DataGridView();
            this.ColKfb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColConverter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTif2Jpg = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTif = new System.Windows.Forms.DataGridView();
            this.ColTif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTif2Jpg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadTif = new System.Windows.Forms.Button();
            this.btnConvertTif2Jpg = new System.Windows.Forms.Button();
            this.btnStopTif = new System.Windows.Forms.Button();
            this.lbScale2 = new System.Windows.Forms.Label();
            this.numScale2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbQuality2 = new System.Windows.Forms.Label();
            this.numQuality2 = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageMarker.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageKfb2Tif.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKfb)).BeginInit();
            this.tabPageTif2Jpg.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTif)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 24);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(78, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColTag});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvData, 3);
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvData.Location = new System.Drawing.Point(3, 33);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(766, 495);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // ColID
            // 
            this.ColID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 10;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 200;
            // 
            // ColTag
            // 
            this.ColTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTag.HeaderText = "Tag";
            this.ColTag.MinimumWidth = 10;
            this.ColTag.Name = "ColTag";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMarker);
            this.tabControl.Controls.Add(this.tabPageKfb2Tif);
            this.tabControl.Controls.Add(this.tabPageTif2Jpg);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 561);
            this.tabControl.TabIndex = 4;
            // 
            // tabPageMarker
            // 
            this.tabPageMarker.Controls.Add(this.tableLayoutPanel1);
            this.tabPageMarker.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarker.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageMarker.Name = "tabPageMarker";
            this.tabPageMarker.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageMarker.Size = new System.Drawing.Size(776, 535);
            this.tabPageMarker.TabIndex = 1;
            this.tabPageMarker.Text = "基因型标记";
            this.tabPageMarker.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 531);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tabPageKfb2Tif
            // 
            this.tabPageKfb2Tif.Controls.Add(this.tableLayoutPanel2);
            this.tabPageKfb2Tif.Location = new System.Drawing.Point(4, 22);
            this.tabPageKfb2Tif.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageKfb2Tif.Name = "tabPageKfb2Tif";
            this.tabPageKfb2Tif.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageKfb2Tif.Size = new System.Drawing.Size(776, 535);
            this.tabPageKfb2Tif.TabIndex = 2;
            this.tabPageKfb2Tif.Text = "kfb2tif";
            this.tabPageKfb2Tif.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvKfb, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 531);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel2, 4);
            this.flowLayoutPanel2.Controls.Add(this.btnLoadKfb);
            this.flowLayoutPanel2.Controls.Add(this.btnConvertKfb2Tif);
            this.flowLayoutPanel2.Controls.Add(this.btnStop);
            this.flowLayoutPanel2.Controls.Add(this.lbLayer);
            this.flowLayoutPanel2.Controls.Add(this.numLayer);
            this.flowLayoutPanel2.Controls.Add(this.checkBox2Jpg);
            this.flowLayoutPanel2.Controls.Add(this.lbScale);
            this.flowLayoutPanel2.Controls.Add(this.numScale);
            this.flowLayoutPanel2.Controls.Add(this.lbPercent);
            this.flowLayoutPanel2.Controls.Add(this.lbQuality);
            this.flowLayoutPanel2.Controls.Add(this.numQuality);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(772, 30);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnLoadKfb
            // 
            this.btnLoadKfb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadKfb.Location = new System.Drawing.Point(3, 3);
            this.btnLoadKfb.Name = "btnLoadKfb";
            this.btnLoadKfb.Size = new System.Drawing.Size(69, 24);
            this.btnLoadKfb.TabIndex = 0;
            this.btnLoadKfb.Text = "加载";
            this.btnLoadKfb.UseVisualStyleBackColor = true;
            this.btnLoadKfb.Click += new System.EventHandler(this.btnLoadKfb_Click);
            // 
            // btnConvertKfb2Tif
            // 
            this.btnConvertKfb2Tif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertKfb2Tif.Location = new System.Drawing.Point(78, 3);
            this.btnConvertKfb2Tif.Name = "btnConvertKfb2Tif";
            this.btnConvertKfb2Tif.Size = new System.Drawing.Size(69, 24);
            this.btnConvertKfb2Tif.TabIndex = 2;
            this.btnConvertKfb2Tif.Text = "转换";
            this.btnConvertKfb2Tif.UseVisualStyleBackColor = true;
            this.btnConvertKfb2Tif.Click += new System.EventHandler(this.btnConvertKfb2Tif_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(153, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(69, 24);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbLayer
            // 
            this.lbLayer.Location = new System.Drawing.Point(228, 3);
            this.lbLayer.Margin = new System.Windows.Forms.Padding(3);
            this.lbLayer.Name = "lbLayer";
            this.lbLayer.Size = new System.Drawing.Size(73, 24);
            this.lbLayer.TabIndex = 5;
            this.lbLayer.Text = "转换tif层数";
            this.lbLayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numLayer
            // 
            this.numLayer.Location = new System.Drawing.Point(307, 5);
            this.numLayer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numLayer.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numLayer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLayer.Name = "numLayer";
            this.numLayer.Size = new System.Drawing.Size(40, 21);
            this.numLayer.TabIndex = 6;
            this.numLayer.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numLayer.ValueChanged += new System.EventHandler(this.numLayer_ValueChanged);
            // 
            // checkBox2Jpg
            // 
            this.checkBox2Jpg.Checked = true;
            this.checkBox2Jpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2Jpg.Location = new System.Drawing.Point(359, 3);
            this.checkBox2Jpg.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.checkBox2Jpg.Name = "checkBox2Jpg";
            this.checkBox2Jpg.Size = new System.Drawing.Size(60, 24);
            this.checkBox2Jpg.TabIndex = 4;
            this.checkBox2Jpg.Text = "转jpg";
            this.checkBox2Jpg.UseVisualStyleBackColor = true;
            this.checkBox2Jpg.CheckedChanged += new System.EventHandler(this.checkBox2Jpg_CheckedChanged);
            // 
            // lbScale
            // 
            this.lbScale.Location = new System.Drawing.Point(425, 3);
            this.lbScale.Margin = new System.Windows.Forms.Padding(3);
            this.lbScale.Name = "lbScale";
            this.lbScale.Size = new System.Drawing.Size(72, 24);
            this.lbScale.TabIndex = 9;
            this.lbScale.Text = "jpg图片缩放";
            this.lbScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numScale
            // 
            this.numScale.Location = new System.Drawing.Point(503, 5);
            this.numScale.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(59, 21);
            this.numScale.TabIndex = 10;
            this.numScale.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numScale.ValueChanged += new System.EventHandler(this.numScale_ValueChanged);
            // 
            // lbPercent
            // 
            this.lbPercent.Location = new System.Drawing.Point(568, 3);
            this.lbPercent.Margin = new System.Windows.Forms.Padding(3);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(20, 24);
            this.lbPercent.TabIndex = 11;
            this.lbPercent.Text = "%";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbQuality
            // 
            this.lbQuality.Location = new System.Drawing.Point(594, 3);
            this.lbQuality.Margin = new System.Windows.Forms.Padding(3);
            this.lbQuality.Name = "lbQuality";
            this.lbQuality.Size = new System.Drawing.Size(95, 24);
            this.lbQuality.TabIndex = 7;
            this.lbQuality.Text = "jpg图片质量等级";
            this.lbQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuality
            // 
            this.numQuality.Location = new System.Drawing.Point(695, 5);
            this.numQuality.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuality.Name = "numQuality";
            this.numQuality.Size = new System.Drawing.Size(40, 21);
            this.numQuality.TabIndex = 8;
            this.numQuality.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numQuality.ValueChanged += new System.EventHandler(this.numQuality_ValueChanged);
            // 
            // dgvKfb
            // 
            this.dgvKfb.AllowUserToAddRows = false;
            this.dgvKfb.AllowUserToDeleteRows = false;
            this.dgvKfb.AllowUserToResizeRows = false;
            this.dgvKfb.BackgroundColor = System.Drawing.Color.White;
            this.dgvKfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKfb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKfb,
            this.ColConverter});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvKfb, 4);
            this.dgvKfb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKfb.Location = new System.Drawing.Point(3, 33);
            this.dgvKfb.Name = "dgvKfb";
            this.dgvKfb.ReadOnly = true;
            this.dgvKfb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKfb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvKfb.RowTemplate.Height = 23;
            this.dgvKfb.Size = new System.Drawing.Size(766, 495);
            this.dgvKfb.TabIndex = 3;
            this.dgvKfb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // ColKfb
            // 
            this.ColKfb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColKfb.HeaderText = "kfb文件";
            this.ColKfb.MinimumWidth = 10;
            this.ColKfb.Name = "ColKfb";
            this.ColKfb.ReadOnly = true;
            this.ColKfb.Width = 200;
            // 
            // ColConverter
            // 
            this.ColConverter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColConverter.HeaderText = "转换结果";
            this.ColConverter.MinimumWidth = 10;
            this.ColConverter.Name = "ColConverter";
            this.ColConverter.ReadOnly = true;
            // 
            // tabPageTif2Jpg
            // 
            this.tabPageTif2Jpg.Controls.Add(this.tableLayoutPanel3);
            this.tabPageTif2Jpg.Location = new System.Drawing.Point(4, 22);
            this.tabPageTif2Jpg.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTif2Jpg.Name = "tabPageTif2Jpg";
            this.tabPageTif2Jpg.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTif2Jpg.Size = new System.Drawing.Size(776, 535);
            this.tabPageTif2Jpg.TabIndex = 3;
            this.tabPageTif2Jpg.Text = "tif2jpg";
            this.tabPageTif2Jpg.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvTif, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 531);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // dgvTif
            // 
            this.dgvTif.AllowUserToAddRows = false;
            this.dgvTif.AllowUserToDeleteRows = false;
            this.dgvTif.AllowUserToResizeRows = false;
            this.dgvTif.BackgroundColor = System.Drawing.Color.White;
            this.dgvTif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTif,
            this.ColTif2Jpg});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvTif, 3);
            this.dgvTif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTif.Location = new System.Drawing.Point(3, 33);
            this.dgvTif.Name = "dgvTif";
            this.dgvTif.ReadOnly = true;
            this.dgvTif.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTif.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTif.RowTemplate.Height = 23;
            this.dgvTif.Size = new System.Drawing.Size(766, 495);
            this.dgvTif.TabIndex = 3;
            this.dgvTif.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // ColTif
            // 
            this.ColTif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTif.HeaderText = "tif文件";
            this.ColTif.MinimumWidth = 10;
            this.ColTif.Name = "ColTif";
            this.ColTif.ReadOnly = true;
            this.ColTif.Width = 200;
            // 
            // ColTif2Jpg
            // 
            this.ColTif2Jpg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTif2Jpg.HeaderText = "转换结果";
            this.ColTif2Jpg.MinimumWidth = 10;
            this.ColTif2Jpg.Name = "ColTif2Jpg";
            this.ColTif2Jpg.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.btnLoadTif);
            this.flowLayoutPanel1.Controls.Add(this.btnConvertTif2Jpg);
            this.flowLayoutPanel1.Controls.Add(this.btnStopTif);
            this.flowLayoutPanel1.Controls.Add(this.lbScale2);
            this.flowLayoutPanel1.Controls.Add(this.numScale2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lbQuality2);
            this.flowLayoutPanel1.Controls.Add(this.numQuality2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(622, 30);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnLoadTif
            // 
            this.btnLoadTif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTif.Location = new System.Drawing.Point(3, 3);
            this.btnLoadTif.Name = "btnLoadTif";
            this.btnLoadTif.Size = new System.Drawing.Size(69, 24);
            this.btnLoadTif.TabIndex = 0;
            this.btnLoadTif.Text = "加载";
            this.btnLoadTif.UseVisualStyleBackColor = true;
            this.btnLoadTif.Click += new System.EventHandler(this.btnLoadTif_Click);
            // 
            // btnConvertTif2Jpg
            // 
            this.btnConvertTif2Jpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertTif2Jpg.Location = new System.Drawing.Point(78, 3);
            this.btnConvertTif2Jpg.Name = "btnConvertTif2Jpg";
            this.btnConvertTif2Jpg.Size = new System.Drawing.Size(69, 24);
            this.btnConvertTif2Jpg.TabIndex = 2;
            this.btnConvertTif2Jpg.Text = "转换";
            this.btnConvertTif2Jpg.UseVisualStyleBackColor = true;
            this.btnConvertTif2Jpg.Click += new System.EventHandler(this.btnConvertTif2Jpg_Click);
            // 
            // btnStopTif
            // 
            this.btnStopTif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopTif.Location = new System.Drawing.Point(153, 3);
            this.btnStopTif.Name = "btnStopTif";
            this.btnStopTif.Size = new System.Drawing.Size(69, 24);
            this.btnStopTif.TabIndex = 12;
            this.btnStopTif.Text = "停止";
            this.btnStopTif.UseVisualStyleBackColor = true;
            this.btnStopTif.Click += new System.EventHandler(this.btnStopTif_Click);
            // 
            // lbScale2
            // 
            this.lbScale2.Location = new System.Drawing.Point(228, 3);
            this.lbScale2.Margin = new System.Windows.Forms.Padding(3);
            this.lbScale2.Name = "lbScale2";
            this.lbScale2.Size = new System.Drawing.Size(57, 24);
            this.lbScale2.TabIndex = 9;
            this.lbScale2.Text = "图片缩放";
            this.lbScale2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numScale2
            // 
            this.numScale2.Location = new System.Drawing.Point(291, 5);
            this.numScale2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numScale2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numScale2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScale2.Name = "numScale2";
            this.numScale2.Size = new System.Drawing.Size(59, 21);
            this.numScale2.TabIndex = 10;
            this.numScale2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numScale2.ValueChanged += new System.EventHandler(this.numScale_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(356, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbQuality2
            // 
            this.lbQuality2.Location = new System.Drawing.Point(382, 3);
            this.lbQuality2.Margin = new System.Windows.Forms.Padding(3);
            this.lbQuality2.Name = "lbQuality2";
            this.lbQuality2.Size = new System.Drawing.Size(78, 24);
            this.lbQuality2.TabIndex = 7;
            this.lbQuality2.Text = "图片质量等级";
            this.lbQuality2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuality2
            // 
            this.numQuality2.Location = new System.Drawing.Point(466, 5);
            this.numQuality2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numQuality2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuality2.Name = "numQuality2";
            this.numQuality2.Size = new System.Drawing.Size(40, 21);
            this.numQuality2.TabIndex = 8;
            this.numQuality2.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numQuality2.ValueChanged += new System.EventHandler(this.numQuality_ValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "excel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagicBox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageMarker.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPageKfb2Tif.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKfb)).EndInit();
            this.tabPageTif2Jpg.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTif)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numScale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMarker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPageKfb2Tif;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnLoadKfb;
        private System.Windows.Forms.Button btnConvertKfb2Tif;
        private System.Windows.Forms.DataGridView dgvKfb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKfb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColConverter;
        private System.Windows.Forms.TabPage tabPageTif2Jpg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnLoadTif;
        private System.Windows.Forms.Button btnConvertTif2Jpg;
        private System.Windows.Forms.DataGridView dgvTif;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTif;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTif2Jpg;
        private System.Windows.Forms.CheckBox checkBox2Jpg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbLayer;
        private System.Windows.Forms.NumericUpDown numLayer;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.NumericUpDown numQuality;
        private System.Windows.Forms.Label lbScale;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbScale2;
        private System.Windows.Forms.NumericUpDown numScale2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbQuality2;
        private System.Windows.Forms.NumericUpDown numQuality2;
        private System.Windows.Forms.Button btnStopTif;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

