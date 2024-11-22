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
    public partial class ModifyCourse : Form
    {
        private List<Course> courses = new List<Course>();

        public ModifyCourse()
        {
            InitializeComponent();
        }

        private void ModifyCourse_Load(object sender, EventArgs e)
        {
            string filePath = "course.txt";
            LoadCoursesFromFile(filePath);
            courseIDTextBox.Focus();
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
                        string[] parts = line.Split('|'); // Split the line into parts based on the delimiter
                        if (parts.Length >= 4) // Ensure there are enough parts for a valid course entry
                        {
                            string courseID = parts[0];
                            string courseName = parts[1];
                            string description = parts[2];

                            // Parse the capacity
                            if (int.TryParse(parts[3], out int capacity))
                            {
                                Course course = new Course(courseID, courseName, description, capacity);

                                // Add registered students, filtering out empty entries
                                for (int i = 4; i < parts.Length; i++)
                                {
                                    if (!string.IsNullOrWhiteSpace(parts[i])) // Exclude blank student entries
                                    {
                                        course.RegisteredStudents.Add(parts[i]);
                                    }
                                }

                                courses.Add(course); // Add the parsed course to the list
                            }
                            else
                            {
                                MessageBox.Show($"Invalid capacity value for course {courseID}. Skipping this entry.");
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
                MessageBox.Show("Course file not found.");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string courseID = courseIDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(courseID))
            {
                MessageBox.Show("Please enter a Course ID.");
                return;
            }

            var course = courses.FirstOrDefault(c => string.Equals(c.CourseID, courseID, StringComparison.OrdinalIgnoreCase));

            if (course == null)
            {
                MessageBox.Show("Course not found.");
                return;
            }

            // Populate fields with course details
            courseNameTextBox.Text = course.CourseName;
            descriptionTextBox.Text = course.CourseDescription;
            seatsTextBox.Text = course.CourseCapacity.ToString();
            registeredTextBox.Text = $"{course.CourseCapacity - course.RegisteredStudents.Count}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string courseID = courseIDTextBox.Text.Trim();
            var course = courses.FirstOrDefault(c => string.Equals(c.CourseID, courseID, StringComparison.OrdinalIgnoreCase));

            if (course == null)
            {
                MessageBox.Show("Course not found.");
                return;
            }

            // Validate new capacity only if newSeatsTextBox is not empty
            int newCapacity = course.CourseCapacity; // Default to the current capacity
            if (!string.IsNullOrWhiteSpace(newSeatsTextBox.Text))
            {
                if (!int.TryParse(newSeatsTextBox.Text.Trim(), out newCapacity) || newCapacity < course.RegisteredStudents.Count)
                {
                    MessageBox.Show($"Capacity must be a valid number and at least {course.RegisteredStudents.Count}.");
                    newSeatsTextBox.Focus();
                    return;
                }
            }

            // Update course details
            course.CourseName = courseNameTextBox.Text.Trim();
            course.CourseDescription = descriptionTextBox.Text.Trim();
            course.CourseCapacity = newCapacity;

            // Save changes to file
            SaveCoursesToFile();

            // Reload the course details
            ReloadCourseDetails(courseID);

            MessageBox.Show("Course updated successfully.");
        }

        private void ReloadCourseDetails(string courseID)
        {
            var course = courses.FirstOrDefault(c => string.Equals(c.CourseID, courseID, StringComparison.OrdinalIgnoreCase));

            if (course != null)
            {
                courseNameTextBox.Text = course.CourseName;
                descriptionTextBox.Text = course.CourseDescription;
                seatsTextBox.Text = course.CourseCapacity.ToString();
                registeredTextBox.Text = $"{course.CourseCapacity - course.RegisteredStudents.Count}";
                newSeatsTextBox.Clear();
            }
        }

        private void SaveCoursesToFile()
        {
            using (StreamWriter sw = new StreamWriter("course.txt"))
            {
                foreach (var course in courses)
                {
                    sw.WriteLine($"{course.CourseID}|{course.CourseName}|{course.CourseDescription}|{course.CourseCapacity}|{string.Join("|", course.RegisteredStudents)}");
                }
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
