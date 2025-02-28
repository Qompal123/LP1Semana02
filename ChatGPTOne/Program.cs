using System;
using System.Net.Http.Headers;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {

            bool ext = true;

            while (ext)
            {

                string question, response;

                response = "";

                Console.Write("Place your question? ");
                question = Console.ReadLine();


                switch (question)
                {
                    case "How old are you?":
                        response = "I'm 10000 years old";
                        break;
                    case "What's your name?":
                        response = "World destoyer";
                        break;
                    case "Are you hungry?":
                        response = "YES";
                        break;
                    case "Are you more intelligent than me?":
                        response = "Obviously!";
                        break;
                    case "EXIT":
                        ext = false;
                        break;
                    default:
                        response = "You got me, I'm not THAT smart!";
                        break;


                }

                Console.WriteLine(response);
                
            }
        }
    }
}