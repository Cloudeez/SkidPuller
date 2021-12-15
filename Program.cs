using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using FakeIPPUller.func;

namespace FakeIPPUller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skid Puller | Main Menu";

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Menu();

            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Clear();

            Console.WriteLine("\n\n                     .▄▄ · ▄ •▄ ▪  ·▄▄▄▄       ▄▄▄·▄• ▄▌▄▄▌  ▄▄▌  ▄▄▄ .▄▄▄  ");
            Console.WriteLine("                     ▐█ ▀. █▌▄▌▪██ ██▪ ██     ▐█ ▄██▪██▌██•  ██•  ▀▄.▀·▀▄ █·");
            Console.WriteLine("                     ▄▀▀▀█▄▐▀▀▄·▐█·▐█· ▐█▌     ██▀·█▌▐█▌██▪  ██▪  ▐▀▀▪▄▐▀▀▄ ");
            Console.WriteLine("                     ▐█▄▪▐█▐█.█▌▐█▌██. ██     ▐█▪·•▐█▄█▌▐█▌▐▌▐█▌▐▌▐█▄▄▌▐█•█▌");
            Console.WriteLine("                      ▀▀▀▀ ·▀  ▀▀▀▀▀▀▀▀▀•     .▀    ▀▀▀ .▀▀▀ .▀▀▀  ▀▀▀ .▀  ▀");

            Console.WriteLine("\n                      =====================================================");
            Console.WriteLine("                           [1] Pull IPs   [2] Spam Report   [3] DDOS");
            Console.WriteLine("                      =====================================================\n");
            Console.Write(">");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();

                    PullIP.PullIPS();
                    break;

                case "2":
                    Console.Clear();

                    SpamReport.Report();
                    break;

                case "3":
                    Console.Clear();

                    SkidDdos.Ddos();
                    break;

            }
        }
    }
}
