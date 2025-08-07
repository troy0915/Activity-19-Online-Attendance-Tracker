using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_19_Online_Attendance_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attendees = new List<string>();
            string input;

            Console.WriteLine("Enter student names (one per line, blank to finish):");
            {
                Console.Write("> ");
                input = Console.ReadLine().Trim();

                while (true)
                {
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break; 
                    }

                    if (!ContainsName(attendees, input))
                    {
                        attendees.Add(input);
                        Console.WriteLine($"Added: {input}");
                    }
                    else
                    {
                        Console.WriteLine($"{input} already logged - not counted again");
                    }
                }                                             
            }
            attendees.Sort(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\nAttendance Report");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Total unique attendees: {attendees.Count}");
            Console.WriteLine("\nAttendees (alphabetical order):");

            foreach (string student in attendees)
            {
                Console.WriteLine(student);
            }
        }
        static bool ContainsName(List<string> list, string name)
        {
            foreach (string item in list)
            {
                if (item.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}





