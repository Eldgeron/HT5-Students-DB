using System;
using System.Text.RegularExpressions;

// Create a class with the following properties:
public class StudentProfile
{
	public string Name { get; set; }
	public int Age { get; set; }
    public char Class { get; set; }
    public double MthMark { get; set; }
    public double EnglishMark { get; set; }
    public double BiologyMark { get; set; }
    public double GeographyMark { get; set; }
    public double AverageMark()
    {
        return (MthMark + EnglishMark + BiologyMark + GeographyMark) / 4;
    }
    // Create a constructor that takes in a name
    public StudentProfile(string name)
    {
        Name = name;
		Age= 0;
        Class = 'N';
        MthMark = 0;
        EnglishMark = 0;
        BiologyMark = 0;
        GeographyMark = 0;
    }
    // Create a constructor that takes in a name, age
    public StudentProfile(string name, int age)
    {
        Name = name;
        Age = age;
        Class = 'N';
        MthMark = 0;
        EnglishMark = 0;
        BiologyMark = 0;
        GeographyMark = 0;
    }
    // Create a constructor that takes in a name, age, and class
    public StudentProfile(string name, int age, char _class)
    {
        Name = name;
        Age = age;
        Class = _class;
        MthMark = 0;
        EnglishMark = 0;
        BiologyMark = 0;
        GeographyMark = 0;
    }
    // Create a constructor that takes in a name, age, class, math mark
    public StudentProfile(string name, int age, char _class, double mthMark)
    {
        Name = name;
        Age = age;
        Class = _class;
        MthMark = mthMark;
        EnglishMark = 0;
        BiologyMark = 0;
        GeographyMark = 0;
    }
    // Create a constructor that takes in a name, age, class, math mark, and english mark
    public StudentProfile(string name, int age, char _class, double mthMark, double englishMark)
    {
        Name = name;
        Age = age;
        Class = _class;
        MthMark = mthMark;
        EnglishMark = englishMark;
        BiologyMark = 0;
        GeographyMark = 0;
    }
    // Create a constructor that takes in a name, age, class, math mark, english mark, biology mark
    public StudentProfile(string name, int age, char _class, double mthMark, double englishMark, double biologyMark)
    {
        Name = name;
        Age = age;
        Class = _class;
        MthMark = mthMark;
        EnglishMark = englishMark;
        BiologyMark = biologyMark;
        GeographyMark = 0;
    }
    // Create a constructor that takes in a name, age, class, math mark, english mark, biology mark, and geography mark
    public StudentProfile(string name, int age, char _class, double mthMark, double englishMark, double biologyMark, double geographyMark)
    {
        Name = name;
        Age = age;
        Class = _class;
        MthMark = mthMark;
        EnglishMark = englishMark;
        BiologyMark = biologyMark;
        GeographyMark = geographyMark;
    }

}


// Create a class called StudentsDB with the following properties:
public class StudentsDB
{
    // Create a dictionary called students that has a string key and a StudentProfile value
    private Dictionary<string, StudentProfile> students = new Dictionary<string, StudentProfile>();

    // Create a method that takes in a name, age, and math mark... and adds a new student to the dictionary
    public void AddStudent(string name, int age, char classLetter, double mthMark, double englishMark, double biologyMark, double geographyMark)
    {
        students.Add(name, new StudentProfile(name, age, classLetter, mthMark, englishMark, biologyMark, geographyMark));
    }
    // Create a method that takes in a name, age, and math mark... and adds a new student to the dictionary
    public void AddNewStudent()
    {
        bool key = true;
        Console.WriteLine("Enter student name: ");
        string name = Console.ReadLine();
        do
        {
            key = false;
            Console.WriteLine("Enter student age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age > 100)
            {
                Console.WriteLine("Age must be from 0 to 100");
                key = false;
            }
            else
            {
                do
                {
                    key = false;
                    Console.WriteLine("Enter student class: ");
                    char classLetter = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (classLetter != 'A' && classLetter != 'B' && classLetter != 'N')
                    {
                        Console.WriteLine("Class must be from A, B or N for not classes");
                        key = false;
                    }
                    else
                    {
                        do
                        {
                            key = false;
                            Console.WriteLine("Enter student math mark: ");
                            double mthMark = Convert.ToDouble(Console.ReadLine());
                            if (mthMark < 0 || mthMark > 100)
                            {
                                Console.WriteLine("Math mark must be from 0 to 100");
                                key = false;
                            }
                            else
                            {
                                do
                                {
                                    key = false;
                                    Console.WriteLine("Enter student English mark: ");
                                    double engMark = Convert.ToDouble(Console.ReadLine());
                                    if (engMark < 0 || engMark > 100)
                                    {
                                        Console.WriteLine("English mark must be from 0 to 100");
                                        key = false;
                                    }
                                    else
                                    {
                                        do
                                        {
                                            key = false;
                                            Console.WriteLine("Enter student Biology mark: ");
                                            double bioMark = Convert.ToDouble(Console.ReadLine());
                                            if (bioMark < 0 || bioMark > 100)
                                            {
                                                Console.WriteLine("Biology mark must be from 0 to 100");
                                                key = false;
                                            }
                                            else
                                            {
                                                do
                                                {
                                                    key = false;
                                                    Console.WriteLine("Enter student Geography mark: ");
                                                    double geoMark = Convert.ToDouble(Console.ReadLine());
                                                    if (geoMark < 0 || geoMark > 100)
                                                    {
                                                        Console.WriteLine("Geography mark must be from 0 to 100");
                                                        key = false;
                                                    }
                                                    else
                                                    {
                                                        AddStudent(name, age, classLetter, mthMark, engMark, bioMark, geoMark);
                                                        Console.WriteLine("Student is added");
                                                        key = true;
                                                    }
                                                }
                                                while (!key);
                                            }
                                        } while (!key);
                                    }
                                }
                                while (!key);
                            }
                        }
                        while (!key);
                    }
                } while (!key);
            }
        }
        while (!key);
    }

    // Create a method that takes in a name and removes the student from the dictionary
    public void RemoveStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("There are no students in the database");
            return;
        }
        else
        {
            Console.WriteLine("Enter student name to remove: ");
            string name = Console.ReadLine();
            if (students.ContainsKey(name))
            {
                students.Remove(name);
                Console.WriteLine("Student is removed");
            }
            else
            {
                Console.WriteLine("Student is not found");
            }
        }
        
    }

    // Create a method that takes in a name and edits the student in the dictionary
    public void EditStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("There are no students in the database");
            return;
        }
        else
        {
            Console.WriteLine("Enter student name to edit: ");
            string name = Console.ReadLine();
            if (students.ContainsKey(name))
            {
                bool key = true;
                // Create a loop that asks the user what data they want to edit
                do
                {
                    Console.WriteLine("What data do you want to edit? \n C --> Class; \n M --> Math mark; \n E --> English mark; \n B -- biology mark; \n G - geography mark; \n X --> exit");
                    string option = Console.ReadLine().ToUpper();
                    switch (option)
                    {
                        case "C":
                            Console.WriteLine("Enter new class: ");
                            char classLetter = Convert.ToChar(Console.ReadLine().ToUpper());
                            students[name].Class = classLetter;
                            key = false;
                            break;
                        case "M":
                            Console.WriteLine("Enter new math mark: ");
                            double mthMark = Convert.ToDouble(Console.ReadLine());
                            students[name].MthMark = mthMark;
                            key = false;
                            break;
                        case "E":
                            Console.WriteLine("Enter new English mark: ");
                            double engMark = Convert.ToDouble(Console.ReadLine());
                            students[name].EnglishMark = engMark;
                            key = false;
                            break;
                        case "B":
                            Console.WriteLine("Enter new Biology mark: ");
                            double bioMark = Convert.ToDouble(Console.ReadLine());
                            students[name].BiologyMark = bioMark;
                            key = false;
                            break;
                        case "G":
                            Console.WriteLine("Enter new Geography mark: ");
                            double geoMark = Convert.ToDouble(Console.ReadLine());
                            students[name].GeographyMark = geoMark;
                            key = false;
                            break;
                        case "X":
                            key = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            key = false;
                            break;
                    }
                }
                while (!key);
                Console.WriteLine("Student is edited");
            }
            else
            {
                Console.WriteLine("Student is not found");
            }
        }
    }

    // Create a method that calculates the total average mark of all students in the dictionary
    public double CalculateTotalAverageMark()
    {
        if (students.Count == 0)
        {
            return 0; // Повернемо 0, якщо словник порожній
        }

        double totalSum = students.Values.Sum(student => student.AverageMark());
        return totalSum / students.Count;
    }

    // Create a method that prints out the average mark of each student in the dictionary
    public void PrintAverageMark()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Value.Name}, Average Mark: {student.Value.AverageMark()}");
        }
        Console.WriteLine($"Total average mark is: {CalculateTotalAverageMark()}");
    }

    // Create a method called ListStudents that prints out the name, age, and math mark of each student in the dictionary
    public void ListStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Value.Name}, Age: {student.Value.Age}, Class: {student.Value.Class}, Math Mark: {student.Value.MthMark}, English mark: {student.Value.EnglishMark}, Biology mark: {student.Value.BiologyMark}, Geography mark {student.Value.GeographyMark}");
        }
    }   

    
}

// Create a class with the following properties:
public class Admins
{
    // Create a dictionary called adminDB that has a string key and a string value
    private Dictionary<string, string> adminDB = new Dictionary<string, string>();

    //Add new admin to the dictionary
    public void Registration ()
    {
        bool key = true;
        Console.WriteLine("Registration form. " +
                    "\nUsername Requirements: " +
                    "\n-- can be simple " +
                    "\n-- must containe only latin letters" +
                    "\n-- must be unique " +
                    "\n-- case-sensitive " +
                    "\n-- must be from 8 to 13 characters " +
                    "\n-- can't be only from white spaces" +
                    "\nPassword requirements" +
                    "\n-- must be from 8 to 13 characters " +
                    "\n-- must containe only latin letters, digits and symbols" +
                    "\n-- case-sensitive " +
                    "\n-- can't be only from white spacec");
        do
        {
            key = false;
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            if(ValidUsername(adminDB, username))
            {
                do
                {
                    key = false;
                    Console.WriteLine("Enter password: ");
                    string password = Console.ReadLine();
                    if (ValidPassword(password))
                    {
                        Add(username, password);
                        Console.WriteLine("Registration is successful");
                        key = true;
                    }
                }
                while (!key);
            }
        }
        while (!key);
    }

    //Check if the username and password are correct
    public bool Login()
    {
        bool key = true;
        bool recall = false;
        do
        {
            key = false;
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            if (adminDB.ContainsKey(username))
            {
                do
                {
                    key = false;
                    Console.WriteLine("Enter password: ");
                    string password = Console.ReadLine();
                    if (adminDB[username] == password)
                    {
                        Console.WriteLine("Login is successful");
                        key = true;
                        recall = true;
                    }
                    else
                    {
                        Console.WriteLine("Password is incorrect. Try again");
                        key = false;
                    }
                }
                while (!key);
            }
            else
            {
                Console.WriteLine("Username is incorrect. Try again");
                key = false;
            }
        }
        while (!key);
        return recall;

    }

    //Add the username and password to the dictionary
    public void Add(string username, string password)
    {
        adminDB.Add(username, password);
    }

    // Check if the username is valid and uniqe
    public static bool ValidUsername(Dictionary<string, string> dictionary, string input)
    {
        bool compairAnswer = true;
        if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Username can't be empty or be only from spaces");
            compairAnswer = false;
        }
        else if (input.Length < 8 || input.Length >= 13)
        {
            Console.WriteLine("Username must be from 8 to 13 characters");
            compairAnswer = false;
        }
        else if (dictionary.ContainsKey(input))
        {
            Console.WriteLine("This usernsme is used. Try another username");
            compairAnswer = false;
        }
        else if (!input.All(char.IsLetter) || isContaineRegEx(input))
        {
            Console.WriteLine("Username must containe only latin letter. No digits, no symbols");
            compairAnswer = false;
        }
        else { compairAnswer = true; }

        if (compairAnswer) { return true; }
        return false;
    }

    //check if the username containe only latin letter
    public static bool isContaineRegEx(string input)
    {
        string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9] 
                        {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
        Regex re = new Regex(strRegex);
        if (re.IsMatch(input))
        {
            return true;
        }
        else { return false; }

    }
    //Check if the password is valid
    public static bool ValidPassword(string input)
    {
        bool compairAnswer = true;
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Username can't be empty");
            compairAnswer = false;
        }
        else if (!input.All(char.IsLetterOrDigit))
        {
            Console.WriteLine("Password must containe only latin letter, digits and symbols");
            compairAnswer = false;
        }
        else if (input.Length >= 13 || input.Length < 8)
        {
            Console.WriteLine("Password must be from 8 to 13 characters");
            compairAnswer = false;
        }
        else { compairAnswer = true; }

        if (compairAnswer) { return true; }
        return false;

    }

    // Print out the list of admins in the dictionary
    public void ListAdmins()
    {
        foreach (var admin in adminDB)
        {
            Console.WriteLine($"Username: {admin.Key}, Password: {admin.Value}");
        }
    }
}
