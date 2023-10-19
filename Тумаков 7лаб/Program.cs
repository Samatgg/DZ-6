using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace Тумаков_7лаб
{   

    internal class Program
    {
        static void Main(string[] args)
        {
            // Упр. 7.1 - Создать класс счет в банке с закрытыми полями: номер счета, баланс,тип банковского счета
            Console.WriteLine("Упр. 7.1 - Создать класс счет в банке с закрытыми полями: номер счета, баланс,тип банковского счета\n");
            Account Bank_Account = new Account();
            Bank_Account.Number = 1111222233334444;
            Bank_Account.Balance = 3452.80;
            Bank_Account.Type = Account.account_type.Сберегательный;
            Console.WriteLine($"Номер банковского счета: {Bank_Account.Number}\nБаланс: {Bank_Account.Balance} RUB\nТип счета: {Bank_Account.Type}");


            // Упр 7.2 - Изменить класс счет в банке таким образом, чтобы номер счета генерировался сам и был уникальным
            Console.WriteLine("\nУпр 7.2 - Изменить класс счет в банке таким образом, чтобы номер счета генерировался сам и был уникальным\n");
            AccountEx2 Bank_Account2 = new AccountEx2();         
            Bank_Account2.Balance = 20910.80;
            Bank_Account2.Type = AccountEx2.account_type.Накопительный;
            Console.WriteLine($"Номер банковского счета: {AccountEx2.ChangeNumber()}\nБаланс: {Bank_Account.Balance} RUB\nТип счета: {Bank_Account.Type}\n");            AccountEx2 Bank_Account3 = new AccountEx2();
            Bank_Account2.Balance = 210.40;
            Bank_Account2.Type = AccountEx2.account_type.Общий;
            Console.WriteLine($"Номер банковского счета: {AccountEx2.ChangeNumber()}\nБаланс: {Bank_Account.Balance} RUB\nТип счета: {Bank_Account.Type}");
            
            
            // Упр 7.3 - Добавить в класс счет в банке два метода: снять со счета и положить на счет
            Console.WriteLine("\nУпр 7.3 - Добавить в класс счет в банке два метода: снять со счета и положить на счет\n");
            AccountEx3 Bank_Account4 = new AccountEx3(5000);
            Console.WriteLine("Здравствуйте!\nВыберите операцию: 'Пополнить' или 'Снять'");
            Console.WriteLine("Если вы сюда зашли случайно, то можете выбрать - 'Выйти' ");
            string operation = Console.ReadLine().ToLower();
            switch (operation)
            {
                case "пополнить":
                    Console.WriteLine("Выберите сумму для пополнения");
                    double sum;
                    bool a = double.TryParse(Console.ReadLine(), out sum);
                    if (a)
                    {
                        //AccountEx3.Deposit(sum); - не срабатывает
                    }
                    else
                    {
                        Console.WriteLine("Некорректно ввели число");
                    }
                    break;
                case "снять":
                    Console.WriteLine("Выберите сумму для снятия");
                    double summ;
                    bool b = double.TryParse(Console.ReadLine(), out summ);
                    if (b)
                    {
                        //AccountEx3.Withdraw(summ); - тоже не срабатывает
                    }
                    else
                    {
                        Console.WriteLine("Некорректно ввели число");
                    }
                    break;
                case "выйти":
                    break;
                default:
                    Console.WriteLine("ОШИБКА!Вы не выбрали ни одно из пунктов");
                    break;
            }

            // Дз. 7.1 - 
            Console.WriteLine("");
            Building building = new Building(120,20,200,10);
            Console.WriteLine($"Номер здания: {building.BuildingNumber()}");
            Console.WriteLine($"Высота: {building.Height()}");
            Console.WriteLine($"Этажей: {building.Floors()}");
            Console.WriteLine($"Квартир: {building.Apartments()}");
            Console.WriteLine($"Подъездов: {building.Entrances()}");
            Console.WriteLine($"Высота этажа: {building.CalculateFloorHeight()}");
            Console.WriteLine($"Кол-во квартир в подъезде: {building.CalculateApartmentsEntrance()}");
            Console.WriteLine($"Кол-во квартир на этаж: {building.CalculateApartmentsFloor()}");
        }
    }
}
