namespace ULMSWinFormsAppClient
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            grpStudent = new GroupBox();
            txtReport = new TextBox();
            btnReport = new Button();
            lblAverage = new Label();
            btnAverage = new Button();
            lstMarks = new ListBox();
            btnAddMark = new Button();
            txtMark = new TextBox();
            lstCourses = new ListBox();
            btnEnroll = new Button();
            txtCourse = new TextBox();
            btnRegister = new Button();
            txtFullName = new TextBox();
            txtStudentNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            grpStudent.SuspendLayout();
            SuspendLayout();

            // txtUsername
            txtUsername.Location = new Point(145, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 27);

            // txtPassword
            txtPassword.Location = new Point(145, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 27);

            // btnLogin
            btnLogin.Location = new Point(145, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 35);
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            // grpStudent
            grpStudent.Controls.Add(txtReport);
            grpStudent.Controls.Add(btnReport);
            grpStudent.Controls.Add(lblAverage);
            grpStudent.Controls.Add(btnAverage);
            grpStudent.Controls.Add(lstMarks);
            grpStudent.Controls.Add(btnAddMark);
            grpStudent.Controls.Add(txtMark);
            grpStudent.Controls.Add(lstCourses);
            grpStudent.Controls.Add(btnEnroll);
            grpStudent.Controls.Add(txtCourse);
            grpStudent.Controls.Add(btnRegister);
            grpStudent.Controls.Add(txtFullName);
            grpStudent.Controls.Add(txtStudentNumber);
            grpStudent.Controls.Add(label3);
            grpStudent.Controls.Add(label4);
            grpStudent.Controls.Add(label5);
            grpStudent.Controls.Add(label6);

            grpStudent.Enabled = false;
            grpStudent.Location = new Point(25, 170);
            grpStudent.Name = "grpStudent";
            grpStudent.Size = new Size(740, 420);
            grpStudent.Text = "Student Management";

            // txtStudentNumber
            txtStudentNumber.Location = new Point(170, 35);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(180, 27);

            // txtFullName
            txtFullName.Location = new Point(170, 75);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(180, 27);

            // btnRegister
            btnRegister.Location = new Point(170, 115);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(180, 35);
            btnRegister.Text = "Register Student";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;

            // txtCourse
            txtCourse.Location = new Point(170, 170);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(180, 27);

            // btnEnroll
            btnEnroll.Location = new Point(170, 210);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(180, 35);
            btnEnroll.Text = "Enroll Course";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;

            // lstCourses
            lstCourses.FormattingEnabled = true;
            lstCourses.Location = new Point(380, 35);
            lstCourses.Name = "lstCourses";
            lstCourses.Size = new Size(150, 104);

            // txtMark
            txtMark.Location = new Point(170, 270);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(180, 27);

            // btnAddMark
            btnAddMark.Location = new Point(170, 310);
            btnAddMark.Name = "btnAddMark";
            btnAddMark.Size = new Size(180, 35);
            btnAddMark.Text = "Add Mark";
            btnAddMark.UseVisualStyleBackColor = true;
            btnAddMark.Click += btnAddMark_Click;

            // lstMarks
            lstMarks.FormattingEnabled = true;
            lstMarks.Location = new Point(380, 170);
            lstMarks.Name = "lstMarks";
            lstMarks.Size = new Size(150, 104);

            // btnAverage
            btnAverage.Location = new Point(170, 360);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(180, 35);
            btnAverage.Text = "Calculate Average";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;

            // lblAverage
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(380, 368);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(72, 20);
            lblAverage.Text = "Average:";

            // btnReport
            btnReport.Location = new Point(560, 35);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 35);
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;

            // txtReport
            txtReport.Location = new Point(560, 85);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.ScrollBars = ScrollBars.Vertical;
            txtReport.Size = new Size(150, 290);

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.Text = "Username";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(40, 73);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.Text = "Password";

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(30, 38);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.Text = "Student Number";

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(30, 78);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.Text = "Full Name";

            // label5
            label5.AutoSize = true;
            label5.Location = new Point(30, 173);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.Text = "Course";

            // label6
            label6.AutoSize = true;
            label6.Location = new Point(30, 273);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.Text = "Mark";

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);

            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(grpStudent);

            Name = "Form1";
            Text = "Umoja Learning Management System";

            grpStudent.ResumeLayout(false);
            grpStudent.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private GroupBox grpStudent;
        private TextBox txtStudentNumber;
        private TextBox txtFullName;
        private Button btnRegister;
        private TextBox txtCourse;
        private Button btnEnroll;
        private ListBox lstCourses;
        private TextBox txtMark;
        private Button btnAddMark;
        private ListBox lstMarks;
        private Button btnAverage;
        private Label lblAverage;
        private Button btnReport;
        private TextBox txtReport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}