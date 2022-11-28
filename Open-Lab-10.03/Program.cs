using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "Lord Of The Rings";
            LOTR.Author = "J.J.R.Tolkien";
            LOTR.Category = "epic high-fantasy novel";
            LOTR.Pages = 1172;
            LOTR.RelaseDate = "29th July 1954";

            LOTR.Vypis();
        }
    }
}
