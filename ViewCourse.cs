using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
