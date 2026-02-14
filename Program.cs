using System;

namespace HelloApp
{
    /// <summary>
    /// Клас для виведення привітання
    /// </summary>
    public class Hello
    {
        /// <summary>
        /// Метод для виведення "Hello World!"
        /// </summary>
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо об'єкт класу Hello
            Hello hello = new Hello();
            
            // Викликаємо метод для виведення привітання
            hello.SayHello();
        }
    }
}
