﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass4_Ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Naresh";
            person.lastName = "Varshney";
            Console.WriteLine("Full Name is : " + person.fullName);
        }
    }
    class Person
    {
        private string FirstName, LastName;
        public string firstName
        {
            set
            {
                FirstName = value;
            }
        }
        public string lastName
        {
            set
            {
                LastName = value;
            }
        }
        public string fullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}