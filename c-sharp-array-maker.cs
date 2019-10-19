using System;

namespace arraymaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input list
			Console.WriteLine("Make Your Array");
			Console.WriteLine("Example:");
			Console.WriteLine("Yarn, Soup, High Treason");
			string words = Console.ReadLine();

            //Getting rid of extra spaces and commas
			words = words.TrimEnd();
			words = words.TrimEnd(',');
			//Console.WriteLine(words);

            //counting how many items are in the list
			int count = words.Split(',').Length;

            //makes the comma, space into quote, comma, quote, space
			string betterWords = words.Replace(", ", "\", \"");

            //Input language type
			Console.WriteLine("What language?");
            //skips 'um'
                goto language;

        // if the language inputted isn't a language
	    um:
			Console.WriteLine("um... what language?");

        //taking user input for the language, trimming any spaces and downcasing
        language:
			string lang = Console.ReadLine();
			lang = lang.Trim();
			lang = lang.ToLower();


            //if any of these languages are selected, then it will be translated
			    if (lang == "ruby" || lang == "javascript" || lang == "c#" || lang == "swift" || lang == "java" || lang == "c++" || lang == "python" || lang == "c")
			        { goto translate;}

                // if these are selected,,, sucks
                else if (lang == "SQL" || lang == "php")
			        { Console.WriteLine("Working on it...");
				      return;
			        }

                //if the language isn't recognized, it gets confuzzled and sad, and lets you try again! uwu xD kmn
			    else
			        { goto um;};

        //translations available
		translate:

			if (lang == "ruby")
			{
				Console.WriteLine($"array_name = [\"{betterWords}\"]");
			}

			else if (lang == "javascript" || lang == "swift")
				{
					Console.WriteLine($"var arrayName = [\"{betterWords}\"]");
				}

			else if (lang == "c#" || lang == "java")
				{
					Console.WriteLine($"arrayName = new string[{count}]{{\"{betterWords}\"}};");
				}

			else if (lang == "c++" || lang == "c")
			{
				Console.WriteLine($"string arrayName[{count}] = {{\"{betterWords}\"}};");
			}

			else if (lang == "python")
			{
				Console.WriteLine($"arrayName = [\"{betterWords}\"]");
			}
		}
    }
}
