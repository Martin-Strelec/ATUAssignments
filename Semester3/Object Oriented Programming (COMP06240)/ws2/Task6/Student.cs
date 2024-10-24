using System;

public class Student
{
    private string _name;
    private string _studentNumber;
    private List<Subject> _subjects;
    private int _totalPoints;

    public string Name
    {
        get { return _name; }
    }
    public string StudentNumber
    {
        get { return _studentNumber; }
    }
    public List<Subject> Subjects
    {
        get { return _subjects; }
    }
    public int TotalPoints
    {
        get { return _totalPoints; }
    }

    public Student(string name, string studentNumber, List<Subject> subjects)
    {
        _name = name;
        _studentNumber = studentNumber;
        _subjects = subjects;
        _totalPoints = CalculateTotalPoints(subjects);
    }

    public Student(string name, string studentNumber)
    {
        _name = name;
        _studentNumber = studentNumber;
    }

    public int CalculateTotalPoints(List<Subject> subjects)
    {
        int totalPoints = 0;

        for (int i = 0; i < subjects.Count; i++)
        {
            totalPoints += subjects[i].Points;
        }

        return totalPoints;
    }

    public void DisplayAllSubjectsDetails()
    {
        const string DISPLAY_TAB = "{0,-15}{1,-15}{2,-15}{3,-15}";

        Console.WriteLine("\n*******************************************************");
        Console.WriteLine($"Student name: {Name}");
        Console.WriteLine($"Student number: {StudentNumber}");
        Console.WriteLine("======================================================");
        Console.WriteLine(DISPLAY_TAB, "Name", "Mark", "Grade", "Points");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("");
        for (int i = 0; i < Subjects.Count; i++)
        {
            Console.WriteLine(DISPLAY_TAB, $"{Subjects[i].Name}", $"{Subjects[i].Mark}", $"{Subjects[i].Level}{Subjects[i].Grade}", $"{Subjects[i].Points}");
        }
        Console.WriteLine("======================================================");
        Console.WriteLine($"\nTotal points: {CalculateTotalPoints(Subjects)}");
        Console.WriteLine("*******************************************************");
    }

    public void PrintToFile(string pathToFile)
    {
        const string DISPLAY_TAB = "{0,-15}{1,-15}{2,-15}{3,-15}";

        File.AppendAllText(pathToFile, Environment.NewLine + "\n******************************************************");
        File.AppendAllText(pathToFile, Environment.NewLine + $"Student name: {Name}");
        File.AppendAllText(pathToFile, Environment.NewLine + $"Student number: {StudentNumber}");
        File.AppendAllText(pathToFile, Environment.NewLine + "======================================================");
        for (int i = 0; i < Subjects.Count; i++)
        {
            File.AppendAllText(pathToFile, Environment.NewLine + "------------------------------------------------------");
            File.AppendAllText(pathToFile, Environment.NewLine + $"{Subjects[i].Name}");
            File.AppendAllText(pathToFile, Environment.NewLine + $"Mark: {Subjects[i].Mark}\tGrade: {Subjects[i].Level}{ Subjects[i].Grade}\tPoints: { Subjects[i].Points}");
            File.AppendAllText(pathToFile, Environment.NewLine + "------------------------------------------------------");
        }
        File.AppendAllText(pathToFile, Environment.NewLine + "======================================================");
        File.AppendAllText(pathToFile, Environment.NewLine + $"\nTotal Points: {CalculateTotalPoints(Subjects)}");
        File.AppendAllText(pathToFile, Environment.NewLine + "******************************************************\n");
    }
}
