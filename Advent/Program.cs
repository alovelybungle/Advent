using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new ModuleStorage();
            var modules = storage.GetModules();

            var fuelSum = modules.Sum(m => m.TotalFuelRequirement);

            Console.WriteLine($"The sum of the fuel requirements for all of the modules on the spacecraft is {fuelSum}");

            var computer = new Computer();
            var program = new GravityAssistProgram();

            program.IntCode[1] = 12;
            program.IntCode[2] = 2;

            program.IntCode = computer.RunIntCodeProgram(program.IntCode);

            Console.WriteLine($"Gravity Assist Program State: {string.Join(",", program.IntCode.Select(i => i.ToString()))}");

            Console.ReadKey();
        }
    }
}
