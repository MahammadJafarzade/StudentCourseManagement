using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Group
    {
        public  string Category;
        public string No { get; set; }
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public List<Student> students = new List<Student>();



        public Group(string category, string no, bool isOnline)
        {
            No = no;
            IsOnline = isOnline;
            Category = category;
            if (IsOnline == true)
            {
                Limit = 15;
                Console.WriteLine("Online qrup yaradilcaq");
            }
            else
            {
                Limit = 10;
            }
        }


    }
}


