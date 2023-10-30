using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject4_OOPSystemForStoringStudentDataLibrary;

namespace MyProject4_OOPSystemForStoringStudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataManageMent dataManagement = new DataManageMent();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Add Subject");
                Console.WriteLine("4. Display Students in a Class");
                Console.WriteLine("5. Display Subjects Taught by a Teacher");
                Console.WriteLine("6. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter Student Name:");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("Enter Class and Section:");
                        string classAndSection = Console.ReadLine();
                        dataManagement.AddStudent(new Student { Name = studentName, ClassSection = classAndSection });
                        break;

                    case "2":
                        Console.WriteLine("Enter Teacher Name:");
                        string teacherName = Console.ReadLine();
                        Console.WriteLine("Enter Class and Section:");
                        string teacherClassAndSection = Console.ReadLine();
                        dataManagement.AddTeacher(new Teacher { Name = teacherName, ClassSection = teacherClassAndSection });
                        break;

                    case "3":
                        Console.WriteLine("Enter Subject Name:");
                        string subjectName = Console.ReadLine();
                        Console.WriteLine("Enter Subject Code:");
                        string subjectCode = Console.ReadLine();
                        Console.WriteLine("Select Teacher by Index to which subject mentioned is to be asigned):");
                        for (int i = 0; i < dataManagement.Teachers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {dataManagement.Teachers[i].Name}");
                        }
                        int teacherIndex = int.Parse(Console.ReadLine()) - 1;
                        dataManagement.AddSubject(new Subject { Name = subjectName, SubjectCode = subjectCode, Teacher = dataManagement.Teachers[teacherIndex] });
                        break;

                    case "4":
                        Console.WriteLine("Enter Class and Section to Display Students:");
                        string classSectionToDisplay = Console.ReadLine();
                        dataManagement.ShowStudentsInClass(classSectionToDisplay);
                        break;

                    case "5":
                        Console.WriteLine("Enter Teacher Name to Display Subjects:");
                        string teacherNameToDisplay = Console.ReadLine();
                        dataManagement.ShowSubjectsTaughtByTeacher(teacherNameToDisplay);
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
            }
        }
    }
    }

