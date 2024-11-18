using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile201_Group_Project2
{
    internal class Course
    {
        // Fields
        private string courseID;
        private string courseName;
        private string courseDescription;
        private int courseCapacity;
        private List<string> registeredStudents;

        // Properties
        public string CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string CourseDescription
        {
            get { return courseDescription; }
            set { courseDescription = value; }
        }

        public int CourseCapacity
        {
            get { return courseCapacity; }
            set
            {
                if (value < RegisteredStudents.Count)
                {
                    throw new ArgumentException("Capacity cannot be less than the number of currently registered students.");
                }
                courseCapacity = value;
            }
        }

        public List<string> RegisteredStudents
        {
            get { return registeredStudents; }
        }

        // Constructors
        public Course(string courseID, string courseName, string courseDescription, int courseCapacity)
        {
            CourseID = courseID;
            CourseName = courseName;
            CourseDescription = courseDescription;
            CourseCapacity = courseCapacity;
            registeredStudents = new List<string>();
        }

        // Methods

        // Add a student to the course
        public virtual bool AddStudent(string studentID)
        {
            if (registeredStudents.Count < courseCapacity && !registeredStudents.Contains(studentID))
            {
                registeredStudents.Add(studentID);
                return true;
            }
            return false; // Return false if the course is full or the student is already registered
        }

        // Remove a student from the course
        public virtual bool RemoveStudent(string studentID)
        {
            return registeredStudents.Remove(studentID); // Return true if successful
        }

        // Check if the course is full
        public virtual bool IsFull()
        {
            return registeredStudents.Count >= courseCapacity;
        }

        // Check if the course is empty
        public virtual bool IsEmpty()
        {
            return registeredStudents.Count == 0;
        }

        // ToString
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Course ID: {CourseID}");
            str.AppendLine($"Course Name: {CourseName}");
            str.AppendLine($"Description: {CourseDescription}");
            str.AppendLine($"Capacity: {RegisteredStudents.Count}/{CourseCapacity}");
            str.AppendLine("Registered Students:");

            if (registeredStudents.Any())
            {
                foreach (var student in registeredStudents)
                {
                    str.AppendLine($"- {student}");
                }
            }
            else
            {
                str.AppendLine("No students are currently registered.");
            }

            return str.ToString();
        }
    }
}
