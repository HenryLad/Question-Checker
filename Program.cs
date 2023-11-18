int RightAnswers = 0;
int WrongAnswers = 0;

string[] Datei = File.ReadAllLines(@"C:\Users\henry\Dropbox\Htl_Leonding\2_Klasse\CABS\Cabs_Quiz_C#\Cabs_Fragen.txt");

Console.Write("Enter how many questions you want (1 - 63): ");
int Anzahl = int.Parse(Console.ReadLine()!);

Random random = new Random();

for (int i = 0; i < Anzahl; i++)
{
   int QuestionNumber = random.Next(0, 63);
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
      WrongAnswers++;
   }
}

Console.WriteLine($"You had {RightAnswers} right answers and {WrongAnswers} wrong answers");
Console.WriteLine($"You would have gotten {((double)RightAnswers / Anzahl) * 100} Percent right");