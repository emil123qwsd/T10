using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Angle ang;
            //do
            //{
                Console.WriteLine("Введите данные");
                double degree_ = Convert.ToDouble(Console.ReadLine());
                double minute_ = Convert.ToDouble(Console.ReadLine());
                double second_ = Convert.ToDouble(Console.ReadLine());
                //ang = new Angle(degree_,minute_,second_);
                Angle ang = new Angle() { degree = degree_, minute = minute_, second = second_ };
            //}
            //while (ang.isCorrect == false);

            double totalAngle = ang.ToRadian();
            Console.WriteLine(totalAngle);
            Console.ReadKey();
        }
    }
}
