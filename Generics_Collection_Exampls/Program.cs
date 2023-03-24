using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics_Collection_Exampls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Generics generics = new Generics();
            generics.PerformListOperations();
            List<Student> students = generics.PerformListOperations();
            foreach (var Student in students)
            {
                Console.WriteLine(Student.StudentId + Student.StudentName);
            }
            // generics.PerformDictionaryOperations();

            //NonGenerics nonGenerics = new NonGenerics();
            //nonGenerics.PerformArrayListOperations();
            //nonGenerics.PerformHashTableOperations();
            Console.ReadLine();
        }
    }
}

