using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnVsBreakStatement
{
    internal class Program
    {
        /// <summary>
        /// Main Function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // using return
            if (IsTodayOff_Return())
            {
                Console.WriteLine("Today is off");
            }
            else
            {
                Console.WriteLine("Today is not off");
            }
            
            // using break
            //if (IsTodayOff_Break())
            //{
            //    Console.WriteLine("Today is off");
            //}
            //else
            //{
            //    Console.WriteLine("Today is not off");
            //}

            Console.WriteLine("\n\n\nPress enter to exit");
            Console.ReadLine();
        }

        /// <summary>
        /// IsTodayOff Using return statement
        /// </summary>
        /// <returns></returns>
        static bool IsTodayOff_Return()
        {
            Console.WriteLine("----- IsTodayOff_Return ----- Started");

            var weekendDays = new List<string> { "Saturday", "Sunday" };

            foreach (var item in weekendDays)
            {
                if (DateTime.Now.DayOfWeek.ToString().ToLower() == item.ToLower())
                {
                    return true;
                }
            }

            Console.WriteLine("----- IsTodayOff_Return ----- Ended");
            return false;
        }

        /// <summary>
        /// IsTodayOff using break statement
        /// </summary>
        /// <returns></returns>
        static bool IsTodayOff_Break()
        {
            Console.WriteLine("----- IsTodayOff_Break ----- Started");

            var weekendDays = new List<string> { "Saturday", "Sunday" };
            var result = false;
            foreach (var item in weekendDays)
            {
                if (DateTime.Now.DayOfWeek.ToString().ToLower() == item.ToLower())
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine("----- IsTodayOff_Break ----- Ended");
            return result;
        }
    }
}
