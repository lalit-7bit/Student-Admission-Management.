using System;

class Student
{
    // Private fields - Access Modifier
    private int studentId;
    private string studentName;
    private int age;
    private string course;

    // Constructor
    public Student(int id, string name, int studentAge, string studentCourse)
    {
        studentId = id;
        studentName = name;
        age = studentAge;
        course = studentCourse;
    }

    // Public method to display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine("\n--- Student Admission Details ---");
        Console.WriteLine("Student ID   : " + studentId);
        Console.WriteLine("Student Name : " + studentName);
        Console.WriteLine("Age          : " + age);
        Console.WriteLine("Course       : " + course);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of Student class
        Student student1 = new Student(
            101,
            "Rahul",
            20,
            "B.Tech Computer Science"
        );

        Student student2 = new Student(
            102,
            "Priya",
            19,
            "B.Sc Information Technology"
        );

        // Display student admission details
        student1.DisplayStudentDetails();
        student2.DisplayStudentDetails();

        Console.ReadLine();
    }
}