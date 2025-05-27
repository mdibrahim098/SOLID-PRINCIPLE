using System;


namespace SRP
{
    public class MemberShip   // Class should solve only one responsible not multiple
    {
        public void Add()
        {
            try
            {
                // TO DO
            }
            catch (Exception ex)
            {
                FIleLogger.LogError(ex.Message);
            }

        }
    }
    public static class FIleLogger
    {
        public static void LogError(string message)
        {
             File.WriteAllText("An error occurred while adding a member.", message);
        }
    }


    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
        }
         
         
    }



}