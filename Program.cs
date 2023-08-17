// See https://aka.ms/new-console-template for more information

using System.Reflection.Emit;
/*

//Prvo Predavanje

string hello = "Dobar dan";
string poruka = "Ovo je poruka";

Console.WriteLine(hello);
Console.WriteLine(poruka);
Console.OutputEncoding = System.Text.Encoding.UTF8;

//tip nazivVarijable = vrijednost
// int number = 120;
// double decimalNum = 3.14566;
// string valute = "$"
// Boolean truefalse = false;

String number = "120";
String  valuta = "180";

//Console.WriteLine(number.GetType());
//Console.WriteLine(valuta.GetType());

//Console.WriteLine(number + valuta);

// casting,parsiranje

string result = ((int.Parse(number) + int.Parse(valuta))/100).ToString();
Console.WriteLine("Cijena proizvoda je: " + result);

*/

//Drugo Predavanje

/*
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] posao =  new string[3] { "programer", "devOps", "dizajner",};

posao[0] = "frontend";

Person user = new Person("Karlo","Kapl",22,true,posao[0]);
Person user2 = new Person("Maja","Perić",22,false,posao[2]);


Console.WriteLine("==================================================");

Console.WriteLine("Ime i prezime: {0} {1}",user.ime , user.prezime);
Console.WriteLine("Dob:{0}",user.age);
Console.WriteLine("Spol:{0}",user.gender ? "Muško" : "Žensko");
Console.WriteLine("Posao:{0}",user.posao);

Console.WriteLine("==================================================");

Console.WriteLine("Ime i prezime: {0} {1}",user2.ime , user2.prezime);
Console.WriteLine("Dob:{0}",user2.age);
Console.WriteLine("Spol:{0}",user2.gender ? "Muško" : "Žensko");
Console.WriteLine("Posao:{0}",user2.posao);


Console.WriteLine("==================================================");


string[] tehnologija = new string[] { "LED","QLED","OLED"};

TV tv1 = new TV("Samsung",tehnologija[0],50,150,true);
TV tv2 = new TV("Grounding",tehnologija[1],54,180,true);
TV tv3 = new TV("Samsung",tehnologija[2],58,240,true);
TV tv4 = new TV("Sony",tehnologija[1],48,150,false);
TV tv5 = new TV("HISENSE ",tehnologija[0],54,220,true);

Console.WriteLine("==================================================");
Console.WriteLine("Marka: {0} ",tv1.marka);
Console.WriteLine("Tehnologija: {0} ",tv1.tehnologija);
Console.WriteLine("Dijagonala: {0} ",tv1.dijagonala);
Console.WriteLine("Cijena: {0} ",tv1.cijena);
Console.WriteLine("Smart: {0} ",tv1.smart ? "Smart" : "Nije Smart");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Marka: {0} ",tv2.marka);
Console.WriteLine("Tehnologija: {0} ",tv2.tehnologija);
Console.WriteLine("Dijagonala: {0} ",tv2.dijagonala);
Console.WriteLine("Cijena: {0} ",tv2.cijena);
Console.WriteLine("Smart: {0} ",tv2.smart ? "Smart" : "Nije Smart");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Marka: {0} ",tv3.marka);
Console.WriteLine("Tehnologija: {0} ",tv3.tehnologija);
Console.WriteLine("Dijagonala: {0} ",tv3.dijagonala);
Console.WriteLine("Cijena: {0} ",tv3.cijena);
Console.WriteLine("Smart: {0} ",tv3.smart ? "Smart" : "Nije Smart");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Marka: {0} ",tv4.marka);
Console.WriteLine("Tehnologija: {0} ",tv4.tehnologija);
Console.WriteLine("Dijagonala: {0} ",tv4.dijagonala);
Console.WriteLine("Cijena: {0} ",tv4.cijena);
Console.WriteLine("Smart: {0} ",tv4.smart ? "Smart" : "Nije Smart");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Marka: {0} ",tv5.marka);
Console.WriteLine("Tehnologija: {0} ",tv5.tehnologija);
Console.WriteLine("Dijagonala: {0} ",tv5.dijagonala);
Console.WriteLine("Cijena: {0} ",tv5.cijena);
Console.WriteLine("Smart: {0} ",tv5.smart ? "Smart" : "Nije Smart");
Console.WriteLine("==================================================");






class Person{
    public string ime = "Karlo";
    public string prezime = "Kapl";
    public int age = 22;
    public bool gender = true; // M true, Ž false
    public string posao;

    public Person(string ime,string prezime,int age, bool gender,string posao){
        this.ime = ime;
        this.prezime = prezime;
        this.age = age;
        this.gender = gender;
        this.posao = posao;
    }
}


//DZ klasa

class TV{
    public string marka;
    public string tehnologija;
    public int dijagonala;
    public double cijena;
    public bool smart;

    public TV(string marka,string tehnologija,int dijagonala,double cijena,bool smart){
        this.marka = marka;
        this.tehnologija=tehnologija;
        this.dijagonala=dijagonala;
        this.cijena = cijena;
        this.smart = smart;
    }

}

*/
/*
//trece Predavanje

int[]brojevi = new int[4] {2,4,6,8};
int[] drugiBrojevi = new int[4] {1,3,5,7};

Mnozenje rezultat = new Mnozenje();
//rezultat.kvadratiranje(brojevi);

Mnozenje drugiRezultat = new Mnozenje();
//drugiRezultat.kvadratiranje(drugiBrojevi);

class Mnozenje{
    public void kvadratiranje(int[] data){
        Console.WriteLine("POČETAK");
        foreach(int x in data){
            Console.WriteLine("Broj: " + x);
            Console.WriteLine(x*x);
        }
        Console.WriteLine("KRAJ");
    }
}

*/
List<Student> studenti = new List<Student>();

Student student1 = new Student("Karlo","Kapl","Računarstvo",55);
Student student2 = new Student("Pero","Peric","Ekonomija",44);
Student student3 = new Student("Mara","Maric","Psihologija",33);

studenti.Add(student1);
studenti.Add(student2);
studenti.Add(student3);

IspisStudenata ispisStudenata= new IspisStudenata();

ispisStudenata.ispisListeStudenata(studenti);



class Student{
    public string ime;
    public string prezime;
    public string smjer;
    public int ECTS;
    

    public Student(string ime,string prezime,string smjer,int ECTS){
        this.ime = ime;
        this.prezime = prezime;
        this.smjer = smjer;
        this.ECTS = ECTS;
    }
}

class IspisStudenata{
     public void ispisListeStudenata(List<Student> studenti){
        Console.WriteLine("==================================================");
        foreach(Student student in studenti){
            Console.WriteLine("Ime: " + student.ime);
            Console.WriteLine("Prezime: " + student.prezime);
            Console.WriteLine("Smjer: " + student.smjer);
            Console.WriteLine("ECTS bodovi: " + student.ECTS + "\n");
        }
        Console.WriteLine("==================================================");
    }
}

