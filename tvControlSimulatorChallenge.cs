using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool isYes = true;
            string userInput;
            int channel;
            do
            {
                for(channel = 1; channel < 10;)
                {
                    Console.WriteLine("You are watching channel : "+channel+"");
                    Console.Write("Do you want change tv channel?(yes, no): ");
                    userInput  = Console.ReadLine();
                    if(userInput == "yes" && isYes == true)
                    {
                        channel++;
                    }  
                    else
                    {
                        Console.WriteLine($"Enjoy watchig channel { channel}");
                        Console.WriteLine("==================================");
                        break;
                    }       
                }   
            }while (isYes); 
            {
                
            }
        }         
    }
}

