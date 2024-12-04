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
            string studentID = studentIDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a student ID.");
                return;
            }

            if (courseListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a course to remove.");
                return;
            }

            // Extract course ID from the selected item
            string selectedCourseInfo = courseListBox.SelectedItem.ToString();
            string selectedCourseID = selectedCourseInfo.Replace("Course ID: ", "").Trim();
            // Find the selected course
            Course course = courses.FirstOrDefault(c => c.CourseID == selectedCourseID);
            if (course == null)
            {
                MessageBox.Show("Selected course not found.");
                return;
            }

            // Remove the student from the course
            if (course.RegisteredStudents.Contains(studentID))
            {
                course.RegisteredStudents.Remove(studentID);

                // Save the updated courses back to the file
                using (StreamWriter sw = new StreamWriter("course.txt"))
                {
                    foreach (var c in courses)
                    {
                        sw.WriteLine($"{c.CourseID}|{c.CourseName}|{c.CourseDescription}|{c.CourseCapacity}|{string.Join("|", c.RegisteredStudents)}");
                    }
                }

                // Refresh the student courses list
                findButton_Click(null, null);

                MessageBox.Show($"Student {studentID} removed from course {selectedCourseID}.");
            }
            else
            {
                MessageBox.Show($"Student {studentID} is not registered for course {selectedCourseID}.");
            }
        }
    }
}
