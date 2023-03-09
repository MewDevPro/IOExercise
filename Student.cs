namespace IOExercise
{
    internal class Student
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public Student()
        {
        }

        public Student(string code, string name, double score)
        {
            Code = code;
            Name = name;
            Score = score;
        }
    }
}
