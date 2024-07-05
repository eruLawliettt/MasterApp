using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MasterApp
{
    public class Beer
    {
        private int Id {  get; init; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        

        public Beer(int id,string title,decimal price)
        {
           Id = id;
           Title = title;
           Price = price;
        }
        public override string ToString()
        {
            return $"ЕЕ я Дима Негодненко и я купил пиво {Title} за {Price } рублей";
        }
    }
  
}
