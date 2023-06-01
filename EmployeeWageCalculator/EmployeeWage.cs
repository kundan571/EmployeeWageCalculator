using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculator;

public class EmployeeWage
{
    public const byte IS_FULL_PRESENT = 1;
    public const byte PART_PRESENT = 2;
    public const byte PER_HOUR_WAGE = 20;
    public const byte FULL_DAY_HOURS = 8;
    public const byte PART_HOURS = 4;
    public const byte NO_OF_WORKING_DAY = 20;
    public const int MAX_WORKING_HOURS_PER_MONTH = 100;

    public static int CheckAttendance()
    {
        Random randomobj = new Random();
        int Attendance = randomobj.Next(0, 3);
        if (Attendance == IS_FULL_PRESENT)
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
        if (EmployeeCheck == IS_FULL_PRESENT)
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

    public static int AddedPartTimeWage() 
    { 
        int partTimeWage = DailyEmployeeWage();
        return partTimeWage;
    }

    public static int DailyWageSwitchCase()
    {
        int EmployeeHours = 0;
        switch (CheckAttendance())
        {
            case IS_FULL_PRESENT:
                EmployeeHours = FULL_DAY_HOURS;
                break;
            case PART_PRESENT:
                EmployeeHours = PART_HOURS;
                break;
            default:
                EmployeeHours = 0;
                break;
        }

        int DailyWage = EmployeeHours * PER_HOUR_WAGE;
        Console.WriteLine($"Employee Wage: {DailyWage}");
        return DailyWage;

    }

    public static int MonthlyWage()
    {
        int MonthlyWage = 0;
        for (int day = 1; day <= NO_OF_WORKING_DAY; day++)
        {
            int DailyWage = DailyWageSwitchCase();
            MonthlyWage += DailyWage;
        }
        Console.WriteLine($"Total Monthly Wage: {MonthlyWage}");
        return MonthlyWage;
    }

    public static int ConditionalWage() 
    {
        int empHours = 0;
        int totalEmployeeHours = 0;
        int totalWorkingDays = 0;

        while (totalEmployeeHours < MAX_WORKING_HOURS_PER_MONTH && totalWorkingDays < NO_OF_WORKING_DAY)
        {
            totalWorkingDays++;
            switch (CheckAttendance())
            {
                case IS_FULL_PRESENT:
                    empHours = FULL_DAY_HOURS;
                    break;
                case PART_PRESENT: 
                    empHours = PART_HOURS;
                    break;
                default: 
                    empHours = 0; 
                    break;
            }
            totalEmployeeHours += empHours;
            Console.WriteLine($"Day {totalWorkingDays} Employee Hours {totalEmployeeHours}");
        }
        int totalEmployeeWage = totalEmployeeHours * PER_HOUR_WAGE;
        Console.WriteLine($"Total employee Wage: {totalEmployeeWage}");
        return totalEmployeeWage;
    }
}
