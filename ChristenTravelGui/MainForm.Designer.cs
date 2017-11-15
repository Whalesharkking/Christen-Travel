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
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowConnections = new System.Windows.Forms.Button();
            this.dateTimePickerDepartTimeAndDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridVShowConnection = new System.Windows.Forms.DataGridView();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.groupBoxInputAndSurche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVShowConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInputAndSurche
            // 
            this.groupBoxInputAndSurche.Controls.Add(this.comboBoxTo);
            this.groupBoxInputAndSurche.Controls.Add(this.comboBoxFrom);
            this.groupBoxInputAndSurche.Controls.Add(this.maskedTextBox1);
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
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(34, 56);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(398, 33);
            this.comboBoxFrom.TabIndex = 10;
            this.comboBoxFrom.Text = "Ort, Haltestelle";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(317, 142);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 30);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datum und Zeit";
            // 
            // buttonShowConnections
            // 
            this.buttonShowConnections.Location = new System.Drawing.Point(561, 131);
            this.buttonShowConnections.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowConnections.Name = "buttonShowConnections";
            this.buttonShowConnections.Size = new System.Drawing.Size(399, 52);
            this.buttonShowConnections.TabIndex = 7;
            this.buttonShowConnections.Text = "Verdbindung suchen";
            this.buttonShowConnections.UseVisualStyleBackColor = true;
            this.buttonShowConnections.Click += new System.EventHandler(this.buttonShowConnections_Click);
            // 
            // dateTimePickerDepartTimeAndDate
            // 
            this.dateTimePickerDepartTimeAndDate.Location = new System.Drawing.Point(35, 141);
            this.dateTimePickerDepartTimeAndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDepartTimeAndDate.Name = "dateTimePickerDepartTimeAndDate";
            this.dateTimePickerDepartTimeAndDate.Size = new System.Drawing.Size(397, 30);
            this.dateTimePickerDepartTimeAndDate.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(473, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 32);
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
            this.labelTo.Size = new System.Drawing.Size(64, 25);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "Nach:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(29, 28);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(54, 25);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "Von:";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridVShowConnection);
            this.groupBoxResult.Location = new System.Drawing.Point(16, 239);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxResult.Size = new System.Drawing.Size(1059, 329);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            // 
            // dataGridVShowConnection
            // 
            this.dataGridVShowConnection.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridVShowConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVShowConnection.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridVShowConnection.Location = new System.Drawing.Point(34, 30);
            this.dataGridVShowConnection.Name = "dataGridVShowConnection";
            this.dataGridVShowConnection.RowTemplate.Height = 28;
            this.dataGridVShowConnection.Size = new System.Drawing.Size(924, 275);
            this.dataGridVShowConnection.TabIndex = 0;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(561, 56);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(399, 33);
            this.comboBoxTo.TabIndex = 11;
            this.comboBoxTo.Text = "Ort, Haltestelle";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 595);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInputAndSurche);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Christen-Travel";
            this.groupBoxInputAndSurche.ResumeLayout(false);
            this.groupBoxInputAndSurche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVShowConnection)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
    }
}

