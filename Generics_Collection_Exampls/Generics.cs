using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics_Collection_Exampls
{
    public class Generics
    {
        public List<Student> PerformListOperations()
        {
            //GetUserDetail:
            Console.WriteLine("Enter Student name to be added");
            string studentNameFromUser = Console.ReadLine();

            Console.WriteLine("Enter Student id to be added");
            int studentidFromUser = Convert.ToInt32(Console.ReadLine());

            //Create
            List<Student> students = new List<Student>();
            students.Add(new Student() { StudentId = studentidFromUser, StudentName = studentNameFromUser });

            //Console.WriteLine("Is there another student to be added - Y/N");
            //string userChoice = Console.ReadLine();

            //if (userChoice == "Y")
            //    goto GetUserDetail;

            //else 
            students.Insert(1, new Student() { StudentId = 2, StudentName = "def" });
            students.Insert(1, new Student() { StudentId = 3, StudentName = "CDE" });

            //Read
            //foreach (var Student in students)
            //{
            //    Console.WriteLine(Student.StudentId + "-" + Student.StudentName);
            //}

            //Update
            //students[0].StudentName = "vvv";
            //Console.WriteLine(students[0].StudentName);

            //foreach (var Student in students)
            //{
            //    Console.WriteLine(Student.StudentId + "-" + Student.StudentName);
            //}

            //Delete 
            Student studentToBeRemoved = students.Where(student => student.StudentName == "vvv").FirstOrDefault();
            //students.RemoveAt(0);
            students.Remove(studentToBeRemoved);

            //foreach (var Student in students)
            //{
            //    Console.WriteLine(Student.StudentId + "-" + Student.StudentName);
            //}

            //Console.WriteLine("Id of Student removed = " + studentToBeRemoved.StudentId);
            return students;
        }
        public void PerformDictionaryOperations()
        {
            //Create
            Dictionary<string, string> languageDictionary = new Dictionary<string, string>();
            languageDictionary.Add("c", "C#");
            languageDictionary.Add("v", "Vb");
            languageDictionary.Add("s", "SQL");
            
            //Read
            foreach (KeyValuePair<string, string> item in languageDictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //Update
            languageDictionary["c"] = "HTML";

            //Delete
            languageDictionary.Remove("v");

            Console.WriteLine("After Modification");
            foreach (KeyValuePair<string, string> item in languageDictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
 