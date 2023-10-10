using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_API_Implementation
{
    internal class FlagMeta
    {
        public bool Nsfw { get; set; } 
        public bool Religious { get; set; } 
        public bool Political { get; set; } 
        public bool Racist { get; set; } 
        public bool Sexist { get; set; } 
        public bool Explicit { get; set; } 

        public FlagMeta() { }

        public FlagMeta(bool nsfw, bool religious, bool political, bool racist, bool sexist, bool @explicit)
        {
            Nsfw = nsfw;
            Religious = religious;
            Political = political;
            Racist = racist;
            Sexist = sexist;
            Explicit = @explicit;
        }

        public override string ToString()
        {
            string msg = $"Nsfw: {Nsfw}\n" +
                $"Religious: {Religious}\n" +
                $"Political: {Political}\n" +
                $"Racist: {Racist}\n" +
                $"Sexist: {Sexist}\n" +
                $"Explicit {Explicit}";
            return msg;
        }
    }
}
