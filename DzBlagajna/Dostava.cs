namespace Blagajna{
    interface IDostava{
        public string nacinDostave { get; set; }
        public DateTime datum{get; set; }

        public void Ispis();

    }

    class Postom : IDostava
    {
        public string nacinDostave { get; set; }="Dostava poštom";
        public string adresa { get; set; }
        public DateTime datum{get; set; }

        public Postom(){
            unosAdrese();
            generirajVrijeme();
        }

        public void unosAdrese(){
            Console.WriteLine("Unesite adresu za dostavu");
            this.adresa=Console.ReadLine();
            
        }

        public void Ispis(){
            Console.WriteLine("\n\n\n=============================================");
            Console.WriteLine("Način dostave: " + this.nacinDostave);
            Console.WriteLine("Adresa dostave " + this.adresa);
            Console.WriteLine("Paket će biti dostavljen nakon " + this.datum);
            Console.WriteLine("=============================================");
        }

        public void generirajVrijeme(){
            Random rnd = new Random();
            DateTime datumDostave=DateTime.Now;
            datumDostave.AddDays(rnd.Next(6));
            datumDostave.AddHours(rnd.Next(24));
            this.datum = datumDostave;
        }
    }

    class Kurir : IDostava
    {
        public string nacinDostave{ get; set; } ="Dostava poštom";
        public string adresa { get; set; }
        public DateTime datum{get; set; }

        public Kurir(){
            unosAdrese();
            generirajVrijeme();
        }

        public void unosAdrese(){
            Console.WriteLine("Unesite adresu za dostavu");
            this.adresa=Console.ReadLine();
            
        }
        public void generirajVrijeme(){
            Random rnd = new Random();
            DateTime datumDostave=DateTime.Now;
            datumDostave.AddDays(rnd.Next(6));
            datumDostave.AddHours(rnd.Next(24));
            this.datum = datumDostave;
        }
         public void Ispis(){
            Console.WriteLine("\n\n\n=============================================");
            Console.WriteLine("Način dostave: " + this.nacinDostave);
            Console.WriteLine("Adresa dostave " + this.adresa);
            Console.WriteLine("Paket će biti dostavljen nakon " + this.datum);
            Console.WriteLine("=============================================");
        }
    }
    class OsobnoPreuzimanje : IDostava
    {
        public string nacinDostave{ get; set; } ="Osobno Preuzimanje";
        public DateTime datum{get; set; }=DateTime.Now;

         public void Ispis(){
            Console.WriteLine("\n\n\n=============================================");
            Console.WriteLine("Način dostave: " + this.nacinDostave);
            Console.WriteLine("Paket mozete pokupiti u poslovnici");
            Console.WriteLine("=============================================");
        }
    }
}