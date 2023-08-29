namespace DzIzbornik
{
    class GlavniIzbornik
    {
        //lista za spremanje studenata
        List<Student> studenti = new List<Student>();

        Student student = new Student();
        public GlavniIzbornik()
        {
            //Dodavanje default studeata
            Student student1 = new Student("Karlo", "Kapl", "Računarstvo");
            Student student2 = new Student("Pero", "Peric", "Ekonomija");
            Student student3 = new Student("Mara", "Maric", "Psihologija");

            studenti.Add(student1);
            studenti.Add(student2);
            studenti.Add(student3);

        }
        public void ISpisiGlavniIzbornik()
        {
            bool running = true;
            do
            {
                //Izbornik
                Console.WriteLine("===================================");
                Console.WriteLine("1.Unos novog studenta");
                Console.WriteLine("2.Popis studenata");
                Console.WriteLine("3.Izlaz");
                Console.WriteLine("\nUpišite broj opcije za nastavak: ");

                //Odabir korisnika
                string key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);

                if (choice == 1)
                {
                    Console.WriteLine("\nOdabrali ste unos novog studenta");
                    student = student.UnosNovogStudenta();
                    studenti.Add(student);
                    running = false;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nOdabrali ste ispis popisa studenata.");
                    student.IspisListeStudenata(studenti);
                    running = false;
                }
                else if (choice == 3)
                {
                    Console.WriteLine("===================================");
                    Console.WriteLine("DOVIĐENJA");
                    Console.WriteLine("===================================");
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Nedozvoljeni unos! \nProbajte Ponovo.");
                }
            } while (running);
            ISpisiGlavniIzbornik();
        }

        public void PozdravnaPoruka()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("DOBRODOŠLI");
        }
    }
}