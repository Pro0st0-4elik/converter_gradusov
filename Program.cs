using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

class Program
{
    static void Vstuplenie()
    {
        Console.WriteLine("Введите градус:");
    }

    static TemperatureUnit defaultTemperatureUnit = TemperatureUnit.Celsius;
    
    enum TemperatureUnit
    {
        Fahrenheit,
        Celsius,
        Kelvin
    }
    static void Main(string[] args)
    {
        Vstuplenie();
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Выберите в какое значение будет иметь число:");
            Console.WriteLine("1. По Фаренгейту");
            Console.WriteLine("2. По Цельсию");
            Console.WriteLine("3. По Кельвину");
            Console.WriteLine("4. Выйти");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) // Проверка ввода пользователя и вызов определенной функции
            {
                case 1:
                    Fahrenheit(a);
                    break;
                case 2:
                    Celsius();
                    return;
                case 3:
                    Kelvin();
                    return;
                case 4:
                    Settings();
                    return;
                case 5:
                    Exit();
                    return;
                default:
                    Console.WriteLine("Ошибка, попробуйте снова!");
                    break;
            }
        }

        static void Fahrenheit(double a)
        {
            double fahrenheit = CelsiusToFahrenheit(a);
            Console.WriteLine($"Температура по Фаренгейту: {fahrenheit}F");

            static double CelsiusToFahrenheit(double a)
            {
                return a * 9 / 5 + 32;
            }
        }

        static void Celsius()
        {
            double fahrenheit = CelsiusToFahrenheit(a);
            Console.WriteLine($"Температура по Цельсию: {fahrenheit}F");

            static double CelsiusToFahrenheit(double a)
            {
                return a * 9 / 5 + 32;
            }
        }

        static void Kelvin()
        {
            double fahrenheit = CelsiusToFahrenheit(a);
            Console.WriteLine($"Температура по Кельвину: {fahrenheit}F");

            static double CelsiusToFahrenheit(double a)
            {
                return a * 9 / 5 + 32;
            }
        }

        static void Settings()
        {
            
        }

        static void Exit()
        {
            return;
        }
    }
}