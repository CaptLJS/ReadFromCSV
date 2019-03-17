using System;

namespace ClientSide
{

    using ServerSide;
    class MainClass
    {
         static void Main(string[] args)
        {
           
            int n;
            Console.WriteLine("Enter 1 for viewing employee by Location");
            Console.WriteLine("Enter 2 for viewing employee by Date of birth");
            Console.WriteLine("Enter 3 for viewing employee by Designation");
            n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("Enter location");
                string l = Console.ReadLine();
                MyClass.Location(l);
            }
            else if(n==2)
            {
                Console.WriteLine("Enter DOB");
                string dob = Console.ReadLine();
                MyClass.DOB(dob);
            }
            else if(n==3)
            {
                Console.WriteLine("Enter designation");
                string d = Console.ReadLine();
                MyClass.Designation(d);
            }
            else
            {
                Console.WriteLine("Incorrect entry");
            }

        }
    }
}
