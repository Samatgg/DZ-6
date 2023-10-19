namespace Тумаков_7лаб
{
    class AccountEx2
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
        private static int change_number = 0;
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
        public static int ChangeNumber()
        {
            return change_number++;
        }
        public AccountEx2()
        {
            ChangeNumber();
        }

    }
}
