using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core
{
    public class Person
    {
        public string Name { get; init; }

        private int age;
        public int Age
        {
            get { return age; }
            set {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative");

                age = value;
            }
        }
    }
}
