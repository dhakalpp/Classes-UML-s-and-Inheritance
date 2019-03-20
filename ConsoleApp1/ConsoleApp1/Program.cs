using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        class Person
        {
            public string Fname { get; set; }
            public string lname { get; set; }
        }
        class Student : Person
        {
            public int Studentid { get; set; }
            public Student(string _fname, string _lname, string _stdid)

            Fname = _fname;
            Lname = _lname;


          






        }


    }
}
