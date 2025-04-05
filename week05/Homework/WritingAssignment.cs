using System;

public class WritingAssignment : Assignment
{
    private string _assignmentTitle;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _assignmentTitle = title;
    }

    // Method that will give the writing information, and b who it was made
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_assignmentTitle} by {studentName}";
    }
}