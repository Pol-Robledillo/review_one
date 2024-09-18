using System;

class Program
{
    static void Main(string[] args)
    {
        const string SelectOptionMessage = "1. Calcular mitjana de notes\n" +
                                           "2. Introduïr ciutats i codis postals\n" +
                                           "3. Sortir";
        const string AvgMessage = "La mitjana de les notes es: ";
        const string PassedMessage = "Aprovat";
        const string FailedMessage = "Suspès";
        const string SelectCityMessage = "1. Introduïr ciutat\n" +
                                         "2. Sortir";
        const string InputCityMessage = "Introdueix el nom de la ciutat";
        const string InputZipCodeMessage = "Introdueix el codi postal";
        const string ZipCodeMessage = "Codi postal: ";
        const string CityMessage = "\tCiutat: ";
        string[] InputGradeMessages = { "Introdueix la primera qualificació", 
                                        "Introdueix la segona qualificació", 
                                        "Introdueix la tercera qualificació" };
        List<string?> cities = new List<string?>();
        List<int> zipCodes = new List<int>();
        int nota, option;
        float avg = 0;

        do
        {
            Console.WriteLine(SelectOptionMessage);
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        } while (option != 1 && option != 2);

        switch (option)
        {
            case 1:
                for (int i = 0; i < InputGradeMessages.Length; i++)
                {
                    Console.WriteLine(InputGradeMessages[i]);
                    nota = Convert.ToInt32(Console.ReadLine());
                    avg += nota;
                }

                avg /= InputGradeMessages.Length;

                Console.WriteLine(AvgMessage + avg);

                Console.WriteLine(avg > 6 ? PassedMessage : FailedMessage);
                break;
            case 2:
                do
                {
                    Console.WriteLine(SelectCityMessage);
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (option == 1)
                    {
                        Console.WriteLine(InputCityMessage);
                        cities.Add(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine(InputZipCodeMessage);
                        zipCodes.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine();
                    }
                } while (option != 2);
                for (int i = 0; i < cities.Count; i++)
                {
                    Console.Write(ZipCodeMessage + zipCodes[i]);
                    Console.WriteLine(CityMessage + cities[i]);
                }
                break;
        }
    }
}
