int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

int examAssignments = 5;

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


void StudentInformation(string studentName, int[] grades)
{
    int totalSum = 0;
    decimal score;
    int currentAssignments = 0;

    foreach (var grade in grades)
    {
        currentAssignments++;
        
        if (currentAssignments <= examAssignments)
        {
            
        }
    }

    Console.WriteLine(currentAssignments);

    score = (decimal)totalSum / currentAssignments;

    Console.WriteLine($"{studentName}:\t\t" + $"{score}\t\t" + $"'n'\t\t" +  $"{DetermineLetterGrade(score)}" + "\t'n'");
}

Console.WriteLine("Student\t\tExamScore\tOverall\t\tGrade\tExtraCredit\n");
StudentInformation("Sophia", sophiaScores);
StudentInformation("Andrew", andrewScores);
StudentInformation("Emma", emmaScores);
StudentInformation("Logan", loganScores);
StudentInformation("Becky", beckyScores);
StudentInformation("Chris", chrisScores);
StudentInformation("Eric", ericScores);
StudentInformation("Gregor", gregorScores);
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
