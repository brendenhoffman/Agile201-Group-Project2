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
    public partial class ViewStudent : Form
    {

        private List<Course> courses = new List<Course>();

        public ViewStudent()
        {
            InitializeComponent();
        }

        private void LoadCoursesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length >= 4)
                        {
                            string courseID = parts[0];
                            string courseName = parts[1];
                            string description = parts[2];
                            if (int.TryParse(parts[3], out int capacity))
                            {
                                Course course = new Course(courseID, courseName, description, capacity);

                                // Add registered students (if any)
                                for (int i = 4; i < parts.Length; i++)
                                {
                                    course.RegisteredStudents.Add(parts[i]);
                                }

                                courses.Add(course);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Course file not found.");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string studentID = studentIDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a student ID.");
                return;
            }

            courseListBox.Items.Clear();

            // Ensure we only check the RegisteredStudents list for matches
            var matchingCourses = courses
                .Where(c => c.RegisteredStudents.Any(s => string.Equals(s, studentID, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            if (matchingCourses.Any())
            {
                foreach (var course in matchingCourses)
                {
                    courseListBox.Items.Add($"Course ID: {course.CourseID}");
                }
            }
            else
            {
                MessageBox.Show("No courses found for this student.");
            }
        }


        private void ViewStudent_Load(object sender, EventArgs e)
        {
            string filePath = "course.txt";
            LoadCoursesFromFile(filePath);
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeCourseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
