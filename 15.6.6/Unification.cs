using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
     public class Unification
     {
        /// <summary>
        /// Метод для обьеденения списков через selectmany
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(s => s.Students).ToArray();
        }
    }
}
