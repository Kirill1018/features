using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    internal class Features
    {
        class Money
        {
            public Money()
            {

            }
            public double rubles { get; set; } = 0;//начальная инициализация рублей
            public double kopecks { get; set; } = 0;//начальная инициализация копеек
            public Money (double roubles, double copecks)
            {
                rubles = roubles;
                kopecks = copecks / 100;
                double cash = rubles + kopecks;
                Console.Write("итог=");
                Console.Write(cash);
                Console.WriteLine(" рублей");
                if (rubles < 0 || kopecks < 0) Console.WriteLine("ошибка");
            }
            public void sum(double currency, double _currency)
            {
                double coin = currency + _currency;
                Console.Write("стоимость=");
                Console.WriteLine(coin);
            }
            public void tax(double currency, double _currency)
            {
                var rand = new Random();
                Console.Write("налог на первый товар=");
                double taxation = rand.Next(65), charge = currency / 100 * taxation;
                Console.WriteLine(charge);
                Console.Write("налог на второй товар=");
                double _taxation = rand.Next(65), _charge = _currency / 100 * _taxation;
                Console.WriteLine(_charge);
            }
        }
        static void Main(string[] args)
        {
            Money wherewhithal = new Money();
            Console.Write("цена первого товара=");
            double roubles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("рублей");
            double copecks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("копеек");
            Money monies = new Money(roubles, copecks);
            double currency = roubles + copecks / 100;
            Console.Write("цена второго товара=");
            roubles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("рублей");
            copecks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("копеек");
            Money _monies = new Money(roubles, copecks);
            double _currency = roubles + copecks / 100;
            wherewhithal.sum(currency, _currency);
            wherewhithal.tax(currency, _currency);
        }
    }
}
