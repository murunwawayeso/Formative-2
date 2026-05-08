using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ULMSWinFormsAppClient
{
    public partial class Form1 : Form
    {
        
        // STUDENT LIST
        
        List<Student> students = new List<Student>();

        Student currentStudent = null;

        public Form1()
        {
            InitializeComponent();
        }

       
        // LOGIN BUTTON
        // Username: Ntokozo
        // Password: 1234
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // BLOCKED
                if (username == "" || password == "")
                {
                    MessageBox.Show(
                        "BLOCKED\n\nUsername or Password cannot be empty.",
                        "Login Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // PASS
                if (username == "Ntokozo" &&password == "1234")
                {
                    MessageBox.Show(
                        "PASS\n\nLogin Successful.",
                        "Login Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    grpStudent.Enabled = true;
                }

                // FAIL
                else
                {
                    MessageBox.Show(
                        "FAIL\n\nInvalid Username or Password.",
                        "Login Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "System Error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        // REGISTER STUDENT
      
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentNumber.Text == "" || txtFullName.Text == "")
                {
                    MessageBox.Show("Enter student details");
                    return;
                }

                Student student = new Student();

                student.StudentNumber = txtStudentNumber.Text;
                student.FullName = txtFullName.Text;

                students.Add(student);

                currentStudent = student;

                MessageBox.Show(
                    "Student Registered Successfully",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        // ENROLL COURSE
        
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentStudent == null)
                {
                    MessageBox.Show("Register student first");
                    return;
                }

                string course = txtCourse.Text.Trim();

                if (course == "")
                {
                    MessageBox.Show("Enter course name");
                    return;
                }

                // DUPLICATE CHECK
                if (currentStudent.Courses.Contains(course))
                {
                    MessageBox.Show(
                        "Course already enrolled",
                        "Duplicate",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                currentStudent.Courses.Add(course);

                lstCourses.Items.Add(course);

                MessageBox.Show(
                    "Course Enrolled Successfully",
                    "Enrollment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        // ADD MARK
        
        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentStudent == null)
                {
                    MessageBox.Show("Register student first");
                    return;
                }

                double mark;

                bool validMark = double.TryParse(txtMark.Text, out mark);

                // INVALID NUMBER
                if (!validMark)
                {
                    MessageBox.Show(
                        "Enter numeric value only",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // RANGE VALIDATION
                if (mark < 0 || mark > 100)
                {
                    MessageBox.Show(
                        "Mark must be between 0 and 100",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                currentStudent.Marks.Add(mark);

                lstMarks.Items.Add(mark);

                MessageBox.Show(
                    "Mark Added Successfully",
                    "Marks",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 
        // CALCULATE AVERAGE
        // SHOW PASS OR FAIL
      
        private void btnAverage_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentStudent == null)
                {
                    MessageBox.Show("No student selected");
                    return;
                }

                if (currentStudent.Marks.Count == 0)
                {
                    MessageBox.Show("No marks captured");
                    return;
                }

                double average = currentStudent.CalculateAverage();

                lblAverage.Text =
                    "Average: " + average.ToString("0.00") + "%";

                // PASS
                if (average >= 50)
                {
                    MessageBox.Show(
                        "STUDENT PASSED\n\nAverage: "
                        + average.ToString("0.00") + "%",
                        "Results",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                // FAIL
                else
                {
                    MessageBox.Show(
                        "STUDENT FAILED\n\nAverage: "
                        + average.ToString("0.00") + "%",
                        "Results",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        // GENERATE REPORT
       
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentStudent == null)
                {
                    MessageBox.Show("No student selected");
                    return;
                }

                StringBuilder report = new StringBuilder();

                report.AppendLine("ULMS STUDENT REPORT");
                report.AppendLine();

                report.AppendLine("Student Number: "
                    + currentStudent.StudentNumber);

                report.AppendLine("Full Name: "
                    + currentStudent.FullName);

                report.AppendLine();

                report.AppendLine("COURSES");

                foreach (string course in currentStudent.Courses)
                {
                    report.AppendLine(course);
                }

                report.AppendLine();

                report.AppendLine("MARKS");

                foreach (double mark in currentStudent.Marks)
                {
                    report.AppendLine(mark.ToString());
                }

                double average =
                    currentStudent.CalculateAverage();

                report.AppendLine();

                report.AppendLine("Average: "
                    + average.ToString("0.00") + "%");

                // PASS OR FAIL
                if (average >= 50)
                {
                    report.AppendLine("Final Result: PASS");
                }
                else
                {
                    report.AppendLine("Final Result: FAIL");
                }

                txtReport.Text = report.ToString();

                MessageBox.Show(
                    "Report Generated Successfully",
                    "Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public class Student
        {
            public string StudentNumber { get; set; }
            public string FullName { get; set; }

            public List<string> Courses = new List<string>();

            public List<double> Marks = new List<double>();

            public double CalculateAverage()
            {
                if (Marks.Count == 0)
                    return 0;

                double total = 0;

                foreach (double mark in Marks)
                {
                    total += mark;
                }

                return total / Marks.Count;
            }
        }
    }
}
