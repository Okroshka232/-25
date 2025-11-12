namespace SimpleImageConverterWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.radioPngToJpg = new System.Windows.Forms.RadioButton();
            this.radioJpgToPng = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            //txtFilePath
            this.txtFilePath.Location = new System.Drawing.Point(27, 49);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(399, 22);
            this.txtFilePath.TabIndex = 0;
             
            //btnBrowseFile
            this.btnBrowseFile.Location = new System.Drawing.Point(446, 49);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(80, 28);
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "Обзор";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
             
            //radioPngToJpg
            this.radioPngToJpg.AutoSize = true;
            this.radioPngToJpg.Checked = true;
            this.radioPngToJpg.Location = new System.Drawing.Point(27, 98);
            this.radioPngToJpg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPngToJpg.Name = "radioPngToJpg";
            this.radioPngToJpg.Size = new System.Drawing.Size(102, 20);
            this.radioPngToJpg.TabIndex = 2;
            this.radioPngToJpg.TabStop = true;
            this.radioPngToJpg.Text = "PNG → JPG";
            this.radioPngToJpg.UseVisualStyleBackColor = true;
            
            //radioJpgToPng
            this.radioJpgToPng.AutoSize = true;
            this.radioJpgToPng.Location = new System.Drawing.Point(160, 98);
            this.radioJpgToPng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioJpgToPng.Name = "radioJpgToPng";
            this.radioJpgToPng.Size = new System.Drawing.Size(102, 20);
            this.radioJpgToPng.TabIndex = 3;
            this.radioJpgToPng.Text = "JPG → PNG";
            this.radioJpgToPng.UseVisualStyleBackColor = true;
            this.radioJpgToPng.CheckedChanged += new System.EventHandler(this.radioJpgToPng_CheckedChanged);
            
            // btnConvert
            this.btnConvert.BackColor = System.Drawing.Color.LightGreen;
            this.btnConvert.Location = new System.Drawing.Point(293, 93);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(133, 31);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            
            // txtFolderPath
            this.txtFolderPath.Location = new System.Drawing.Point(27, 160);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(399, 22);
            this.txtFolderPath.TabIndex = 5;
            
            // btnBrowseFolder
            this.btnBrowseFolder.Location = new System.Drawing.Point(440, 158);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(80, 28);
            this.btnBrowseFolder.TabIndex = 6;
            this.btnBrowseFolder.Text = "Обзор";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            
            // btnMove
            this.btnMove.BackColor = System.Drawing.Color.LightBlue;
            this.btnMove.Location = new System.Drawing.Point(293, 191);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(133, 31);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "Переместить";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            
            // label1 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "1. Выберите изображение:";
            
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "2. Или выберите папку для переноса:";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.radioJpgToPng);
            this.Controls.Add(this.radioPngToJpg);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFilePath);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер изображений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.RadioButton radioPngToJpg;
        private System.Windows.Forms.RadioButton radioJpgToPng;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
