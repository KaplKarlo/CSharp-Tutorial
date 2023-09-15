using System.Runtime.CompilerServices;

namespace Blagajna
{

    abstract class Placanje
    {

        public abstract double cijena { get; set; }
        public abstract double osnovica { get; set; }
        public abstract double pdv { get; set; }

        public void IspisRacuna()
        {
            Console.WriteLine("\n\n\n|========================|");
            Console.WriteLine("|| RAČUN: \t\t||");
            Console.WriteLine("||----------------------||");
            Console.WriteLine("||  Osnovica: {0:F2}\t||" ,osnovica);
            Console.WriteLine("||  PDV: {0:F2}\t\t||" ,pdv);
            Console.WriteLine("||----------------------||");
            Console.WriteLine("||  UKUPNO: {0:F2}\t||" ,cijena);
            Console.WriteLine("|========================|\n\n\n");
            Console.WriteLine("Pritisnite bliko koju tipku za povratak u izbornik...");
            Console.ReadKey();
        }

    }

    class Gotovina : Placanje
    {
        public override double cijena { get; set; }
        public override double osnovica { get; set; }
        public override double pdv { get; set; }

        public Gotovina(double cijena)
        {
            this.cijena = cijena;
            this.pdv = cijena * 0.25;
            this.osnovica = cijena - pdv;
        }

        

    }



    class Kartica : Placanje
    {
        public override double cijena { get; set; }
        public override double osnovica { get; set; }
        public override double pdv { get; set; }

        public Kartica(double cijena)
        {
            this.cijena = cijena;
            this.pdv = cijena * 0.25;
            this.osnovica = cijena - pdv;
        }
    }

    class Cekovno : Placanje
    {
        public override double cijena { get; set; }
        public override double osnovica { get; set; }
        public override double pdv { get; set; }

        public Cekovno(double cijena)
        {
            this.cijena = cijena;
            this.pdv = cijena * 0.25;
            this.osnovica = cijena - pdv;
        }
    }

}