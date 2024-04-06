using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_grades
{
    public class Course : Student
    {
        
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public List<Student> EnrolledStudents { get; set; } 

        
        
        public Course() //Note to self: dont remember why this default contructor is here. review.
        {

             EnrolledStudents = new List<Student>(); // Not sure if I did this right. 



        }
        public void AddStudent(Student student)
        {
          
            if (!EnrolledStudents.Contains(student)) EnrolledStudents.Add(student); //No duplicate method && add method
            
            //EnrolledStudents.Exists(enrolledStudent => enrolledStudent.ID == student.ID);
            //EnrolledStudents.Add(student);
            
                 
        }


    }
}
