using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile201_Group_Project2
{
    public partial class ViewCourse : Form
    {
        private List<Course> courses = new List<Course>();
        public ViewCourse()
        {
            InitializeComponent();
        }

        private Course currentCourse;
        private void ViewCourse_Load(object sender, EventArgs e)
        {
            if (File.Exists("course.txt"))
            {
                using (StreamReader sr = new StreamReader("course.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] courseData = line.Split('|');

                        if (courseData.Length >= 4)
                        {
                            string courseID = courseData[0];
                            string courseName = courseData[1];
                            string description = courseData[2];
                            int capacity;

                            if (int.TryParse(courseData[3], out capacity))
                            {
                                Course course = new Course(courseID, courseName, description, capacity);

                                for (int i = 4; i < courseData.Length; i++)
                                {
                                    course.RegisteredStudents.Add(courseData[i]);
                                }

                                courses.Add(course);
                            }
                            else
                            {
                                MessageBox.Show($"Invalid capacity value for course: {courseID}. Skipping this course.");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid course data format. Skipping line: {line}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Courses file not found.");
            }
        }

        private void purgeButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string courseID = courseIDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(courseID))
            {
                MessageBox.Show("Please enter a course ID.");
                return;
            }

            var course = courses.FirstOrDefault(c => string.Equals(c.CourseID, courseID, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                MessageBox.Show("Course not found.");
                return;
            }
            currentCourse = course;
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += printDocument1_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string courseID = courseIDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(courseID))
            {
                MessageBox.Show("Please enter a course ID.");
                return;
            }
            var course = courses.FirstOrDefault(c => string.Equals(c.CourseID, courseID, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                MessageBox.Show("Course not found.");
                return;
            }
            courseListBox.Items.Clear();
            courseListBox.Items.Add($"ID: {course.CourseID}");
            courseListBox.Items.Add($"Name: {course.CourseName}");
            courseListBox.Items.Add($"Description: {course.CourseDescription}");
            int registeredCount = course.RegisteredStudents.Count;
            courseListBox.Items.Add($"Capacity: {registeredCount}/{course.CourseCapacity}");
            courseListBox.Items.Add("");
            courseListBox.Items.Add("Registered Students:");
            foreach (var student in course.RegisteredStudents)
            {
                courseListBox.Items.Add(student);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (currentCourse == null)
            {
                MessageBox.Show("No course selected for printing.");
                return;
            }
            Font printFont = new Font("Arial", 12);
            Brush printBrush = Brushes.Black;

            float yPosition = 20;
            float xPosition = 20;
            float lineHeight = printFont.GetHeight();

            string title = "Course Information";
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            float titleWidth = e.Graphics.MeasureString(title, titleFont).Width;
            xPosition = (e.PageBounds.Width - titleWidth) / 2;
            e.Graphics.DrawString(title, titleFont, printBrush, xPosition, yPosition);
            yPosition += titleFont.GetHeight() + 10;


            e.Graphics.DrawString($"Course ID: {currentCourse.CourseID}", printFont, printBrush, 20, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString($"Course Name: {currentCourse.CourseName}", printFont, printBrush, 20, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString($"Description: {currentCourse.CourseDescription}", printFont, printBrush, 20, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString($"Capacity: {currentCourse.RegisteredStudents.Count}/{currentCourse.CourseCapacity}", printFont, printBrush, 20, yPosition);
            yPosition += lineHeight + 10;

            e.Graphics.DrawString("Registered Students:", printFont, printBrush, 20, yPosition);
            yPosition += lineHeight;

            foreach (var student in currentCourse.RegisteredStudents)
            {
                e.Graphics.DrawString(student, printFont, printBrush, 20, yPosition);
                yPosition += lineHeight;
            }

            if (yPosition > e.MarginBounds.Bottom)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

        }
    }
}
