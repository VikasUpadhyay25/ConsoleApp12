using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Player
    {
        public string name = "Vikas";               // parameter
        private int health = 50;

        public int getHealth()       // adding a method with getHealth function(because fun can access its private members) to access private parametre i.e health
        {
            return health;
        }

        public void setHealth(int h)         // adding a Method
        {
            health = h;
        }
    }
}
