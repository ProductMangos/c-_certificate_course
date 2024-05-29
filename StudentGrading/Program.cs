using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

List<int> sophiaGrades = new([90, 86, 87, 98, 100]);
List<int> andrewGrades = new([92, 89, 81, 96, 90]);
List<int> emmaGrades = new([90, 85, 87, 98, 68]);
List<int> loganGrades = new([90, 95, 87, 88, 96]);

string DetermineLetterGrade(decimal grade)
{
    if (grade >= 97)
    {
        return "A+";
    } 
    else if (grade >= 93)
    {
        return "A";
    }
    else if (grade >= 90)
    {
        return "A-";
    } 
    else if (grade >= 87)
    {
        return "B+";
    }
    else if (grade >= 83)
    {
        return "B";
    }
    else if (grade >= 80)
    {
        return "B-";
    }
    else if (grade >= 77)
    {
        return "C+";
    }
    else if (grade >= 73)
    {
        return "C";
    }
    else if (grade >= 70)
    {
        return "C-";
    }
    else if (grade >= 67)
    {
        return "D+";
    }
    else if (grade >= 63)
    {
        return "D";
    }
    else if (grade >= 60)
    {
        return "D-";
    }
    else 
    {
        return "F";
    }
}


void StudentInformation(string studentName, List<int> grades)
{
    int totalSum = 0;
    decimal score;

    foreach (var grade in grades)
    {
        totalSum += grade;
    }

    score = (decimal)totalSum / currentAssignments;


    Console.WriteLine($"{studentName}:\t\t" + score + $"\t{DetermineLetterGrade(score)}");
}

Console.WriteLine("Student\t\tGrade\n");
StudentInformation("Sophia", sophiaGrades);
StudentInformation("Andrew", andrewGrades);
StudentInformation("Emma", emmaGrades);
StudentInformation("Logan", loganGrades);
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
