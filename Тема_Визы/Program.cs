using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_Визы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkVisa workVisa = new WorkVisa("Россия", "Трудоустройство", "Газпром");
            TouristVisa touristVisa = new TouristVisa("Китай", "Туризм", 30);
            StudyVisa studyVisa = new StudyVisa("Англия", "Учеба", "Гарвард", 5);
            // работа методов
            Console.WriteLine("\tУчебная виза");
            studyVisa.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("\tРабочая виза");
            workVisa.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("\tTуристическая виза");
            touristVisa.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Подача заявления на учебную визу...");
            studyVisa.Apply();
            studyVisa.Process();
            studyVisa.Approved();
            Console.WriteLine();

            Console.WriteLine("Подача заявления на рабочую визу...");
            workVisa.Apply();
            workVisa.Process();
            workVisa.Approved();
            Console.WriteLine();

            Console.WriteLine("Подача заявления на туристическую визу...");
            touristVisa.Apply();
            touristVisa.Process();
            touristVisa.Rejected();
            Console.WriteLine();
        }
    }
}
