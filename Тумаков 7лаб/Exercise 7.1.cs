namespace Тумаков_7лаб
{
    class Account
    {
        public enum account_type
        {
            Сберегательный,
            Накопительный,
            Общий
        }
        private long number;
        private double balance;
        private account_type type;
        // Заполнение и чтение номера
        public long Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        // Заполнение и чтение баланса
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        // Заполнение и чтение типа счета
        public account_type Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }                 
    }
}
