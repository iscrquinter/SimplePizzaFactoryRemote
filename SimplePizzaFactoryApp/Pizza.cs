using System;

namespace pizzas
{

    abstract public class Pizza {
        string name;
        string dough;
        string sauce;

        public string getName() {
            return name;
        }

        public void prepare() {
            Console.WriteLine("Preparing " + name);
        }

        public void bake() {
            Console.WriteLine("Baking " + name);
        }

        public void cut() {
            Console.WriteLine("Cutting " + name);
        }

        public void box() {
            Console.WriteLine("Boxing " + name);
        }
    }

}