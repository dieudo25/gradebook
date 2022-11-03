namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            Name = name;
            Grades = new();
        }

        public Book(string name, List<double> grades) : this(name)
        {
            Grades = grades;
        }

        public string Name { get; set; } = "";
        public List<double> Grades { get; set; }

        public void AddGrade(double grade) => Grades.Add(grade);

        public double GetAverage() => Grades.Average();

        public double GetHighestGrade() => Grades.Max();

        public double GetLowestGrade() => Grades.Min();

        public void GetInfo()
        {

            Console.WriteLine($"{Name} :");
            Console.WriteLine($"  - The average grade is {GetAverage():N1}");
            Console.WriteLine($"  - The highest grade is {GetHighestGrade():N1}");
            Console.WriteLine($"  - The lowest grade is {GetLowestGrade():N1}");
        }
    }
}