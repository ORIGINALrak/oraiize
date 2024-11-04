using _20241104;
using System.Net.WebSockets;
using System.Text;

List<Versenyzo> versenyzok = new List<Versenyzo>();

using StreamReader sr = new("..\\..\\..\\src\\forras.txt", Encoding.UTF8);
while(!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"versenyzok száma: {versenyzok.Count}");

var f1 = versenyzok.Count(v => v.Kategoria == "elit");
Console.WriteLine($"versenyzok szama elit kategoriaban: {f1}");

var f2 = versenyzok.Where(v => !v.Nem).Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"noi versenyzok atlageletkora {f2:0.00}");

var f3 = versenyzok.Sum(v => v.Versenyidok["kerékpár"].TotalHours);
Console.WriteLine($"kerekparozassal toltott osszido: {f3:0.00} ora");

var f4 = versenyzok.Where(v => v.Kategoria  == "elit junior").Average(v => v.Versenyidok["úszás"].TotalMinutes);
Console.WriteLine($"elit juniurok atlagos uszasi ideje: {f4:0.00} perc");

var f5 = versenyzok.Where(v => v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"ferfi gyoztes {f5}");

var f6 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(v => v.Key);
Console.WriteLine("versenyt befejezok szama: ");
foreach(var grp in f6)
{
    Console.WriteLine($"{grp.Key,11}: {grp.Count(),2} fo  avg depo: {grp.Average(v => v.Versenyidok["I. depó"].TotalSeconds):00.000} sec   {grp.Average(v => v.Versenyidok["II. depó"].TotalSeconds):00.000} sec");
}

var f7 = versenyzok.Count(v => v.Kategoria == "elit junior");
Console.WriteLine($"versenyzok szama elit junior kategoriaban: {f7}");

var f8 = versenyzok.Where(v => v.Nem).Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"ferfi versenyzok atlageletkora {f8:0.00}");

var f9 = versenyzok.Sum(v => v.Versenyidok["futás"].TotalHours);
Console.WriteLine($"futás toltott osszido: {f9:0.00} ora");

var f10 = versenyzok.Where(v => v.Kategoria == "20-24").Average(v => v.Versenyidok["úszás"].TotalMinutes);
Console.WriteLine($"20-24 es kategoriaban az atlagos uszasi ido: {f10:0.00} perc");

var f11 = versenyzok.Where(v => !v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"noi gyoztes {f11}");

var f12 = versenyzok.GroupBy(v => v.Nem).OrderBy(v => v.Key);
Console.WriteLine("versenyt befejezok szama: ");
foreach (var grp in f12)
{
    Console.WriteLine($"{(grp.Key ? "férfi" : "nő"), 5}: {grp.Count(),2} fo  avg depo: {grp.Average(v => v.Versenyidok["I. depó"].TotalSeconds):00.000} sec   {grp.Average(v => v.Versenyidok["II. depó"].TotalSeconds):00.000} sec");
}

var f13 = versenyzok.Count(v => v.Kategoria == "25-29");
Console.WriteLine($"versenyzok szama elit kategoriaban: {f13}");

var f14 = versenyzok.Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"versenyzok atlageletkora {f14:0.00}");

var f15 = versenyzok.Sum(v => v.Versenyidok["úszás"].TotalHours);
Console.WriteLine($"úszás toltott osszido: {f15:0.00} ora");

var f16 = versenyzok.Where(v => v.Kategoria == "elit").Average(v => v.Versenyidok["úszás"].TotalMinutes);
Console.WriteLine($"elit kategoriaban az atlagos uszasi ido: {f16:0.00} perc");

var f17 = versenyzok.Where(v => v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"ferfi gyoztes {f17}");

var f18 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(v => v.Key);
Console.WriteLine("versenyt befejezok szama: ");
foreach (var grp in f18)
{
    Console.WriteLine($"{grp.Key,11}: {grp.Count(),2} fo  avg depo: {grp.Average(v => v.Versenyidok["I. depó"].TotalSeconds):00.000} sec   {grp.Average(v => v.Versenyidok["II. depó"].TotalSeconds):00.000} sec");
}
