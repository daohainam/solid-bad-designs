using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class Greeting
    {
        private Languages language;

        public Greeting(Languages language) { 
            this.language = language;
        }

        public void SayHi()
        {
            switch (language)
            {
                case Languages.English:
                    Console.WriteLine("Hi!");
                    break;
                case Languages.Norwegian:
                    Console.WriteLine("Hei!");
                    break;
                case Languages.Swedish:
                    Console.WriteLine("Hej!");
                    break;
                case Languages.Vietnamese:
                    Console.WriteLine("Xin chào!");
                    break;
            }
        }
    }

    public enum Languages
    {
        English,
        Norwegian,
        Swedish,
        Vietnamese
    }
}
