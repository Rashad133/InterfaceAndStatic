using Static_Interface_16._10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Interface_16._10.Models
{
    internal class Student: ICodeAcademy
    {
        public static int Count = 0;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }
       

        public Student(string name, string surname)
        {
            Id = Count++;
            Name = name;
            Surname = surname;
            GenerateEmail();
            
        }

        public static bool CheckName(string name)
        {
            if(name.Length >=3 && name.Length <= 25)
            
                return false;

            else if (!IsLetter(name))
                return false;
            return true;
        }

        public static bool IsLetter(string name)
        {
            foreach (char letter in name)
            {
                if (!char.IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public void GenerateEmail()
        {
            CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
        }
    }
}
