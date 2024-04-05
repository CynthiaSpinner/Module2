namespace student_grades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); 

            List<Student> students = new List<Student>();

            student.CalculateAverageGrade();


            Student student1 = new Student()
            {
                Name = "George",
                ID = 1234,
                Grades = [98.4, 99.6, 100, 100, 100]

            };
            

            Student student2 = new Student()
            {
                Name = "Rhea",
                ID = 2341,
                Grades = [99.8, 100, 100, 85, 100]
            };

            Student student3 = new Student()
            {
                Name = "Franke",
                ID = 3412,
                Grades = [72.4, 67.5, 65, 70.1, 27.5]
            };

            Student student4 = new Student()
            {
                Name = "Sarah",
                ID = 4123,
                Grades = [75.8, 88.2, 84.5, 89.3, 99.5]
            };

            students.AddRange([student1, student2, student3, student4]);

            foreach (Student item in students) // testing to see if students list was populated correctly 
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"ID: {item.ID}");
                Console.WriteLine($"Grades: {item.Grades}");
                Console.WriteLine(item.CalculateAverageGrade());// wondeing if i can get student average
                //it works!! but need to correct decimal to round up to hundreths place 
            }
        }

        //may have went ahead but I was wondering... oops!
    }
}
