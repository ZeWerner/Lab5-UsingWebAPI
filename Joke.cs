using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_API_Implementation
{
    internal class Joke
    {
        //public bool Error { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Setup { get; set; } = string.Empty;
        public string Delivery { get; set; } = string.Empty;
        public string joke { get; set; } = string.Empty;
        public FlagMeta Flags { get; set; } = new FlagMeta();
        
        public Joke() { }

        public Joke ( string category, string type, string setup, string delivery, FlagMeta flags)
        {
            //Error = error;
            Category = category;
            Type = type;
            Delivery = delivery;
            Flags = flags;
            Setup = setup;
        }

        public override string ToString()
        {
            string msg = "";
            if (Type == "twopart")
            {
                msg = $"{Setup}\n{Delivery}" +
                    $"\n\nThis joke should have been...\nA {Category} joke" +
                    $"\n{Flags}";
            }
            else
            {
                msg = $"{joke}" +
                    $"\n\nThis joke should have been...\nA {Category} joke" +
                    $"\n{Flags}";
            }
            return msg;
        }



    }
}
