﻿using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

List<int> sophiaGrades = new([90, 86, 87, 98, 100]);
List<int> andrewGrades = new([92, 89, 81, 96, 90]);
List<int> emmaGrades = new([90, 85, 87, 98, 68]);
List<int> loganGrades = new([90, 95, 87, 88, 96]);

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;


sophiaGrades.ForEach(g => {
    sophiaSum += g;
});

andrewGrades.ForEach(g => {
    andrewSum += g;
});

emmaGrades.ForEach(g => {
    emmaSum += g;
});

loganGrades.ForEach(g => {
    loganSum += g;
});

string DetermineLetterGrade(decimal grade)
{
    Console.WriteLine($"grade {grade}");
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


// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + $"\t{DetermineLetterGrade(sophiaScore)}");
Console.WriteLine("Andrew:\t\t" + andrewScore + $"\t{DetermineLetterGrade(andrewScore)}");
Console.WriteLine("Emma:\t\t" + emmaScore + $"\t{DetermineLetterGrade(emmaScore)}");
Console.WriteLine("Logan:\t\t" + loganScore + $"\t{DetermineLetterGrade(loganScore)}");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
