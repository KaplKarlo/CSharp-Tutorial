// See https://aka.ms/new-console-template for more information

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

//casting,parsiranje
string result = ((int.Parse(number) + int.Parse(valuta))/100).ToString();
Console.WriteLine("Cijena proizvoda je: " + result);



