using System;

namespace Тема_Визы
{
    class WorkVisa : Visa
    {
        // Дополнительные свойства
        public string Company { get; set; }
        public bool IsApproved { get; private set; }

        // Конструкторы с параметрами
        public WorkVisa(string country, string type, string company) : base(country, type)
        {
            Company = company;
            IsApproved = true;
        }
        // Методы
        public override void DisplayInfo()
        {
            Console.WriteLine("Информация о рабочей визе:");
            Console.WriteLine("Страна: " + Country);
            Console.WriteLine("Тип визы: " + Type);
            Console.WriteLine("Компания: " + Company);
            Console.WriteLine("Статус: " + (IsApproved ? "Одобрен" : "Отклонен"));
        }
        public override void Apply()
        {
            Console.WriteLine("Вы подали заявление на рабочую визу в " + Country);
        }
        public override void Process()
        {
            Console.WriteLine("Обработка вашего заявления на рабочую визу...");
        }
        public override void Approved()
        {
            Console.WriteLine("Поздравляю! Ваша рабочая виза в " + Country + " была одобрена.");
            IsApproved = true;
        }
        public override void Rejected()
        {
            Console.WriteLine("Извините, ваше заявление на рабочую визу в " + Country + " было отклонено.");
        }
    }
}
