
using System.Globalization;
using Microsoft.VisualBasic;

Console.WriteLine("du blir jagad av 7 poliser med din trimmade moppe på en motor väg och du komer framm till en korstning villken väg väljer du eller väljer du att stanna och morsan som drar in ditt fortnite konto");
string väg = Console.ReadLine();
string svar = Console.ReadLine();
if (väg ==  "höger")
{
Console.WriteLine("du kom undan");
Console.ReadLine();
}
else if (väg == "vänster")
{
Console.WriteLine("du blir på körd av 15 lastbilar och blir brutalt mördad ");
}
else if (väg == "stanna")
{
 Console.WriteLine("polisen stannar dig och frågar dig lite frågor dem frågar det är snällt att du stannar men frågan är är din mopped trimmad? ");   
Console.ReadLine();
}
if (svar == "ja")
{

    Console.WriteLine("bra att du talar saningen och vi komer inte böta dig eller nått men vi komer ta din moppe ");
Console.ReadLine();
}