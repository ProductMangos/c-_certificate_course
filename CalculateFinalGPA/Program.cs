string studentName = "Sophia Johnson";

List<string> courses = new (["English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"]);
List<int> credits = new ([3, 3, 4, 4, 3]);
List<int> grades = new ([4, 3, 3, 3, 4]);

void DisplayStudentGPAInformation()
{
    decimal totalGPA = 0m; 
    decimal totalCreditHours = 0m;
    for (int i = 0; i < credits.Count; i++)
    {
        Console.WriteLine($"{courses[i],-30}{grades[i],-15}{credits[i],-15}");
        totalGPA += credits[i] * grades[i];
        totalCreditHours += credits[i];
    }
    
    decimal totalCredit = Math.Round(totalGPA / totalCreditHours, 2);
    Console.WriteLine("\n");
    Console.WriteLine($"{"Final GPA:",-30}{totalCredit,-15}");
}


Console.WriteLine("\n");
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine($"{"Course",-30}{"Grade",-15}{"Credit Hours",-15}");
DisplayStudentGPAInformation();
Console.WriteLine("\n");