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
    public partial class AddStudent : Form
    {
        List<Course> courses = new List<Course>();

        public AddStudent()
        {
            InitializeComponent();
        }

        // Event handler for form load to read courses from the file
        private void AddStudent_Load(object sender, EventArgs e)
        {
            addLabel.Text = "";
            // Read courses from the file on form load
            if (File.Exists("course.txt"))
            {
                using (StreamReader sr = new StreamReader("course.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] courseData = line.Split('|');

                        // Check if courseData has enough fields (at least 4 for ID, Name, Description, Capacity)
                        if (courseData.Length >= 4)
                        {
                            string courseID = courseData[0];
                            string courseName = courseData[1];
                            string description = courseData[2];
                            int capacity;

                            // Check if the capacity is a valid number
                            if (int.TryParse(courseData[3], out capacity))
                            {
                                Course course = new Course(courseID, courseName, description, capacity);

                                // Parse and add registered students to the course
                                for (int i = 4; i < courseData.Length; i++)
                                {
                                    course.RegisteredStudents.Add(courseData[i]);
                                }

                                courses.Add(course); // Add the course to the courses list
                            }
                            else
                            {
                                MessageBox.Show($"Invalid capacity value for course: {courseID}. Skipping this course.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid course data format in file. Skipping line: " + line);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Courses file not found.");
            }
        }

        // Event handler for "Find" button click (search for the course)
        private void findButton_Click(object sender, EventArgs e)
        {
            string courseID = courseIDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(courseID))
            {
                MessageBox.Show("Please enter a Course ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search for the course based on Course ID
            Course course = courses.FirstOrDefault(c => c.CourseID == courseID);

            if (course != null)
            {
                // Show the number of seats available in the Seats Available text box
                seatsTextBox.Text = (course.CourseCapacity - course.RegisteredStudents.Count).ToString();
            }
            else
            {
                MessageBox.Show("Course not found.");
            }
        }

        // Event handler for "Add" button click (add student to the course)
        private void addButton_Click(object sender, EventArgs e)
        {
            string courseID = courseIDTextBox.Text.Trim();
            string studentID = studentIDTextBox.Text.Trim();

            // Find the course based on the Course ID
            Course course = courses.FirstOrDefault(c => c.CourseID == courseID);

            if (course != null)
            {
                if (course.RegisteredStudents.Count < course.CourseCapacity)
                {
                    if (!course.RegisteredStudents.Contains(studentID))
                    {
                        // Add the student to the course
                        course.AddStudent(studentID);
                        addLabel.Text = $"{studentID} added successfully.";

                        // Update available seats
                        seatsTextBox.Text = (course.CourseCapacity - course.RegisteredStudents.Count).ToString();

                        // Save updated course data to the file
                        using (StreamWriter sw = new StreamWriter("course.txt"))
                        {
                            foreach (var c in courses)
                            {
                                sw.WriteLine($"{c.CourseID}|{c.CourseName}|{c.CourseDescription}|{c.CourseCapacity}|{string.Join("|", c.RegisteredStudents)}");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student is already registered for this course.");
                    }
                }
                else
                {
                    MessageBox.Show("No seats available.");
                }
            }
            else
            {
                MessageBox.Show("Course not found.");
            }
        }


        // Event handler for "Save" button click (save course data back to the file)
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save updated course data to the file
            using (StreamWriter sw = new StreamWriter("course.txt"))
            {
                foreach (var course in courses)
                {
                    // Write each course's data (including registered students) in CSV format
                    sw.WriteLine(course); // This will call the Course.ToString() method
                }
            }

            MessageBox.Show("Course data saved.");
        }

        // Event handler for "Close" button click (close the form)
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}