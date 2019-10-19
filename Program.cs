using System;

namespace arraymaker
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Make Your Array");
			Console.WriteLine("Example:");
			Console.WriteLine("Yarn, Soup, High Treason");
			string words = Console.ReadLine();
			words = words.TrimEnd();
			words = words.TrimEnd(',');
			//Console.WriteLine(words);

			int count = words.Split(',').Length;

			string betterWords = words.Replace(", ", "\", \"");
			Console.WriteLine("What language?");
                goto um;
	    language:
			Console.WriteLine("um... what language?");
        um:
			string lang = Console.ReadLine();
			lang = lang.TrimEnd();
			lang = lang.ToLower();


			    if (lang == "ruby" || lang == "javascript" || lang == "c#" || lang == "swift" || lang == "java" || lang == "c++" || lang == "python" || lang == "c")
			{ goto translate;}
                else if (lang == "SQL" || lang == "php")
			        { Console.WriteLine("Working on it...");
				      return;
			        }
			    else
			        { goto language;};

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
				    //int arraySize = 5;
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
