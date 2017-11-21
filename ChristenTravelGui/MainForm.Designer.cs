namespace ChristenTravelGui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxInputAndSurche = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowConnections = new System.Windows.Forms.Button();
            this.dateTimePickerDepartTimeAndDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.tabControlSwitch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridVShowConnection = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBoxInputAndSurche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.tabControlSwitch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVShowConnection)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInputAndSurche
            // 
            this.groupBoxInputAndSurche.Controls.Add(this.pictureBox2);
            this.groupBoxInputAndSurche.Controls.Add(this.textBoxTo);
            this.groupBoxInputAndSurche.Controls.Add(this.textBoxFrom);
            this.groupBoxInputAndSurche.Controls.Add(this.comboBoxTo);
            this.groupBoxInputAndSurche.Controls.Add(this.comboBoxFrom);
            this.groupBoxInputAndSurche.Controls.Add(this.label1);
            this.groupBoxInputAndSurche.Controls.Add(this.buttonShowConnections);
            this.groupBoxInputAndSurche.Controls.Add(this.dateTimePickerDepartTimeAndDate);
            this.groupBoxInputAndSurche.Controls.Add(this.pictureBox1);
            this.groupBoxInputAndSurche.Controls.Add(this.labelTo);
            this.groupBoxInputAndSurche.Controls.Add(this.labelFrom);
            this.groupBoxInputAndSurche.Location = new System.Drawing.Point(16, 15);
            this.groupBoxInputAndSurche.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInputAndSurche.Name = "groupBoxInputAndSurche";
            this.groupBoxInputAndSurche.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInputAndSurche.Size = new System.Drawing.Size(1059, 216);
            this.groupBoxInputAndSurche.TabIndex = 0;
            this.groupBoxInputAndSurche.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(977, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(561, 57);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(399, 23);
            this.textBoxTo.TabIndex = 10;
            this.textBoxTo.Text = "Ort, Haltestelle";
            this.textBoxTo.Click += new System.EventHandler(this.textBoxTo_Click_1);
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            this.textBoxTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTo_KeyDown);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(35, 57);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(397, 23);
            this.textBoxFrom.TabIndex = 9;
            this.textBoxFrom.Text = "Ort, Haltestelle";
            this.textBoxFrom.Click += new System.EventHandler(this.textBoxFrom_Click);
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            this.textBoxFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFrom_KeyDown);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(561, 56);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(399, 24);
            this.comboBoxTo.TabIndex = 2;
            this.comboBoxTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxTo_KeyDown);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(34, 56);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(398, 24);
            this.comboBoxFrom.TabIndex = 1;
            this.comboBoxFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datum und Zeit";
            // 
            // buttonShowConnections
            // 
            this.buttonShowConnections.BackColor = System.Drawing.SystemColors.Control;
            this.buttonShowConnections.ForeColor = System.Drawing.Color.Black;
            this.buttonShowConnections.Location = new System.Drawing.Point(561, 128);
            this.buttonShowConnections.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowConnections.Name = "buttonShowConnections";
            this.buttonShowConnections.Size = new System.Drawing.Size(399, 52);
            this.buttonShowConnections.TabIndex = 4;
            this.buttonShowConnections.Text = "Verdbindung suchen";
            this.buttonShowConnections.UseVisualStyleBackColor = false;
            this.buttonShowConnections.Click += new System.EventHandler(this.buttonShowConnections_Click);
            // 
            // dateTimePickerDepartTimeAndDate
            // 
            this.dateTimePickerDepartTimeAndDate.CustomFormat = "dd.MM.yyyy  H:mm";
            this.dateTimePickerDepartTimeAndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDepartTimeAndDate.Location = new System.Drawing.Point(35, 141);
            this.dateTimePickerDepartTimeAndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDepartTimeAndDate.Name = "dateTimePickerDepartTimeAndDate";
            this.dateTimePickerDepartTimeAndDate.Size = new System.Drawing.Size(397, 23);
            this.dateTimePickerDepartTimeAndDate.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(556, 28);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(45, 17);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "Nach:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(29, 28);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(37, 17);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "Von:";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.tabControlSwitch);
            this.groupBoxResult.Location = new System.Drawing.Point(16, 239);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxResult.Size = new System.Drawing.Size(1059, 329);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            // 
            // tabControlSwitch
            // 
            this.tabControlSwitch.Controls.Add(this.tabPage1);
            this.tabControlSwitch.Controls.Add(this.tabPage2);
            this.tabControlSwitch.Location = new System.Drawing.Point(7, 15);
            this.tabControlSwitch.Name = "tabControlSwitch";
            this.tabControlSwitch.SelectedIndex = 0;
            this.tabControlSwitch.Size = new System.Drawing.Size(1045, 297);
            this.tabControlSwitch.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.dataGridVShowConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            // 
            // dataGridVShowConnection
            // 
            this.dataGridVShowConnection.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridVShowConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVShowConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVShowConnection.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridVShowConnection.Location = new System.Drawing.Point(0, 0);
            this.dataGridVShowConnection.Name = "dataGridVShowConnection";
            this.dataGridVShowConnection.RowTemplate.Height = 28;
            this.dataGridVShowConnection.Size = new System.Drawing.Size(1031, 268);
            this.dataGridVShowConnection.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.gMapControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1037, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Karte";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1034, 268);
            this.gMapControl1.TabIndex = 4;
            this.gMapControl1.Zoom = 0D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 586);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInputAndSurche);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Christen-Travel";
            this.groupBoxInputAndSurche.ResumeLayout(false);
            this.groupBoxInputAndSurche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.tabControlSwitch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVShowConnection)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputAndSurche;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartTimeAndDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonShowConnections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridVShowConnection;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TabControl tabControlSwitch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

