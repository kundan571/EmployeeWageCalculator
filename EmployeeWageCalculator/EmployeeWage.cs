using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculator;

public class EmployeeWage
{
    public const byte IS_PRESENT = 1;
    public const byte PART_PRESENT = 2;

    public static int CheckAttendance()
    {
        Random randomobj = new Random();
        int Attendance = randomobj.Next(0, 3);
        if (Attendance == IS_PRESENT)
        {
            Console.WriteLine("Employee is present:");
            return Attendance;
        }
        else if (Attendance == PART_PRESENT)
        {
            Console.WriteLine("Employee is Part present:");
            return Attendance;
        }
        else
        {
            Console.WriteLine("Employee is absent:");
            return Attendance;
        }
    }
}
