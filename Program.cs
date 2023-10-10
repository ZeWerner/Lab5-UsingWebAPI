using System.Text.Json;

namespace Lab5_API_Implementation
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await JokeCall();
        }

        public static async Task JokeCall()
        {
            string urlStart = "https://v2.jokeapi.dev/joke/";
            List<string> userCategory = new List<string>();
            
            List<string> userFlags = new List<string>();
            string amount = "";
            bool exitCheck = true;
            List<string> Categories = new List<string>() {"1) Any","2) Programming", "3) Miscellaneous", "4) Dark", "5) Pun", "6) Spooky", "7) Christmas", "8) Exit selection" };
            List<string> Filters = new List<string>() { "1) Nsfw", "2) Religious", "3) Political", "4) Racist", "5) Sexist", "6) Explicit", "7) Nah I'm good fr fr" };
            

            while (exitCheck)
            {
                Console.WriteLine("Which of the following categories of jokes do you want?");
                foreach (string category in Categories)
                {
                    Console.WriteLine(category);
                }
                
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        userCategory.Add("Any");
                        exitCheck = false;
                        break;

                    case "2":
                        if (userCategory.Contains("Programming"))
                        {
                            Console.WriteLine("Filter already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userCategory.Add("Programming");
                            
                            Categories[Categories.IndexOf("2) Programming")] = "2) Programming SELECTED";
                            
                            Console.Clear();
                            break;
                        }

                    case "3":
                        if (userCategory.Contains("Misc"))
                        {
                            Console.WriteLine("Filter already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userCategory.Add("Misc");
                            Categories[Categories.IndexOf("3) Miscellaneous")] = "3) Miscellaneous SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "4":
                        if (userCategory.Contains("Dark"))
                        {
                            Console.WriteLine("Filter already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userCategory.Add("Dark");
                            Categories[Categories.IndexOf("4) Dark")] = "4) Dark SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "5":
                        if (userCategory.Contains("Pun"))
                        {
                            Console.WriteLine("Filter already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userCategory.Add("Pun");
                            Categories[Categories.IndexOf("5) Pun")] = "5) Pun SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "6":
                        if (userCategory.Contains("Spooky"))
                        {
                            Console.WriteLine("Filter already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userCategory.Add("Spooky");
                            Categories[Categories.IndexOf("6) Spooky")] = "6) Spooky SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "7":
                        if (userCategory.Contains("Christmas"))
                        {
                            Console.WriteLine("Filter already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userCategory.Add("Christmas");
                            Categories[Categories.IndexOf("7) Christmas")] = "7) Christmas SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "8":
                        if(userCategory.Count() == 0)
                        {
                            userCategory.Add("Any");
                        }
                        exitCheck = false;
                        break;

                    default:
                        Console.WriteLine("Error, please enter a valid option");
                        Console.ReadLine();
                        break;
                }
            }

            string cat = "";
            for(int i = 0; i < userCategory.Count; i++)
            {
                if(i != userCategory.Count - 1)
                {
                    cat += $"{userCategory[i]},";
                }
                else
                {
                    cat += $"{userCategory[i]}?";
                }
                
            }
            Console.Clear();

            exitCheck = true;
            while (exitCheck)
            {
                Console.WriteLine("Would you like to blacklist any types of jokes?");
                foreach(var filter in Filters)
                {
                    Console.WriteLine(filter);
                }
                
                string input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        if (userFlags.Contains("nsfw"))
                        {
                            Console.WriteLine("Flag already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userFlags.Add("nsfw");

                            Filters[Filters.IndexOf("1) Nsfw")] = "1) Nsfw SELECTED";

                            Console.Clear();
                            break;
                        }

                    case "2":
                        if (userFlags.Contains("religious"))
                        {
                            Console.WriteLine("Flag already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userFlags.Add("religious");
                            Filters[Filters.IndexOf("2) Religious")] = "2) Religious SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "3":
                        if (userFlags.Contains("political"))
                        {
                            Console.WriteLine("Flag already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userFlags.Add("political");
                            Filters[Filters.IndexOf("3) Political")] = "3) Political SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "4":
                        if (userFlags.Contains("racist"))
                        {
                            Console.WriteLine("Flag already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userFlags.Add("racist");
                            Filters[Filters.IndexOf("4) Racist")] = "4) Racist SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "5":
                        if (userFlags.Contains("sexist"))
                        {
                            Console.WriteLine("Flag already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userFlags.Add("sexist");
                            Filters[Filters.IndexOf("5) Sexist")] = "5) Sexist SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "6":
                        if (userFlags.Contains("explicit"))
                        {
                            Console.WriteLine("Flag already selected, press enter to select another");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            userFlags.Add("explicit");
                            Filters[Filters.IndexOf("6) Explicit")] = "6) Explicit SELECTED";
                            Console.Clear();
                            break;
                        }

                    case "7":
                        exitCheck = false;
                        break;

                    default:
                        Console.WriteLine("Error, please enter a valid option");
                        Console.ReadLine();
                        break;
                }
            }


            string flag = "";
            if (userFlags.Count > 0)
            {
                flag += "blacklistFlags=";

                for (int i = 0; i < userFlags.Count; i++)
                {

                    if (i != userFlags.Count - 1)
                    {
                        flag += $"{userFlags[i]},";
                    }
                    else
                    {
                        flag += $"{userFlags[i]}&";
                    }

                }
            }
            Console.Clear();

            
            Console.WriteLine("How many jokes you want fool?");
            string jokeNum = Console.ReadLine();

            while(string.IsNullOrEmpty(jokeNum) || int.TryParse(jokeNum, out int num) == false || Convert.ToInt32(jokeNum) <= 0 || Convert.ToInt32(jokeNum) > 1368)
            {
                Console.WriteLine("Please enter a valid number of jokes");
                jokeNum = Console.ReadLine();
            }
            
            int jokeNumAsNum = Convert.ToInt32(jokeNum);

            //https://v2.jokeapi.dev/joke/Any?blacklistFlags=religious,political&type=twopart

            

            if(jokeNumAsNum >  1)
            {
                amount = $"&amount={jokeNumAsNum}";
            }
            Console.WriteLine($"{urlStart}{cat}{flag}type=twopart{amount}");

            var client = new HttpClient();

            for (int i = 0; i < jokeNumAsNum; i++)
            {
                HttpResponseMessage response = await client.GetAsync($"{urlStart}{cat}{flag}type=twopart");
                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

                Joke j = JsonSerializer.Deserialize<Joke>(json, options);

                Console.WriteLine(j + "\n");
            }

        }





    }
}