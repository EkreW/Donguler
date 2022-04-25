using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Custumer custumer = new Custumer { Id=1, FirtName = "Ekrem", LastName="Güngör", City= "İstanbul"};

            Custumer custumer2 = new Custumer(2, "Mustafa", "Morkoç", "İstanbul");


        }
       
    }
    class Custumer
    {
        public Custumer()
        {

        }
        //default constuctor
        public Custumer(int id, string firtName, string lastName, string city)
        {
            Console.WriteLine("Başarılı");
        }
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

}
