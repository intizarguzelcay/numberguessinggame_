using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
              
             int number_kept = (new Random()).Next(1,10);
             int right =5;
             int turn=0;
             int number;

             double question_score = 100/right;
            
             while (right >0)
             {   
                 turn++;
                 Console.Write("number: ");
                 number = int.Parse(Console.ReadLine());
                 right--;

                 if (number == number_kept)

                 {
                    double puan = 100 -(question_score*turn-1);
                    Console.WriteLine($"Congratulations, you guessed it {turn} times.");
                    Console.WriteLine($"Total score: { puan}" );
                    break;
                 }

                 else 
                 { 
                   if (right==0)
                      break;
                   if (number_kept >number)
                   {
                     Console.WriteLine("Up");
                   }
                   else
                   {
                     Console.WriteLine("Down");
                   }
                 }
                
                 
             }
            Console.WriteLine("Game over.");
            Console.WriteLine("Do you want to continue? (y/n)");
            string result = Console.ReadLine();

            if (result=="n" || result== "no")
            {
              break;
            }
          
            } while (true);

        }
    }
}
