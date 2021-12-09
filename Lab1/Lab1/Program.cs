using System;

namespace Lab1
{
    class Fabric
    {
        string name;
        string address;
        string product;
        int workers;

        private string numberOfBank;

        public Fabric()         //По умолчанию коснтруктор
        {
            this.name = "noname";
            this.address = "noname";
            this.product = "noname";
            this.workers = 0;
            this.numberOfBank = "0028923";
        }
        public Fabric (string name, string addres, string product, int workers)     // с параметрами 
        {
            this.name = name;
            this.address = addres;
            this.product = product;
            this.workers = workers;
        }
        public Fabric (string name, string addres, string product)  // тоже с параметрами но один заполняется но одно поле заполняется по умолчанию
        {
            this.name = name;
            this.address = addres;
            this.product = product;
            this.workers = 0;
        }
        public Fabric(string name, string product, int workers)     //то же самое что и предыдущий 
        {
            this.name = name;
            this.address = "noname";
            this.product = product;
            this.workers = workers;
        }
        ~Fabric()       // деструктор
        {
            this.name = null;
            this.address = null;
            this.product = null;
            this.workers = 0;
        }

        public void output()    // вывод всех полей 
        {
            Console.WriteLine(this.name + "\n" + this.address + "\n" + this.product + "\n" + this.workers + "\n" + this.numberOfBank);
        }
        public void input(string name, string addres, string product, int workers)
        {
            this.name = name;
            this.address = addres;
            this.product = product;
            this.workers = workers;
        }

        public bool renameFabric(int couterChars)
        {
            generateName(couterChars);
            return false;
        }
        private bool generateName(int count)
        {
            string newName = "";
            for (int i = 0; i < count; i++)
            {
                Random rnd = new Random();
                newName += (char)rnd.Next(97, 122); 
            }
            this.name = newName;

            return true;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Fabric fab1 = new Fabric();
            fab1.output();
            Console.WriteLine("\n\n");
            fab1.input("Krona", "prospect Pobed", "mkfdkslf", 30);
            fab1.output();
            Console.WriteLine("\n\n");
            fab1.renameFabric(7);
            fab1.output();
            Console.WriteLine("\n\n");
        }
    }
}
