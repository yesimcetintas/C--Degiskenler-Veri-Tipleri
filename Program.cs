// See https://aka.ms/new-console-template for more information
DateTime dt = DateTime.Now;
Console.WriteLine(dt);

// string ifadeler

string str1 = string.Empty;
str1="Yeşim Çetintaş";

string name = "Yeşim";
string surname = "Çetintaş";
string fullName = name + " " + surname;
Console.WriteLine(fullName);

// integer tanımlama şekilleri

int int1 = 10;
int int2 = 20;
int int3 = int1 * int2;

bool b1 = 10<2;
Console.WriteLine(b1);

// değişken dönüşümleri

string str20 = "20";
int int20 = 20;

string newValue = str20 + int20.ToString();
Console.WriteLine(newValue);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22);

// datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);
