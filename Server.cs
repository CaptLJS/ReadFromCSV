using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ServerSide
{
    public class MyClass
    {

        public static void Location(string location)
        {
            var reader = new StreamReader(File.OpenRead(@"/Users/ritwik/Downloads/100 Records.csv"));
            var test = true;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values[29] == location)
                {
                    Console.WriteLine(location);
                    Console.WriteLine(values[2] + " " + values[3] + " " + values[4]);
                    test = false;
                }

                Console.WriteLine();

            }

            if(test)

            {
                Console.WriteLine("No such location");
            }


        }



        public static void DOB(string dob)
        {
            var reader = new StreamReader(File.OpenRead(@"/Users/ritwik/Downloads/100 Records.csv"));
            DateTime dob2 = Convert.ToDateTime(dob);
            var test = true;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values[10] == dob)

                    {
                        Console.WriteLine(dob);
                        Console.WriteLine(values[2] + " " + values[3] + " " + values[4]);
                        test = false;
                    }

                Console.WriteLine();

            }
            if(test)
            {
                Console.WriteLine("No such date of birth");
            }


        }



        public static void Designation(string designation)
        {
            var reader = new StreamReader(File.OpenRead(@"/Users/ritwik/Downloads/100 Records.csv"));
            var test = true;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');


                    if (values[1] == designation)
                    {
                        Console.WriteLine(designation);
                        Console.WriteLine(values[2] + " " + values[3] + " " + values[4]);
                        test = false;
                    }

                Console.WriteLine();

            }
            if (test)
            {
                Console.WriteLine("No such designation");
            }

        }
    }

}












