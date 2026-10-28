namespace Bai53
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            gbGender = new GroupBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkMaterial = new CheckBox();
            chkCertificate = new CheckBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(152, 50);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(125, 27);
            mtxtPhone.TabIndex = 0;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(152, 100);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 1;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(152, 152);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(151, 28);
            cboCourse.TabIndex = 2;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdoMale);
            gbGender.Controls.Add(rdoFemale);
            gbGender.Location = new Point(441, 73);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(184, 67);
            gbGender.TabIndex = 3;
            gbGender.TabStop = false;
            gbGender.Text = "Giới tính";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(27, 26);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 4;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(105, 26);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(50, 24);
            rdoFemale.TabIndex = 5;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // chkMaterial
            // 
            chkMaterial.AutoSize = true;
            chkMaterial.Location = new Point(339, 156);
            chkMaterial.Name = "chkMaterial";
            chkMaterial.Size = new Size(134, 24);
            chkMaterial.TabIndex = 4;
            chkMaterial.Text = "Nhận giáo trình";
            chkMaterial.UseVisualStyleBackColor = true;
            // 
            // chkCertificate
            // 
            chkCertificate.AutoSize = true;
            chkCertificate.Location = new Point(489, 156);
            chkCertificate.Name = "chkCertificate";
            chkCertificate.Size = new Size(203, 24);
            chkCertificate.TabIndex = 5;
            chkCertificate.Text = "Cấp chứng chỉ hoàn thành";
            chkCertificate.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(325, 219);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng kí";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 100);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 53);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 8;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 155);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 9;
            label3.Text = "Khóa học:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 306);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(chkCertificate);
            Controls.Add(chkMaterial);
            Controls.Add(gbGender);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxtPhone);
            Name = "Form1";
            Text = "Đăng ký khóa học";
            Load += Form1_Load;
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private GroupBox gbGender;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkMaterial;
        private CheckBox chkCertificate;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
