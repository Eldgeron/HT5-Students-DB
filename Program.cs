Admins adminDB = new Admins();
adminDB.Add("admin", "admin");
adminDB.Add("admin2", "admin2");

StudentsDB students = new StudentsDB();
students.AddStudent("John", 20, 'N',90.5, 35, 98.3, 100);
students.AddStudent("Jane", 21, 'A', 85.5, 34, 98.3, 100);

bool transitionKey = true;
// Main menu
do
{
    Console.WriteLine("Select an option: \n 1 --> Registration; \n 2 --> Login; \n 3 --> List of users \n e --> exit");
    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            transitionKey = false;
            adminDB.Registration();
            break;
        case "2":
            transitionKey = false;
            if (adminDB.Login())
            {
                // Admin menu
                do
                {
                    Console.WriteLine("Select an option: \n 1 --> Add student profile; \n 2 --> Remove student profile; \n 3 --> Edit student profile; \n 4 --> List of students; \n 5 --> Average mark of students; \n e --> exit");
                    string ProfileOption = Console.ReadLine().ToLower();
                    switch (ProfileOption)
                    {
                        case "1":
                            transitionKey = false;
                            students.AddNewStudent();
                            break;
                        case "2":
                            transitionKey = false;
                            students.RemoveStudent();
                            break;
                        case "3":
                            transitionKey = false;
                            students.EditStudent();
                            break;
                        case "4":
                            transitionKey = false;
                            students.ListStudents();
                            break;
                        case "5":
                            transitionKey = false;
                            students.PrintAverageMark();
                            break;
                        case "e":
                            transitionKey = true;
                            break;
                        default:
                            transitionKey = false;
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
                while (!transitionKey);
            }
            break;
        case "3":
            transitionKey = false;
            adminDB.ListAdmins();
            break;
        case "e":
            transitionKey = true;
            Console.WriteLine("Exiting...");
            break;
        default:
            transitionKey = false;
            Console.WriteLine("Invalid option");
            break;
    }
}
while (!transitionKey);