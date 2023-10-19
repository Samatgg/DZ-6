namespace Тема_Визы
{
    abstract class Visa
    {
        // чтение и запись
        public string Country { get; set; }
        public string Type { get; set; }

        // конструктор с параметрами
        public Visa(string country, string type)
        {
            Country = country;
            Type = type;
        }

        // Методы
        public abstract void DisplayInfo();
        public abstract void Apply();
        public abstract void Process();
        public abstract void Approved();
        public abstract void Rejected();
    }
}
