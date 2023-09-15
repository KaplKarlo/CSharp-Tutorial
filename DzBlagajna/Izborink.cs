namespace Blagajna
{

    class Izbornik
    {
        private string
         odabir = "";

        Proizvod proizvod = new Proizvod();
        List<Proizvod> proizvodi = new List<Proizvod>();
        List<Proizvod> kosarica = new List<Proizvod>();

        public Izbornik()
        {
            napuniDefaultProizvode();
        }


        public void GlavniIzbornik()
        {
            ispisGlavnogIzbornika();

            //Odabir korisnika
            odabir = Console.ReadLine();

            switch (odabir)
            {
                case "1":
                    proizvod.dodajKosarici(proizvodi, kosarica);
                    break;
                case "2":
                    proizvod.pregledKošarice(kosarica);
                    break;
                case "3":
                    odabirDodavanjaProizvoda();
                    break;
                case "4":
                    proizvod.ispisProizvoda(proizvodi);
                    GlavniIzbornik();
                    break;
                case "0":
                    Console.WriteLine("===================================");
                    Console.WriteLine("DOVIĐENJA");
                    Console.WriteLine("===================================");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pogrešan unos pokušaj ponovo!");
                    GlavniIzbornik();
                    break;

            }
            GlavniIzbornik();

        }
        void ispisGlavnogIzbornika()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("GLAVNI IZBORNIK: ");
            Console.WriteLine("1.Kupnja proizvoda ");
            Console.WriteLine("2.Pregled košarice i plaćanje ");
            Console.WriteLine("3.Dodavanje proizvoda ");
            Console.WriteLine("4.Ispis proizvoda ");
            Console.WriteLine("0.Izlaz ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Upišite broj opcije za nastavak: ");

        }

        void odabirDodavanjaProizvoda()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("IZBORNIK DODAVANJE PROIZVODA: ");
            Console.WriteLine("1.Dodaj novi proizvod ");
            Console.WriteLine("2.Dodaj postojeći proizvod ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Upišite broj opcije za nastavak: ");
            odabir = Console.ReadLine();

            switch (odabir)
            {
                case "1":
                    proizvodi.Add(proizvod.dodajNoviProizvod());
                    Console.WriteLine("Dodavanje izvršeno.");
                    break;
                case "2":
                    proizvod.dodajPostjeciProizvod(proizvodi);
                    break;
                default:
                    Console.WriteLine("Pogrešan unos pokušaj ponovo!");
                    odabirDodavanjaProizvoda();
                    break;

            }
        }

        void napuniDefaultProizvode()
        {
            Proizvod proizvod1 = new Proizvod("Kruh", 3, 1.35);
            Proizvod proizvod2 = new Proizvod("Pecivo", 2, 0.47);
            Proizvod proizvod3 = new Proizvod("Jaja", 3, 1.6);
            Proizvod proizvod4 = new Proizvod("Mlijeko", 1, 0.98);
            Proizvod proizvod5 = new Proizvod("Maslac", 5, 2.42);

            proizvodi.Add(proizvod1);
            proizvodi.Add(proizvod2);
            proizvodi.Add(proizvod3);
            proizvodi.Add(proizvod4);
            proizvodi.Add(proizvod5);
        }
    }
}