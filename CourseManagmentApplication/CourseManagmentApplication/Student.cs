using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Student
    {
        public string FullName { get; set; }
        public Group GroupNo { get; set; }
        public bool Type { get; set; } 
      
        public Student(string Fullname,Group group,bool Type)
        {

            this.FullName = FullName;
            this.GroupNo = group;
            this.Type = Type;
            if (Type == true)
            {
                Console.WriteLine("Zemanetli");
            }
        }
        public override string ToString()
        {
            var result = Type ? "Zemanetli" : "Zemanetsiz";
            return $"Fullname:{FullName} Group:{GroupNo} Type:{result}";

        }

    }
}
