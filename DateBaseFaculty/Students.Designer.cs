using System.Windows.Forms;

namespace DateBaseFaculty
{
    partial class Students
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.LastTxtBox = new System.Windows.Forms.TextBox();
            this.FirstTxtBox = new System.Windows.Forms.TextBox();
            this.firstlbl = new System.Windows.Forms.Label();
            this.AgeTxtBox = new System.Windows.Forms.TextBox();
            this.Agelbl = new System.Windows.Forms.Label();
            this.Contacts = new System.Windows.Forms.Label();
            this.Citylbl = new System.Windows.Forms.Label();
            this.CitytxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.StudentLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnStudent = new System.Windows.Forms.RadioButton();
            this.radioBtnTeacher = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(15, 244);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // LastTxtBox
            // 
            this.LastTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.LastTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastTxtBox.Location = new System.Drawing.Point(157, 237);
            this.LastTxtBox.Name = "LastTxtBox";
            this.LastTxtBox.Size = new System.Drawing.Size(151, 26);
            this.LastTxtBox.TabIndex = 1;
            // 
            // FirstTxtBox
            // 
            this.FirstTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.FirstTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTxtBox.Location = new System.Drawing.Point(157, 302);
            this.FirstTxtBox.Name = "FirstTxtBox";
            this.FirstTxtBox.Size = new System.Drawing.Size(151, 26);
            this.FirstTxtBox.TabIndex = 5;
            // 
            // firstlbl
            // 
            this.firstlbl.AutoSize = true;
            this.firstlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstlbl.Location = new System.Drawing.Point(15, 309);
            this.firstlbl.Name = "firstlbl";
            this.firstlbl.Size = new System.Drawing.Size(86, 20);
            this.firstlbl.TabIndex = 4;
            this.firstlbl.Text = "First Name";
            // 
            // AgeTxtBox
            // 
            this.AgeTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.AgeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTxtBox.Location = new System.Drawing.Point(157, 360);
            this.AgeTxtBox.Name = "AgeTxtBox";
            this.AgeTxtBox.Size = new System.Drawing.Size(151, 26);
            this.AgeTxtBox.TabIndex = 7;
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agelbl.Location = new System.Drawing.Point(15, 366);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(38, 20);
            this.Agelbl.TabIndex = 6;
            this.Agelbl.Text = "Age";
            // 
            // Contacts
            // 
            this.Contacts.AutoSize = true;
            this.Contacts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacts.ForeColor = System.Drawing.Color.SteelBlue;
            this.Contacts.Location = new System.Drawing.Point(205, 107);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(80, 22);
            this.Contacts.TabIndex = 8;
            this.Contacts.Text = "Teachers";
            // 
            // Citylbl
            // 
            this.Citylbl.AutoSize = true;
            this.Citylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citylbl.Location = new System.Drawing.Point(21, 430);
            this.Citylbl.Name = "Citylbl";
            this.Citylbl.Size = new System.Drawing.Size(35, 20);
            this.Citylbl.TabIndex = 9;
            this.Citylbl.Text = "City";
            // 
            // CitytxtBox
            // 
            this.CitytxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.CitytxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitytxtBox.Location = new System.Drawing.Point(160, 424);
            this.CitytxtBox.Name = "CitytxtBox";
            this.CitytxtBox.Size = new System.Drawing.Size(151, 26);
            this.CitytxtBox.TabIndex = 10;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.AddressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxtBox.Location = new System.Drawing.Point(160, 486);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(151, 26);
            this.AddressTxtBox.TabIndex = 12;
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(21, 492);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(68, 20);
            this.addresslbl.TabIndex = 11;
            this.addresslbl.Text = "Address";
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.PhoneTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxtBox.Location = new System.Drawing.Point(157, 544);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(151, 26);
            this.PhoneTxtBox.TabIndex = 14;
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelbl.Location = new System.Drawing.Point(18, 550);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(55, 20);
            this.Phonelbl.TabIndex = 13;
            this.Phonelbl.Text = "Phone";
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBtn.Location = new System.Drawing.Point(42, 609);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 30);
            this.AddBtn.TabIndex = 17;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // StudentLbl
            // 
            this.StudentLbl.AutoSize = true;
            this.StudentLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.StudentLbl.Location = new System.Drawing.Point(7, 107);
            this.StudentLbl.Name = "StudentLbl";
            this.StudentLbl.Size = new System.Drawing.Size(82, 22);
            this.StudentLbl.TabIndex = 18;
            this.StudentLbl.Text = "Students";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(157, 609);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 30);
            this.UpdateBtn.TabIndex = 19;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(267, 609);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 30);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(385, 609);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 30);
            this.ClearBtn.TabIndex = 21;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click_1);
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ReadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBtn.Location = new System.Drawing.Point(504, 609);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 30);
            this.ReadBtn.TabIndex = 22;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 390);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // txtBoxId
            // 
            this.txtBoxId.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(157, 180);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(151, 26);
            this.txtBoxId.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // radioBtnStudent
            // 
            this.radioBtnStudent.AutoSize = true;
            this.radioBtnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnStudent.Location = new System.Drawing.Point(39, 150);
            this.radioBtnStudent.Name = "radioBtnStudent";
            this.radioBtnStudent.Size = new System.Drawing.Size(14, 13);
            this.radioBtnStudent.TabIndex = 29;
            this.radioBtnStudent.TabStop = true;
            this.radioBtnStudent.UseVisualStyleBackColor = true;
            this.radioBtnStudent.CheckedChanged += new System.EventHandler(this.RadioBtnStudent_CheckedChanged);
            // 
            // radioBtnTeacher
            // 
            this.radioBtnTeacher.AutoSize = true;
            this.radioBtnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnTeacher.Location = new System.Drawing.Point(236, 150);
            this.radioBtnTeacher.Name = "radioBtnTeacher";
            this.radioBtnTeacher.Size = new System.Drawing.Size(14, 13);
            this.radioBtnTeacher.TabIndex = 30;
            this.radioBtnTeacher.TabStop = true;
            this.radioBtnTeacher.UseVisualStyleBackColor = true;
            this.radioBtnTeacher.CheckedChanged += new System.EventHandler(this.RadioBtnTeacher_CheckedChanged);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 665);
            this.Controls.Add(this.radioBtnTeacher);
            this.Controls.Add(this.radioBtnStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.StudentLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.Phonelbl);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.CitytxtBox);
            this.Controls.Add(this.Citylbl);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.AgeTxtBox);
            this.Controls.Add(this.Agelbl);
            this.Controls.Add(this.FirstTxtBox);
            this.Controls.Add(this.firstlbl);
            this.Controls.Add(this.LastTxtBox);
            this.Controls.Add(this.lblLastName);
            this.Name = "Students";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox LastTxtBox;
        private System.Windows.Forms.TextBox FirstTxtBox;
        private System.Windows.Forms.Label firstlbl;
        private System.Windows.Forms.TextBox AgeTxtBox;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.Label Contacts;
        private System.Windows.Forms.Label Citylbl;
        private System.Windows.Forms.TextBox CitytxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label StudentLbl;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TextBox txtBoxId;
        private Label label1;
        private RadioButton radioBtnStudent;
        private RadioButton radioBtnTeacher;

        public TextBox PhoneTxtBox1 { get => PhoneTxtBox; set => PhoneTxtBox = value; }
    }
}

