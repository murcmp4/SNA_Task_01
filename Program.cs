using System;

namespace SNA_Task_01
{
    class Program
    {
        static void ShowBadDealMessage(double diamonds, double gold)
        {
            Console.Write("Упс.. Не получилось\n\nКристаллов было: "
                        + diamonds + "\nЗолота было: " + gold);
        }

        static void ShowGoodDealMessage(double diamonds, double gold, double purchase)
        {
            Console.Write("Вы купили:\n\n"
                        + purchase + " Кристаллов" + "\nЗолотых " + gold
                        + "\nКристаллов " + diamonds);
        }

        static string GetAnswer()
        {
            Console.Write("\n Дальше ? [Y / N]");
            string continueAns = Console.ReadLine();

            return continueAns;
        }

        static bool findСontinuation(string answer)
        {
            if (answer == "Y" ||
                answer == "y" ||
                answer == "Н" ||
                answer == "н")
            {
                return true;
            }
            else if (answer == "N" ||
                answer == "n" ||
                answer == "Т" ||
                answer == "т")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            Console.Write("Сколько кристаллов в магазине?:  ");
            double diamonds = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Сколько золота у вас? ");
            double gold = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Сколько стоит кристалл? ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            bool isContinue = true;

            while (isContinue)
            {
                Console.Write("Сколько хочешь кристаллов\nОтвет: ");
                int purchase = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                if (purchase > diamonds)
                {
                    ShowBadDealMessage(diamonds, gold);

                    isContinue = findСontinuation(GetAnswer());
                }
                else if (gold - purchase * price < 0)
                {
                    Console.Write("\nЧе по золотишку?");

                    ShowBadDealMessage(diamonds, gold);

                    isContinue = findСontinuation(GetAnswer());
                }
                else
                {
                    gold -= purchase * price;
                    diamonds -= purchase;

                    ShowGoodDealMessage(diamonds, gold, purchase);

                    isContinue = findСontinuation(GetAnswer());
                }
            }
        }
    }
}
