using System.Diagnostics.Metrics;

int RightAnswers = 0;
int WrongAnswers = 0;

string[] Datei = File.ReadAllLines(@"C:\Users\henry\Dropbox\Htl_Leonding\2_Klasse\CABS\Cabs_Quiz_C#\Cabs_Fragen.txt");
int[] AlreadyUsed = new int[Datei.Length];
Console.Write($"Enter how many questions you want (1 - {Datei.Length}): ");
int Anzahl = int.Parse(Console.ReadLine()!);

Random random = new Random();
int Counter = 0;
for (int i = 0; i < Anzahl; i++)
{
   bool AlreadyUsedBool = false;
   int QuestionNumber;
   do
   {
      QuestionNumber = random.Next(0, Datei.Length);
      if(AlreadyUsed.Contains(QuestionNumber))
      {
         AlreadyUsedBool = true;
      }
      else
      {
         AlreadyUsed[Counter] = QuestionNumber;
         AlreadyUsedBool = false;
      }
      Counter++;
   }while(AlreadyUsedBool || Counter > Datei.Length);
   
   Console.Write(Datei[QuestionNumber].Split(';')[0] + ":");
   string Answer = Console.ReadLine()!.ToLower();

   if (Answer == Datei[QuestionNumber].Split(';')[1].ToLower())
   {
      Console.WriteLine("Correct");
      RightAnswers++;
   }
   else
   {
      Console.WriteLine("Wrong. The right answer was " + Datei[QuestionNumber].Split(';')[1]);
      System.Console.Write("Did you feel like you were right anyways? (y/n)");
      if(Console.ReadLine()!.ToLower() == "y")
      {
         RightAnswers++;
      }
      else
      {
         WrongAnswers++;
      }
   }
}

Console.WriteLine($"You had {RightAnswers} right answers and {WrongAnswers} wrong answers");
Console.WriteLine($"You would have gotten {((double)RightAnswers / Anzahl) * 100} Percent right");