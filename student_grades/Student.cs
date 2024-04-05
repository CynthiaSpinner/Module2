using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_grades
{
    public class Student
    {

        public string? Name { get; set; } //change null with value input
        public int Id { get; set; }
        public List<double> Grades { get; set; } = []; //short for instantiating??? 



        public void AddGrade(double grade)
        {

           Grades.Add(grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
    }


}
