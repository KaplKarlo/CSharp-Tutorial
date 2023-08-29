class Student
{
    public string ime;
    public string prezime;
    public string smjer;
    

    public Student(){

    }


    public Student(string ime, string prezime, string smjer)
    {
        this.ime = ime;
        this.prezime = prezime;
        this.smjer = smjer;
    }

    public Student UnosNovogStudenta()
    {
        Student student=new Student(
            ProvjeraUnosaStringa("Unesi ime studenta") , 
            ProvjeraUnosaStringa("Unesi prezime studenta") , 
            ProvjeraUnosaStringa("Unesi smjer studenta")
        );
        return student;
    }

    public void IspisListeStudenata(List<Student> studenti){
        foreach(Student student in studenti){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("IME: " + student.ime);
            Console.WriteLine("PREZIME: " + student.prezime);
            Console.WriteLine("SMJER: " + student.smjer);         
        }
        Console.WriteLine("---------------------------------");
    }


    public string ProvjeraUnosaStringa(string poruka)
    {
        bool running = true;
        string str;
        do
        {
            Console.WriteLine("\n**************************************");
            Console.WriteLine(poruka);
            str = Console.ReadLine();
            //Ako nema unosa prekini rad aplikacije 

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
}