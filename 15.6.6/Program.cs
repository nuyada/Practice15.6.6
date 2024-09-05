﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            //вызов метода для обьеденения 
            var allStudents = Unification.GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

    }
}
