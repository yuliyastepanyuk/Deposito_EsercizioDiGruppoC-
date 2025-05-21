using System;
class Input{
    public static int Int() //chiede un input all'utente e verifica che sia un intero, altrimenti riprova
    { 
        while (true){
            if(int.TryParse(Console.ReadLine(), out int output)){
                return output;
            }
            else{
                Console.WriteLine("\nInput non valido, riprovare\n");
            }
        }
    }
    
    public static int Int(int a, int b) //chiede un input all'utente e verifica che sia un intero compreso tra "a" e "b", altrimenti riprova
    { 
        while (true){
            if (int.TryParse(Console.ReadLine(), out int output))
            {
                if (output >= a && output <= b)
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("\nInput non valido, riprovare\n");
                }
            }
            else
            {
                Console.WriteLine("\nInput non valido, riprovare\n");
            }
        }
    }

    public static float Float() //chiede un input all'utente e verifica che sia un float, altrimenti riprova
    {
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out float output))
            {
                return output;
            }
            else
            {
                Console.WriteLine("\nInput non valido, riprovare\n");
            }
        }
    }
    
    public static int Float(float a, float b) //chiede un input all'utente e verifica che sia un flaot compreso tra "a" e "b", altrimenti riprova
    {
        while (true){
            if (int.TryParse(Console.ReadLine(), out int output))
            {
                if (output >= a && output <= b)
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("\nInput non valido, riprovare\n");
                }
            }
            else
            {
                Console.WriteLine("\nInput non valido, riprovare\n");
            }
        }
    }


    public static double Double() //chiede un input all'utente e verifica che sia un double, altrimenti riprova
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double output))
            {
                return output;
            }
            else
            {
                Console.WriteLine("\nInput non valido, riprovare\n");
            }
        }
    }

    public static int Double(double a, double b) //chiede un input all'utente e verifica che sia un double compreso tra "a" e "b", altrimenti riprova
    {
        while (true){
            if (int.TryParse(Console.ReadLine(), out int output))
            {
                if (output >= a && output <= b)
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("\nInput non valido, riprovare\n");
                }
            }
            else
            {
                Console.WriteLine("\nInput non valido, riprovare\n");
            }
        }
    }

    public static string String() //chiede un input all'utente e verifica che sia una stringa, altrimenti riprova
    {
        while (true)
        {
            string? output = Console.ReadLine();
            if (!string.IsNullOrEmpty(output))
            {
                return output;
            }
            else
            {
                Console.WriteLine("\nInput non valido, riprovare\n");
            }
        }
    }

}

