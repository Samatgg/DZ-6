using System;

namespace Тема_Визы
{
    class TouristVisa : Visa
    {
        // Доп. св-ва
        public int Duration { get; set; }
        public bool IsApproved { get; private set; }
        // конструкторы с параметрами
        public TouristVisa(string country, string type, int duration) : base(country, type)
        {
            Duration = duration;
            IsApproved = false;
        }
        // методы
        public override void DisplayInfo()
        {
            Console.WriteLine("Информация о туристической визе:");
            Console.WriteLine("Страна: " + Country);
            Console.WriteLine("Тип визы: " + Type);
            Console.WriteLine("Длительность: " + Duration + " дней");
            Console.WriteLine("Статус: " + (IsApproved ? "Одобрен" : "Отклонен"));
        }
        public override void Apply()
        {
            Console.WriteLine("Вы подали заявление на туристическую визу в " + Country);
        }
        public override void Process()
        {
            Console.WriteLine("Обработка вашего заявления на туристическую визу..");
        }
        public override void Approved()
        {
            Console.WriteLine("Поздравляю! Ваша туристическая виза в " + Country + " был одобрен.");
            IsApproved = true;
        }
        public override void Rejected()
        {
            Console.WriteLine("Извините, ваше заявление на туристическую визу в " + Country + " было отклонено.");
        }
    }
}
