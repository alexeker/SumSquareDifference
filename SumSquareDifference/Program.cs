/*Программа вычисляет сначала сумму квадратов первых 100 чисел
 * Затем вычисляет квадрат сумы первых 100 чисел
 * И в итоге находит разницу между квадратом суммы и суммой квадратов 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hundred = new int[101];//Массив для заполнения числами
            var sumOfSquares = 0;//Сумма квадратов 100 чисел
            var simpleSum = 0.0;//Сумма 100 чисел
            for(int i = 1; i < 101; i++)
            {
                //Цикл заполнения массива числами
                hundred[i] = i;//i-й член массива заполняется i-м числом
            }
            int SumOfSquares()
            {
                //Метод суммы квадратов
                foreach (int i in hundred)
                {
                    //Цикл проходит каждый член массива 
                    sumOfSquares += hundred[i] * hundred[i];//В переменную суммы добавляется новый член в квадрате
                }
                return sumOfSquares;//Возврат значения
            }
            int second = SumOfSquares();//Присваивание переменной значения функции
            int SquareOfSum()
            {
                //Метод квадрата суммы 
                foreach (int i in hundred) {
                    //Цикл проходит каждый член массива
                    simpleSum += hundred[i];//Вычислается сумма всех 100 чисел
                }
                int squareOfSum = (int)Math.Pow(simpleSum, 2);//Сумма возносится в квадрат
                return squareOfSum;//Возврат значения
            }
            int first = SquareOfSum();//Присваивание переменной значения функции
            int result = first - second;//Операция вычетания
            Console.WriteLine(result);//Вывод в значения в консоль
            Console.ReadLine();
        }
    }
}
