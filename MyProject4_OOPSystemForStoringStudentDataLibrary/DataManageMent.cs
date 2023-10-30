using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProject4_OOPSystemForStoringStudentDataLibrary
{
    public class DataManageMent
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject> Subjects { get; set; }
        public DataManageMent()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Subjects = new List<Subject>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
        public void ShowStudentsInClass(string classAndSection)
        {
            Console.WriteLine($"Students in Class {classAndSection}");
            foreach (var student in Students)
            {
                if (student.ClassSection == classAndSection)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }
        }
        public void ShowSubjectsTaughtByTeacher(string teacherName)
        {
            Console.WriteLine($"Subjects taught by {teacherName}: ");
            foreach (var subject in Subjects)
            {
                if (subject.Teacher.Name == teacherName)
                {
                    Console.WriteLine($"- {subject.Name} (Code: {subject.SubjectCode}");
                }
            }
        }

    }
}
