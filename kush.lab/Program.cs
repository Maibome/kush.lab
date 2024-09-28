using System.Text;

namespace kush.lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //// Планировщик бюджета
            //int r, f, v,sumex,income;
            //Console.Write("The expense for rent:");
            //r = int.Parse(Console.ReadLine());
            //Console.Write("The expense for food:");
            //f = int.Parse(Console.ReadLine());
            //Console.Write("The expense for vehicle:");
            //v = int.Parse(Console.ReadLine());
            //sumex = r + f + v;
            //Console.Write($"Sum expenses {sumex}");
            //Console.Write("The income:");
            //income = int.Parse(Console.ReadLine());
            //Console.Write(income - sumex);


            //Индикатор здоровья:
            /*  double m, h, IMT;
              int a;
              Console.Write("Your weight:");
              m = double.Parse(Console.ReadLine());
              Console.Write("Your height:");
              h = double.Parse(Console.ReadLine());
              Console.Write("Your age:");
              a = int.Parse(Console.ReadLine());
              IMT = m / Math.Pow(h, 2);
              Console.WriteLine(Math.Round(IMT));

              if (IMT < 18.5)
              {
                  Console.WriteLine("Underweight,consult with a doctor ");
              }
              else if (IMT >= 18.5 && IMT < 24.9)
              {
                  Console.WriteLine("Normal, maintain a healthy lifestyle");
              }
              else if (IMT >= 25 && IMT < 29.9)
              {
                  Console.WriteLine("Overweight,do more physic actions ");
              }
              else
              {
                  Console.WriteLine("Obesity,consult with a doctor to develop a weight loss program ");
              }*/


            //Калькулятор финансовых целей:
            int a, d, savemoney;
            Console.Write("Goal amount:");
            a = int.Parse(Console.ReadLine());
            Console.Write("dedline term:");
            d = int.Parse(Console.ReadLine());
            savemoney = a / d;
            Console.Write("Save money monthly:" + savemoney);

            // Рекомендации
            Console.WriteLine("\nrecomendation:");
            if (savemoney > 0)
            {
                Console.WriteLine("- Составьте бюджет и следите за своими расходами.");
                Console.WriteLine("- Старайтесь откладывать деньги в начале месяца.");

            }
            else
            {
                Console.WriteLine("- Проверьте введенные данные. Возможно, срок слишком короткий или сумма слишком мала.");
            }

            // Анализ социальных сетей
            //Console.Write("Sosial network:");
            //Console.ReadLine();





        }
    }
}
