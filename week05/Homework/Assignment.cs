using System;

public class Assignment
{
    private string _studentName;
    private string _subjectTopic;

    public Assignment(string studentName, string subjectTopic)
    {
        _studentName = studentName;
        _subjectTopic = subjectTopic;
    }

    // Method that will give the student name
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method that will give the subject topic
    public string GetTopic()
    {
        return _subjectTopic;
    }

    // Method that will give the summary (student name + subject topic)
    public string GetSummary()
    {
        return _studentName + " - " + _subjectTopic;
    }
}