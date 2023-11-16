namespace StudentsReportCard_OOPAndFilling_2
{
    public class Student
    {
        public Student(string FirstName, string LastName, List<Lesson> Lessons)
        { 
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Lessons = Lessons;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Lesson> Lessons{ get; set; }


        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public double AverageWritten()
        {
            int TotalMarks = (Lessons[8].Mark * Lessons[8].Unit) +
                             (Lessons[5].Mark * Lessons[5].Unit) +
                             (Lessons[7].Mark * Lessons[7].Unit) +
                             (Lessons[6].Mark * Lessons[6].Unit) +
                             (Lessons[9].Mark * Lessons[9].Unit);

            int TotalUnits = Lessons[8].Unit + Lessons[5].Unit + Lessons[7].Unit + Lessons[6].Unit + Lessons[9].Unit;

            return Math.Round((double)TotalMarks / (double)TotalUnits, 2);
        }

        public double AveragePractical()
        {
            int TotalMarks = (Lessons[0].Mark * Lessons[0].Unit) +
                             (Lessons[1].Mark * Lessons[1].Unit) +
                             (Lessons[2].Mark * Lessons[2].Unit);

            int TotalUnits = Lessons[0].Unit + Lessons[1].Unit + Lessons[2].Unit;

            return Math.Round((double)TotalMarks / (double)TotalUnits, 2);
        }

        public double AverageTheorical()
        {
            int TotalMarks = (Lessons[3].Mark * Lessons[3].Unit) +
                             (Lessons[4].Mark * Lessons[4].Unit);

            int TotalUnits = Lessons[3].Unit + Lessons[4].Unit;

            return Math.Round((double)TotalMarks / (double)TotalUnits, 2);
        }

        public double AverageMain()
        {
            int TotalMarks = (Lessons[3].Mark * Lessons[3].Unit) +
                             (Lessons[4].Mark * Lessons[4].Unit) +
                             (Lessons[0].Mark * Lessons[0].Unit) +
                             (Lessons[1].Mark * Lessons[1].Unit) +
                             (Lessons[2].Mark * Lessons[2].Unit);

            int TotalUnits = Lessons[3].Unit + Lessons[4].Unit + Lessons[0].Unit + Lessons[1].Unit + Lessons[2].Unit;

            return Math.Round((double)TotalMarks / (double)TotalUnits, 2);
        }

        public double AverageGeneral()
        {
            int TotalMarks = 0;
            int TotalUnits = 0;
            foreach (Lesson Lesson in Lessons)
            {
                TotalMarks += Lesson.Mark * Lesson.Unit;
                TotalUnits += Lesson.Unit;
            }

            return Math.Round((double)TotalMarks / (double)TotalUnits, 2);
        }

        public char Rank(double Average)
        {
            char Grade = ' ';


            switch (Average)
            {
                case double average when average is >= 17.00 and <= 20.00:
                    Grade = 'A';
                    break;
                case double average when average is >= 15.00 and < 17.00:
                    Grade = 'B';
                    break;
                case double average when average is >= 13.00 and <= 15.00:
                    Grade = 'C';
                    break;
                case double average when average is >= 10.00 and <= 13.00:
                    Grade = 'D';
                    break;
                case double average when average is >= 7.00 and <= 10.00:
                    Grade = 'E';
                    break;
                case double average when average is >= 3.00 and <= 7.00:
                    Grade = 'F';
                    break;
                case double average when average is >= 0.00 and <= 3.00:
                    Grade = 'G';
                    break;
            }

            return Grade;
        }

        public void PrimeNumbers()
        {
            Console.WriteLine($"********{FullName()}********");
            bool Prime;
            foreach (Lesson Lesson in Lessons)
            {
                Prime = true;
                if (Lesson.Mark <= 1)
                    Prime = false;
                if (Lesson.Mark == 2)
                    Prime = true;
                for (int j = 2; j < Lesson.Mark; j++)
                {
                    if (Lesson.Mark % j == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                    Console.WriteLine($"{Lesson.Name} : {Lesson.Mark}");
            }
        }
    }
}
