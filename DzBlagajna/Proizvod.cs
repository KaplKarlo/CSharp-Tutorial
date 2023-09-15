namespace Blagajna
{
    class Proizvod
    {
        public string naziv;
        public int kolicina { get; set; }

        public int komadaKosarica { get; set; }

        public double cijena;



        public Proizvod()
        {
            //Prazan konstruktor za pozivanje metoda
        }

        public Proizvod(string naziv, int kolicina, double cijena)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.cijena = cijena;
            this.komadaKosarica = 0;
        }

        public void ispisProizvoda(List<Proizvod> proizvodi)
        {
            Console.WriteLine("\n\n\n");
            foreach (Proizvod proizvod in proizvodi)
            {
                if (proizvod.kolicina > 0)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("NAZIV: " + proizvod.naziv);
                    Console.WriteLine("KOLIČINA: " + proizvod.kolicina);
                    Console.WriteLine("CIJENA: " + proizvod.cijena);
                }
            }
            Console.WriteLine("---------------------------------");
        }

        public Proizvod dodajNoviProizvod()
        {
            Proizvod proizvod = new Proizvod(
                ProvjeraUnosaStringa("\nUnesi naziv proizvoda: "),
                ProvjeraUnosaCijelogBroja("\nUnesi količinu: "),
                ProvjeraUnosaDecimalnogBroja("\nUnesi cijenu proizvoda: ")
            );
            return proizvod;
        }

        public void dodajPostjeciProizvod(List<Proizvod> proizvodi)
        {
            int brojac = 1;
            int odabir, kolicina;
            foreach (Proizvod proizvod in proizvodi)
            {
                Console.WriteLine(brojac + ". " + proizvod.naziv);
                brojac++;
            }
            Console.WriteLine("0. Povratak u izbornik");
            do
            {
                odabir = ProvjeraUnosaCijelogBroja("Unesi broj ispred proizvoda za odabir ili 0 za povratak: ");
            } while (odabir < 0 || odabir > proizvodi.Count());

            if (odabir == 0)
            {
                return;
            }

            kolicina = ProvjeraUnosaCijelogBroja("Unesi kolicinu za dodavanje");
            proizvodi[odabir - 1].kolicina += kolicina;
            Console.WriteLine("Dodavanje izvršeno.");

        }

        public void dodajKosarici(List<Proizvod> proizvodi, List<Proizvod> kosarica)
        {
            int brojac = 1;
            int odabir, kolicina;
            Console.WriteLine("\n---------------------------------");

            int krajListe = proizvodi.Count();

            for (int i = 0; i < krajListe; i++)
            {
                if (proizvodi[i].kolicina > 0)
                {
                    Console.WriteLine(brojac + ". " + proizvodi[i].naziv + "  (Dostupno: " + proizvodi[i].kolicina + ")");
                    brojac++;
                }
                else
                {
                    proizvodi.Add(proizvodi[i]);
                    proizvodi.RemoveAt(i);
                    i--;
                    krajListe--;
                }
            }


            Console.WriteLine("0. Povratak u izbornik");
            Console.WriteLine("---------------------------------");
            do
            {
                odabir = ProvjeraUnosaCijelogBroja("Unesi broj ispred proizvoda za dodavanje u košaricu ili 0 za povratak: ");
            } while (odabir < 0 || odabir > proizvodi.Count());

            if (odabir == 0)
            {
                return;
            }

            kolicina = ProvjeraUnosaCijelogBroja("Unesi kolicinu za dodavanje u kosaricu");
            if (proizvodi[odabir - 1].kolicina < kolicina)
            {
                Console.WriteLine("\n\nNema dovoljno proizvoda.\nDostupno proizvoda: " + proizvodi[odabir - 1].kolicina);
                dodajKosarici(proizvodi, kosarica);
            }
            else
            {
                int index = odabir - 1;
                Proizvod proizvod = proizvodi[index];
                proizvod.kolicina -= kolicina;

                proizvod.komadaKosarica = kolicina;

                kosarica.Add(proizvod);

                dodajKosarici(proizvodi, kosarica);
            }


        }

        public void pregledKošarice(List<Proizvod> kosarica)
        {
            double cijena = 0;
            Console.WriteLine("=================================");
            foreach (Proizvod proizvod in kosarica)
            {

                Console.WriteLine("NAZIV: " + proizvod.naziv);
                Console.WriteLine("KOLIČINA: " + proizvod.komadaKosarica);
                Console.WriteLine("CIJENA: " + proizvod.cijena + " X " + proizvod.komadaKosarica + " => " + proizvod.cijena * proizvod.komadaKosarica);
                Console.WriteLine("---------------------------------");
                cijena += proizvod.cijena * proizvod.komadaKosarica;
            }


            Console.WriteLine("UKUPNA CIJENA: " + cijena);

            if (odabirPlacanja(cijena))
            {
                kosarica.Clear();
            }

        }

        public bool odabirPlacanja(double cijena)
        {
            int odabir;
            Console.WriteLine("\n\n=================================");
            Console.WriteLine("ODABIR NACINA PLACANJA: ");
            Console.WriteLine("=================================");
            Console.WriteLine("1.Placanje gotovinom");
            Console.WriteLine("2.Placanje karticom");
            Console.WriteLine("3.Placanje čekom");
            Console.WriteLine("0.Povratak u izbornik");
            Console.WriteLine("=================================");


            do
            {
                odabir = ProvjeraUnosaCijelogBroja("Unesi broj ispred opcije za odabir ili 0 za povratak: ");
            } while (odabir < 0 || odabir > 3);

            switch (odabir)
            {
                case 1:
                    if (OdabirDostave())
                    {
                        Gotovina gotovina = new Gotovina(cijena);
                        gotovina.IspisRacuna();
                        return true;
                    }
                    return false;
                case 2:
                    if (OdabirDostave())
                    {
                        Kartica kartica = new Kartica(cijena);
                        kartica.IspisRacuna();
                        return true;
                    }
                    return false;
                case 3:
                    if (OdabirDostave())
                    {
                        Cekovno cekovno = new Cekovno(cijena);
                        cekovno.IspisRacuna();
                        return true;
                    }
                    return false;
                case 0:
                    return false;
            }

            return false;



        }

        public bool OdabirDostave()
        {
            int odabir;
            Console.WriteLine("\n\n=================================");
            Console.WriteLine("ODABIR DOSTAVE: ");
            Console.WriteLine("=================================");
            Console.WriteLine("1.Osobno preuzimanje");
            Console.WriteLine("2.Dostava poštom");
            Console.WriteLine("3.Dostava kurirskom službom");
            Console.WriteLine("0.Povratak u izbornik");
            Console.WriteLine("=================================");


            do
            {
                odabir = ProvjeraUnosaCijelogBroja("Unesi broj ispred opcije za odabir ili 0 za povratak: ");
            } while (odabir < 0 || odabir > 3);

            switch (odabir)
            {
                case 1:
                    OsobnoPreuzimanje osobno = new OsobnoPreuzimanje();
                    osobno.Ispis();
                    return true;
                case 2:
                    Postom postom = new Postom();
                    postom.Ispis();
                    return true;
                case 3:
                    Kurir kurir = new Kurir();
                    kurir.Ispis();
                    return true;
                case 0:
                    return false;
            }

            return false;


        }



        public string ProvjeraUnosaStringa(string poruka)
        {
            bool running = true;
            string str;
            do
            {
                Console.WriteLine(poruka);
                str = Console.ReadLine();

                if (str == null || str == "")
                {
                    Console.WriteLine("Greška!\nNepodržan unos \nPokušajte ponovo");
                }
                else
                {
                    running = false;
                }
            } while (running);
            return str;
        }

        public int ProvjeraUnosaCijelogBroja(string poruka)
        {
            int broj;
            Console.WriteLine(poruka);
            while (!int.TryParse(Console.ReadLine(), out broj))
            {
                Console.WriteLine("Nepodrzan unos pokušaj ponovo!");
                Console.WriteLine(poruka);
            }
            return broj;
        }

        public double ProvjeraUnosaDecimalnogBroja(string poruka)
        {
            double broj;
            Console.WriteLine(poruka);
            while (!double.TryParse(Console.ReadLine(), out broj))
            {
                Console.WriteLine("Nepodrzan unos pokušaj ponovo!");
                Console.WriteLine(poruka);
            }
            return broj;
        }

    }
}