using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var process = new Process();

            process.StartInfo.FileName = "C:\\Учёба\\Системное программирование\\HW_2.2\\HW_2.2\\bin\\Debug\\net8.0-windows\\HW_2.2.exe";

            process.Start();

            Console.WriteLine("Запущен процесс: "+ process.ProcessName);

            process.WaitForExit();

            Console.WriteLine("Процесс завершился с кодом: " + process.ExitCode);

            Console.WriteLine("Имя текущего процесса: " + Process.GetCurrentProcess().ProcessName);

            Console.ReadKey();
        }
    }
}
