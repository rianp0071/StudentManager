class Student {
    public static List<String> subjects = new List<String>();
    public static List<int> grades = new List<int>();
    public required string studentName { get; set; }
    public int ID { get; set; }

    public void assignGrade(String subject, int grade) {
        subjects.Add(subject);
        grades.Add(grade);
    }

    public double calcAvgGrade() {
        return grades.Average();
    }

    public void displayStudentRecord() {
        Console.WriteLine($"ID: {ID}, Name: {studentName}, Average Grade: {calcAvgGrade()}");
        int subjIndex = 0;
        foreach (int grade in grades) {
            Console.WriteLine($"Subject: {subjects[subjIndex]}, Grade: {grade}");
            subjIndex++;
        }
    }


}

class Program { 
    static List<Student> students = new List<Student>();

    static void Main() {
        while (true)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Grade");
            Console.WriteLine("3. Display Student Records");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            try 
            {
                String choice = Console.ReadLine();
                switch (choice)
                {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddGrade();
                    break;
                case "3":
                    DisplayRecords();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    static void AddStudent() {
        try {
            Console.WriteLine("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();
            students.Add(new Student { ID = id, studentName = name });
            Console.WriteLine("Student added successfully!\n");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    static void AddGrade() {
        try {
            Console.WriteLine("Enter Student ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject : ");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter Grade: ");
            int grade = int.Parse(Console.ReadLine());
            students[id].assignGrade(subject, grade);

            Console.WriteLine("Grade added successfully!\n");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    static void DisplayRecords() {
        foreach (Student student in students)
        {
            student.displayStudentRecord();
        }
    }

        
}