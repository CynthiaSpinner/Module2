using System;
using System.Diagnostics;

namespace student_grades
{
    public class Program
    {
        static void Main(string[] args)
        {
                               
            Student student = new Student();

            List<Student> students = new List<Student>();

            student.CalculateAverageGrade();

            //course-----------------------------

            Course cSharp = new Course()
            {
                CourseName = "Software Engineering",
                CourseCode = "12345678",
                Name = "George, Rhea"
            };

            //student 1---------------------------

            Student student1 = new Student()
            {
                Name = "George",
                ID = 1234,
                Grades = [98.4, 99.6, 100, 100, 100]

            };

                    //add grades-------------------------

            student1.AddGrade(98.6);
            student1.AddGrade(89.5, 100, 99.5);

                    //add to course----------------------

            cSharp.AddStudent(student1);

            //student 2----------------------

            Student student2 = new Student()
            {
                Name = "Rhea",
                ID = 2341,
                Grades = [99.8, 100, 100, 85, 100]
            };

            student2.AddGrade(100);
            student2.AddGrade(100, 100, 99.9);

            cSharp.AddStudent(student2);

            //cSharp.AddStudent(student2); //tested no dublicates. Works.

            //student 3-----------------------

            Student student3 = new Student()
            {
                Name = "Franke",
                ID = 3412,
                Grades = [72.4, 67.5, 65, 70.1, 27.5]
            };

            student3.AddGrade(100);
            student3.AddGrade(75.3, 68.7, 90);

            //student 4------------------------

            Student student4 = new Student()
            {
                Name = "Sarah",
                ID = 4123,
                Grades = [75.8, 88.2, 84.5, 89.3, 99.5]
            };

            student4.AddGrade(82.5);
            student4.AddGrade(92.4, 90, 88);

            //add students to list--------------

            students.AddRange([student1, student2, student3, student4]);

            //print student info----------------

            foreach (Student item in students)  
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"ID: {item.ID}");
                
                Console.WriteLine($"Grades:"); 

            //print grades----------------------
            
                foreach (double grade in item.Grades)
                {
                    Console.Write($"{grade}, ");
                }

                Console.WriteLine();
                Console.WriteLine("Average:");
                
            //calculated average and print -------

                Console.WriteLine(Math.Round(item.CalculateAverageGrade(), 1));// decided on tenth place instead
                
                Console.WriteLine();

                Console.WriteLine("----------------");

                Console.WriteLine();
            }

            //print course info----------------------

            Console.WriteLine($"Course: {cSharp.CourseName}\nCourse Code: {cSharp.CourseCode}\n--------------------------\nEnrolled: ");

            //print enrolled students-----------------

            foreach (Student item in cSharp.EnrolledStudents)
            {
                Console.WriteLine($"  -{item.Name} Id: {item.ID}");
            }


        }
        

        

    }
}
