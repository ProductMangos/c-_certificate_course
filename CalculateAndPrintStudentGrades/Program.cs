List<int> sophiaScore = new ([93, 87, 98, 95, 100]);
List<int> nicolasScore = new ([80, 83, 82, 88, 85]);
List<int> zahirahScore = new ([84, 96, 73, 85, 79]);
List<int> jeongScore = new ([90, 92, 98, 100, 97]);

void DisplayStudentInformation(string studentName, List<int> studentScores)
{
    decimal totalScore = 0;
    decimal averageScore = 0;
    decimal totalNumberOfScores = 0;

    foreach (var score in studentScores)
    {
        totalNumberOfScores++;
        totalScore += score;
    }

    averageScore = totalScore / totalNumberOfScores;

    Console.WriteLine($"{studentName}\t\t{averageScore}\t");
}


Console.WriteLine("\nStudent\t\tGrade\n");
DisplayStudentInformation("Sophia", sophiaScore);
DisplayStudentInformation("Nicolas", nicolasScore);
DisplayStudentInformation("Zahirah", zahirahScore);
DisplayStudentInformation("Jeong", jeongScore);
Console.WriteLine("\n");