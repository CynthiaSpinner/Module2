using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_grades
{
    public class Student
    {

        public string Name { get; set; } = ""; //change null with value input
        public int ID { get; set; } = 0;
        public List<double> Grades { get; set; } = []; //short for instantiating??? Research.



        public void AddGrade(double grade)
        {

           Grades.Add(grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            // if (Grades.Count == 0) return 0;
            // return Grades.Average();

            // Which one is better for CCR?
            // vvvvvvv ternary is a simple one. 
            double total = Grades.Any() ? Grades.Average() : 0; 
            //ternary to check if the list has items??

            // Think about which one to use. May change later.
            //Console.WriteLine(total); <= works
            return total;
        }
    }


}
