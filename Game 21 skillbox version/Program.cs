using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Game_21_skillbox_version
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            Console.WriteLine("Приветствую! Если хотите сыграть в игру \"21\", введите число карт у вас на руках: ");
            ushort cardAmount = Convert.ToUInt16(Console.ReadLine()); // ushort - для экономии места, ToInt16 - преобразую в числовую переменную

            Console.WriteLine($" В игре \"21\" участвуют числовые и буквенные карты. " +
                   $"\n Для ввода числовых карт используйте цифры 2,3,4,5,6,7,8,9,10." +
                   $"\n Для ввода буквенных карт используйте следующие обозначения: " +
                   $"\n Валет - J, Дама - Q, Король - K, Туз - T"); 
            
            Console.WriteLine($"\n  Пожалуйста, введите по очереди номинал всех карт." +
                $"\n  Когда вы введете номер одной карты, нажмите Enter и введите номер следующей карты.");

            var result = 0;
            
            for (int i = 0; i<cardAmount; i++) // делаю из введенного пользователем числа - счетчик для цикла, также использую постфиксный инкремент
            {
                var nominal = Console.ReadLine();

                switch (nominal)
                {
                    case "2":
                        result = result + 2; // Всего карт в колоде 13 (10 числовых, 4 буквенных), поэтому и случаев прописываю 13
                        break;

                    case "3":
                        result = result + 3;
                        break;

                    case "4":
                        result = result + 4;
                        break;

                    case "5":
                        result = result + 5;
                        break;

                    case "6":
                        result = result + 6;
                        break;

                    case "7":
                        result = result + 7;
                        break;

                    case "8":
                        result = result + 8;
                        break;

                    case "9":
                        result = result + 9;
                        break;

                    case "10":
                        result = result + 10;
                        break;

                    case "J":
                        result = result + 10;
                        break;

                    case "Q":
                        result = result + 10;
                        break;

                    case "K":
                        result = result + 10;
                        break;

                    case "T":
                        result = result + 10;
                        break;
                }

               
            }

            Console.WriteLine($"   Сумма ваших карт - {result}!");
            Console.ReadKey();
        }
    }
}
