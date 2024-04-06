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

        public string Name { get; set; } = ""; 
        public int ID { get; set; } = 0;
        public List<double> Grades { get; set; } = []; //Remember: short for instantiating.



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
                        
            double total = Grades.Any() ? Grades.Average() : 0; 
            //ternary is fine here.

            
            return total;
        }
    }


}
