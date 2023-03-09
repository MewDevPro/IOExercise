using IOExercise.Properties;
using System;

namespace IOExercise
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.lCode = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lPoint = new System.Windows.Forms.Label();
            this.iCode = new System.Windows.Forms.TextBox();
            this.iName = new System.Windows.Forms.TextBox();
            this.iScore = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.oDirectory = new System.Windows.Forms.TextBox();
            this.lDirectory = new System.Windows.Forms.Label();
            this.StudentList = new System.Windows.Forms.ListView();
            this.cSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddList = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lCode.Location = new System.Drawing.Point(40, 32);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(85, 16);
            this.lCode.TabIndex = 0;
            this.lCode.Text = "Nhập mã SV:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.Location = new System.Drawing.Point(40, 72);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(103, 16);
            this.lName.TabIndex = 1;
            this.lName.Text = "Nhập họ tên SV:";
            // 
            // lPoint
            // 
            this.lPoint.AutoSize = true;
            this.lPoint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lPoint.Location = new System.Drawing.Point(40, 112);
            this.lPoint.Name = "lPoint";
            this.lPoint.Size = new System.Drawing.Size(95, 16);
            this.lPoint.TabIndex = 2;
            this.lPoint.Text = "Nhập điểm SV:";
            // 
            // iCode
            // 
            this.iCode.Font = new System.Drawing.Font("Arial", 9.75F);
            this.iCode.Location = new System.Drawing.Point(152, 24);
            this.iCode.Name = "iCode";
            this.iCode.Size = new System.Drawing.Size(264, 22);
            this.iCode.TabIndex = 3;
            // 
            // iName
            // 
            this.iName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.iName.Location = new System.Drawing.Point(152, 64);
            this.iName.Name = "iName";
            this.iName.Size = new System.Drawing.Size(264, 22);
            this.iName.TabIndex = 4;
            // 
            // iScore
            // 
            this.iScore.Font = new System.Drawing.Font("Arial", 9.75F);
            this.iScore.Location = new System.Drawing.Point(152, 104);
            this.iScore.Name = "iScore";
            this.iScore.Size = new System.Drawing.Size(264, 22);
            this.iScore.TabIndex = 5;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "DanhSachSinhVienTren8Diem";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.saveFileDialog.InitialDirectory = "C:\\";
            this.saveFileDialog.Title = "Browse Text File";
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.saveFileButton.Location = new System.Drawing.Point(456, 80);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(80, 48);
            this.saveFileButton.TabIndex = 7;
            this.saveFileButton.Text = "Lưu DS";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // oDirectory
            // 
            this.oDirectory.Font = new System.Drawing.Font("Arial", 9.75F);
            this.oDirectory.Location = new System.Drawing.Point(152, 144);
            this.oDirectory.Name = "oDirectory";
            this.oDirectory.ReadOnly = true;
            this.oDirectory.Size = new System.Drawing.Size(472, 22);
            this.oDirectory.TabIndex = 8;
            this.oDirectory.Visible = false;
            // 
            // lDirectory
            // 
            this.lDirectory.AutoSize = true;
            this.lDirectory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lDirectory.Location = new System.Drawing.Point(40, 152);
            this.lDirectory.Name = "lDirectory";
            this.lDirectory.Size = new System.Drawing.Size(60, 16);
            this.lDirectory.TabIndex = 9;
            this.lDirectory.Text = "Vị trí tệp:";
            this.lDirectory.Visible = false;
            // 
            // StudentList
            // 
            this.StudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cSTT,
            this.cCode,
            this.cName,
            this.cScore});
            this.StudentList.HideSelection = false;
            this.StudentList.Location = new System.Drawing.Point(40, 184);
            this.StudentList.Name = "StudentList";
            this.StudentList.Scrollable = false;
            this.StudentList.Size = new System.Drawing.Size(584, 296);
            this.StudentList.TabIndex = 10;
            this.StudentList.UseCompatibleStateImageBehavior = false;
            this.StudentList.View = System.Windows.Forms.View.Details;
            // 
            // cSTT
            // 
            this.cSTT.Text = "STT";
            // 
            // cCode
            // 
            this.cCode.Text = "Mã SV";
            this.cCode.Width = 80;
            // 
            // cName
            // 
            this.cName.Text = "Họ tên SV";
            this.cName.Width = 300;
            // 
            // cScore
            // 
            this.cScore.Text = "Điểm SV";
            this.cScore.Width = 132;
            // 
            // AddList
            // 
            this.AddList.Font = new System.Drawing.Font("Arial", 9.75F);
            this.AddList.Location = new System.Drawing.Point(456, 24);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(168, 48);
            this.AddList.TabIndex = 6;
            this.AddList.Text = "Thêm vào DS";
            this.AddList.UseVisualStyleBackColor = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.openFileButton.Location = new System.Drawing.Point(544, 80);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(80, 48);
            this.openFileButton.TabIndex = 11;
            this.openFileButton.Text = "Mở DS";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 517);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.AddList);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.lDirectory);
            this.Controls.Add(this.oDirectory);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.iScore);
            this.Controls.Add(this.iName);
            this.Controls.Add(this.iCode);
            this.Controls.Add(this.lPoint);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOExercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCode;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lPoint;
        private System.Windows.Forms.TextBox iCode;
        private System.Windows.Forms.TextBox iName;
        private System.Windows.Forms.TextBox iScore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.TextBox oDirectory;
        private System.Windows.Forms.Label lDirectory;
        private System.Windows.Forms.ListView StudentList;
        private System.Windows.Forms.ColumnHeader cSTT;
        private System.Windows.Forms.ColumnHeader cCode;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cScore;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

