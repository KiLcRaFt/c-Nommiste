using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public class Person
    {
        public string name { get; }
        public int age;

        public person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age
        {
            get { return age; }
        }

        public int BDate()
        {
            int bdate = DateTime.Now.Year;
            int Result = bdate - age;
            return Result;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(BDate());

        }
    }
