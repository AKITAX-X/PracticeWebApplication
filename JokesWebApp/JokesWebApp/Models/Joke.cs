using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        //We made Properties to fill our ..
        public int Id { get; set; }
        public int JokeQuestion { get; set; }
        public int JokAnswer { get; set; }

        public Joke()
        {
               
        }

    }
}
