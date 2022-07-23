using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06a.Helpers
{
   public static class InputHelper
    {

        public static string? Get(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

    }
}
