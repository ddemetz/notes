using System;

namespace arraymaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Heads up
            Console.WriteLine("Hey uhh if u make a mistake, type BACK");
            Console.WriteLine("");




// Naming the array
        naming:
            //Name your array + get rid of any spaces at the end
            Console.WriteLine("What's the name of your array?");
            string name = Console.ReadLine();
            name = name.TrimEnd();

            //if the array has a space it'll become an underscore
            name = name.Replace(" ", "_");




// Filling the array

        array:
            //Input list
            Console.WriteLine("");
            Console.WriteLine("Make Your Array");
            Console.WriteLine($"{name}:");
            string words = Console.ReadLine();

            //If you mess up the name
            if (words.ToLower() == "back")
                goto naming;

            //if you use commas, fantastic, you should. if not, i save the day
            int count = words.Split(',').Length - 1;

            if (count == 0)
                words = words.Replace(" ", ",");

            //Getting rid of extra spaces and commas
            words = words.Replace(" ", "");
            words = words.TrimEnd(',');
            //Console.WriteLine(words);

            //counting how many items are in the list
            count = words.Split(',').Length;

            //formatting
			string betterWords = words.Replace(",", "\", \"");




// Language ask

            //Input language type
            Console.WriteLine("");
            Console.WriteLine("What language?");

            //If you mess up the array
            if (name.ToLower() == "back")
                goto array;

            //skips 'um'
            goto language;

        // if the language inputted isn't a language
        um:
			Console.WriteLine("um... what language? (say HELP if you want a list)");

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
			        {
                Console.WriteLine("");
                Console.WriteLine("Working on it...");
				      return;
			        }

                // because people like to make jokes
                 else if (lang == "english" || lang == "french" || lang == "spanish" || lang == "italian" || lang == "tagalog")
            {
                Console.WriteLine("");
                Console.WriteLine("please,,,a coding language,,,i beg of you");
                goto language;
            }


            // gives a list of languages
            else if (lang == "help")
            {
                Console.WriteLine("");
                Console.WriteLine("C, C#, C++, Java, Javascript, Python, Ruby, Swift");
                Console.WriteLine("Language:");
                lang = Console.ReadLine();
                goto translate;
            }

            // ends goto
            else if (lang.ToLower() == "end")
            {
                return;
            }

            else if (lang.ToLower() == "back")
            {
                goto array;
            }

            //if the language isn't recognized, it gets confuzzled and sad, and lets you try again! uwu xD kmn
            else
			        { goto um;}




// Translating

        //translations available
		translate:

			if (lang == "ruby")
			{
                Console.WriteLine("");
                Console.WriteLine($"{name} = [\"{betterWords}\"]");
			}

			else if (lang == "javascript" || lang == "swift")
				{
                Console.WriteLine("");
                Console.WriteLine($"var {name} = [\"{betterWords}\"]");
				}

			else if (lang == "c#" || lang == "java")
				{
                Console.WriteLine("");
                Console.WriteLine($"{name} = new string[{count}]{{\"{betterWords}\"}};");
				}

			else if (lang == "c++" || lang == "c")
			{
                Console.WriteLine("");
                Console.WriteLine($"string {name}[{count}] = {{\"{betterWords}\"}};");
			}

			else if (lang == "python")
			{
                Console.WriteLine("");
                Console.WriteLine($"{name} = [\"{betterWords}\"]");
			}

            //Translate into a different language without having to redo the array
            Console.WriteLine("");
            Console.WriteLine("Another Language? Which one? (or END)");
            goto language;

        }
    }
}
