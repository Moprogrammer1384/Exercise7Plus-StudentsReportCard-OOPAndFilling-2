namespace StudentsReportCard_OOPAndFilling_2
{
    public class Student
    {
        public Student(string FirstName,
                       string LastName,
                       int AdvancedProgramming,
                       int AdvancedProgramming2,
                       int Mathematic,
                       int Quran,
                       int WorkShop,
                       int English,
                       int OOP,
                       int PE,
                       int OS,
                       int Algorithm)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AdvancedProgramming = AdvancedProgramming;
            this.AdvancedProgramming2 = AdvancedProgramming2;
            this.Mathematic = Mathematic;
            this.OOP = OOP;
            this.PE = PE;
            this.OS = OS;
            this.English = English;
            this.Algorithm = Algorithm;
            this.Quran = Quran;
            this.WorkShop = WorkShop;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AdvancedProgramming { get; set; }
        public int AdvancedProgramming2 { get; set; }
        public int Mathematic { get; set; }
        public int Quran { get; set; }
        public int WorkShop { get; set; }
        public int English { get; set; }
        public int OOP { get; set; }
        public int PE { get; set; }
        public int OS { get; set; }
        public int Algorithm { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
            
        public double AverageWritten()
        {
            int TotalMarks = Quran +
                             (Mathematic * 2) +
                             WorkShop +
                             (English * 2) +
                             PE;

            return Math.Round((double)TotalMarks / (double)7, 2);
        }

        public double AveragePractical()
        {
            int TotalMarks = (AdvancedProgramming * 3) +
                             (AdvancedProgramming2 * 3) +
                             (OOP * 3);

            return Math.Round((double)TotalMarks / (double)9, 2);
        }

        public double AverageTheorical()
        {
            int TotalMarks = (OS * 3) +
                             (Algorithm * 3);
                             
                                                          
            return Math.Round((double)TotalMarks / (double)7, 2);
        }

        public double AverageMain()
        {
            int TotalMarks = (OS * 3) +
                             (Algorithm * 3) +
                             (AdvancedProgramming * 3) +
                             (AdvancedProgramming2 * 3) +
                             (OOP * 3);

            return Math.Round((double)TotalMarks / (double)15, 2);
        }

        public double AverageGeneral()
        {
            int TotalMarks = (AdvancedProgramming * 3) +
                             (AdvancedProgramming2 * 3) +
                             Quran +
                             (Mathematic * 2) +
                             WorkShop +
                             (English * 2) +
                             (OOP * 3) +
                             PE +
                             OS * 3 +
                             (Algorithm * 3);

            return Math.Round((double)TotalMarks / (double)22, 2);
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
            int[] Lessons = { AdvancedProgramming, AdvancedProgramming2, Mathematic, Quran, WorkShop, English, OOP, PE, OS, Algorithm };
            string[] LessonsName = { "AdvancedProgramming", "AdvancedProgramming2", "Mathematic", "Quran", "WorkShop", "English", "OOP", "PE", "OS", "Algorithm" };
            bool Prime = true;
            Console.WriteLine($"********{FullName()}********");
            for (int i = 0; i < Lessons.Length; i++)
            {
                if (Lessons[i] <= 1)
                    Prime = false;
                if (Lessons[i] == 2)
                    Prime = true;
                for (int j = 2; j < Lessons[i]; j++)
                {
                    if (Lessons[i] % j == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                    Console.WriteLine($"{LessonsName[i]} : {Lessons[i]}");
            }
        }
    }
}
