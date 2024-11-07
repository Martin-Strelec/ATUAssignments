using System;
using System.Numerics;

public class Subject
{
    private string _name;
    private int _points;
    private int _grade;
    private char _level;
    private int _mark;

    public string Name
    {
        get { return _name; }
    }
    public int Points
    {
        get { return _points; }
    }
    public int Grade
    {
        get { return _grade; }
    }
    public int Mark
    {
        get { return _mark; }
    }
    public char Level
    {
        get { return _level; }
    }

    public Subject(string name, int mark, char level)
    {
        _name = name;
        _mark = mark;
        _level = level;
        _points = CalculatePoints(level, mark);
    }

    public Subject(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public int CalculatePoints(char level, int mark)
    {
        int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };
        int[] lowerPoints = { 56, 46, 37, 28, 20, 12, 0, 0 };
        int decrement = 10;
        int markMin = 30;
        int markMax = 100;
        int i = markMax;
        int count = 0;
        int points = 0;

        while (i >= markMin)
        {
            if (i == markMax)
            {
                if (mark <= markMin)
                {
                    points = 0;
                    break;
                }
            }

            i -= decrement;

            if (mark >= i)
            {
                points = level == 'H' ? higherPoints[count] : lowerPoints[count];
                _grade = count+1;
                break;
            }
            count++;
        }
       
        return points;
    }
}


