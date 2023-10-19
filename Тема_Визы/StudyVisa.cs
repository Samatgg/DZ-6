using System;

namespace Тема_Визы
{
    class StudyVisa : Visa
    {
        public int Duration { get; set; }
        public bool IsApproved { get; private set; }
        public string Institute { get; set; }
        // конструкторы с параметрами
        public StudyVisa(string country, string type, string institute, int duration) : base(country, type)
        {
            Duration = duration;
            IsApproved = true;
            Institute = institute;
        }
        // методы
        public override void DisplayInfo()
        {
            Console.WriteLine("Информация об учебной визе:");
            Console.WriteLine("Страна: " + Country);
            Console.WriteLine("Тип визы: " + Type);
            Console.WriteLine("Институт: " + Institute);
            Console.WriteLine("Длительность: " + Duration + " лет");
            Console.WriteLine("Статус: " + (IsApproved ? "Одобрен" : "Отклонен"));
        }
        public override void Apply()
        {
            Console.WriteLine("Вы подали заявление на учебную визу в " + Country);
        }
        public override void Process()
        {
            Console.WriteLine("Обработка вашего заявления на учебную визу..");
        }
        public override void Approved()
        {
            Console.WriteLine("Поздравляю! Ваша учебная виза в " + Country + " была одобрена.");
            IsApproved = true;
        }
        public override void Rejected()
        {
            Console.WriteLine("Извините, ваше заявление на учебную визу в " + Country + " было отклонено.");
        }
    }
}
