using System;

namespace Тумаков_7лаб
{
    class AccountEx3
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
        public double sum;
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
        // Первоначальный баланс
        public AccountEx3(double initialBalance)
        {
            balance = initialBalance;
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
        public void Withdraw(double amount)
        {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Вы сняли {amount} RUB со счета\nНовый баланс: {balance-amount}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Вы положили {amount} RUB на счет\nНовый баланс: {balance+amount} RUB");
        }
    }
}
