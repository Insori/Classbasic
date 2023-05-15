namespace MyApp
{
    internal class Student
    {
        public string name;
        public int grade;

        public override string? ToString()
        {
            return this.grade + "학년 " + this.name;
        }
    }
}