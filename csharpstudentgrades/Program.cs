using System;

internal class Program
{
    private const int NUMBER_OF_SUBJECT_SCORES = 5;
    private const int NUMBER_OF_EXTRACREDIT_SCORES = 3;

    private static void Main(string[] args)
    {
        var studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

        var studentScores = new int[8, NUMBER_OF_SUBJECT_SCORES + NUMBER_OF_EXTRACREDIT_SCORES]
        {
            { 90, 86, 87, 98, 100, 94, 90, 0 },
            { 92, 89, 81, 96, 90, 89, 0, 0 },
            { 90, 85, 87, 98, 68, 89, 89, 89 },
            { 90, 95, 87, 88, 96, 96, 0, 0 },
            { 92, 91, 90, 91, 92, 92, 92, 0 },
            { 84, 86, 88, 90, 92, 94, 96, 98},
            { 80, 90, 100, 80, 90, 100, 80, 90 },
            { 91, 91, 91, 91, 91, 91, 91, 0 }
        };

        Console.WriteLine($"Student{GetNumberOfTabs("Student")}Average{GetNumberOfTabs("Average")}Grade\n");

        for (int i = 0; i < studentNames.Length; i++)
        {
            //calculate average of scores
            int sum = GetSumOfSubjectScores(studentScores, i);

            double extraCreditScore = GetExtraCreditScore(studentScores, i);

            double average = (sum + extraCreditScore) / 5;

            string letterGrade = GetLetterGrade(average);

            Console.WriteLine($"{studentNames[i]}{GetNumberOfTabs(studentNames[i])}{average}{GetNumberOfTabs($"{average}")}{letterGrade}");
        }

        static string GetNumberOfTabs(string v, int maxStringLength = 12)
        {
            int maxTabs = (int)Math.Ceiling((double)maxStringLength / 4);

            return new('\t', maxTabs - v.Length / 4);
        }

        static string GetLetterGrade(double average)
        {
            string letterGrade;
            if (average >= 97)
                letterGrade = "A+";

            else if (average >= 93)
                letterGrade = "A";

            else if (average >= 90)
                letterGrade = "A-";

            else if (average >= 87)
                letterGrade = "B+";

            else if (average >= 83)
                letterGrade = "B";

            else if (average >= 80)
                letterGrade = "B-";

            else if (average >= 77)
                letterGrade = "C+";

            else if (average >= 73)
                letterGrade = "C";

            else if (average >= 70)
                letterGrade = "C-";

            else if (average >= 67)
                letterGrade = "D+";

            else if (average >= 63)
                letterGrade = "D";

            else if (average >= 60)
                letterGrade = "D-";

            else
                letterGrade = "F";
            return letterGrade;
        }
    }

    private static int GetSumOfSubjectScores(int[,] studentScores, int i)
    {
        int sum = 0;
        for (int j = 0; j < NUMBER_OF_SUBJECT_SCORES; j++)
        {
            sum += studentScores[i, j];
        }

        return sum;
    }

    private static double GetExtraCreditScore(int[,] studentScores, int i)
    {
        double extraCreditScore = 0;
        for (int j = NUMBER_OF_SUBJECT_SCORES; j < NUMBER_OF_SUBJECT_SCORES + NUMBER_OF_EXTRACREDIT_SCORES; j++)
        {
            extraCreditScore += studentScores[i, j] / 10;
        }

        return extraCreditScore;
    }
}