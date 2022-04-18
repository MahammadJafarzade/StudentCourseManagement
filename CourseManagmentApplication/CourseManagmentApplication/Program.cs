using System;
using System.Collections.Generic;

namespace CourseManagmentApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> telebeler = new List<Student>();
            List<Group> qruplar = new List<Group>();

            int num=1;
            
            while (num!=0)
            {
                Console.WriteLine("1.Yeni qrup yarat\n 2.Grouplarin siyahisi\n 3.Qrup uzerinde duzelis \n 4.Qrupdaki telebelerin siyahisi \n 5.Butun telebelerin siyahisi \n 6.telebe yarat"); 
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {

                    Console.WriteLine("Yeni qrup yaradilir detallari daxil edin!");
                    Console.WriteLine("Qrupun kategoriyasini daxil edin");
                    string category = Console.ReadLine();
                    Console.WriteLine("Qrupun nomresini daxil edin");
                    string groupno = Console.ReadLine();
                    Console.WriteLine("Qrupda dersler nece kecilecek?");
                    bool IsOnline = Convert.ToBoolean(Console.ReadLine());
                    Group group = new Group(category, groupno, IsOnline);
                    qruplar.Add(group);
                }
                if (num == 2)
                {
                    foreach (var qrup in qruplar)
                    {
                        Console.WriteLine($"Category:{qrup.Category} GroupNo:{qrup.No} IsOnline:{qrup.IsOnline}");
                    }
                }
                if (num == 3)
                {

                }
                if (num == 4)
                {
                    Console.WriteLine("telebenin oldugu qrupun nomresini daxil edin");
                    string GroupNo = Console.ReadLine();

                    bool IsExist = false;

                    while (IsExist == false)
                    {
                        foreach (var ttelebe in telebeler)
                        {
                            if (GroupNo == ttelebe.GroupNo.No)
                            {
                                Console.WriteLine($"StudentName:{ttelebe.FullName} StudentGNo:{ttelebe.GroupNo}");
                            }
                            else
                            {
                                Console.WriteLine("Group is not exist");
                            }

                        }
                    }

                }
                if (num == 5)
                {
                    foreach (var telebe in telebeler)
                    {
                        Console.WriteLine($"Fullname:{telebe.FullName} GroupNo:{telebe.GroupNo},Type:{telebe.Type}");
                    }
                }
                if (num == 6)
                {
                    bool IsExist = false;
                    Console.WriteLine("Yeni telebe qeydiyata alinir");
                    Console.WriteLine("Telebenin adini qeyd edin");
                    string FullName = Console.ReadLine();
                    Console.WriteLine("Telebenin qrupunu daxil edin");
                    string Group = Console.ReadLine();
                   
                    Console.WriteLine("Zemanetli yoxsa zemanetsiz qeyd edin zehmet olmasa");
                    bool Type =Convert.ToBoolean(Console.ReadLine());
                }
            }


        }

    }
}
