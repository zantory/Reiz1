 using System;



namespace ConsoleApp

{

    class FindAngle

    {

        static void Main(string[] args)

        {

            int hr, min;

            Console.WriteLine("Enter Hour: ");

            hr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Minute: ");

            min = Convert.ToInt32(Console.ReadLine());



            double hrDeg = (hr * 30) + (min * 30 / 60);

            double minDeg = min * 6;



            double dif = Math.Abs(hrDeg - minDeg);

            if (dif > 180)
                dif = 360 - dif;

            Console.WriteLine("Angle b/w both minute and hour hand is : {0} ", dif);

            Console.ReadLine();

        }

    }

}