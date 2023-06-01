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
    public const byte PER_HOUR_WAGE = 20;
    public const byte FULL_DAY_HOURS = 8;
    public const byte PART_HOURS = 4;

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

    public static int DailyEmployeeWage()
    {
        int EmployeeCheck = CheckAttendance();
        if (EmployeeCheck == IS_PRESENT)
        {
            int DailyWage = PER_HOUR_WAGE * FULL_DAY_HOURS;
            Console.WriteLine($"Daily Wage: {DailyWage}");
            return DailyWage;
        }
        else if (EmployeeCheck == PART_PRESENT)
        {
            int DailyWage = PER_HOUR_WAGE * PART_HOURS;
            Console.WriteLine($"Daily Wage: {DailyWage}");
            return DailyWage;
        }

        else
        {
            int DailyWage = 0;
            Console.WriteLine($"Daily wage: {DailyWage}");
            return DailyWage;
        }
    }
}
