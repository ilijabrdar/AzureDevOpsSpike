using System;
using System.Collections.Generic;
using System.Text;

namespace AzureDevOpsSpike
{
    public class Student
    {
        private String _index;
        private String _firstName;
        private String _lastName;
        private double _gpa;

        public String Index { 
            get
            {
                return _index;
            } 
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                _index = value;
            } 
        }
        public String FirstName { 
            get
            {
                return _firstName;
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                _firstName = value;
            }
        }
        public String LastName { 
            get
            {
                return _lastName;
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                _lastName = value;
            }
        }
        public double GPA { 
            get
            {
                return _gpa;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(GPA), "Must be a positive number.");
            } 
        }

        public Student(string index, string firstName, string lastName, double gpa)
        {
            Index = index;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
        }
    }
}
