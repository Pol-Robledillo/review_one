using System;

class Program
{
    static void Main(string[] args)
    {
        const string AvgMessage = "El promig de les notes es: ";
        const string PassedMessage = "Aprovat";
        const string FailedMessage = "Suspès";
        string[] InputGradeMessages = { "Introdueix la primera qualificació", 
                                        "Introdueix la segona qualificació", 
                                        "Introdueix la tercera qualificació" };
        int nota;
        float avg = 0;

        for (int i = 0; i < InputGradeMessages.Length; i++)
        {
            Console.WriteLine(InputGradeMessages[i]);
            nota = Convert.ToInt32(Console.ReadLine());
            avg += nota;
        }

        avg /= InputGradeMessages.Length;

        Console.WriteLine(AvgMessage + avg);

        Console.WriteLine(avg > 6 ? PassedMessage : FailedMessage);
    }
}
