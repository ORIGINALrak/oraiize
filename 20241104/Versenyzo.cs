using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241104;

internal class Versenyzo
{
    public string Nev { get; set; }
    public int Szul { get; set; }
    public string Rajtszam { get; set; }
    public bool Nem { get; set; }
    public string Kategoria{ get; set; }
    public Dictionary<string, TimeSpan> Versenyidok { get; set; }

    public override string ToString() => $"[{Rajtszam}] {Nev} ({(Nem ? "férfi" : "nő")}, {Kategoria})";

    public int OsszIdoSec => (int)Versenyidok.Values.Sum(x => x.TotalSeconds);

    public Versenyzo(string sor)
    {
        string[] v = sor.Split(';');
        Nev = v[0];
        Szul = int.Parse(v[1]);
        Rajtszam = v[2];
        Nem = v[3] == "f";
        Kategoria = v[4];
        Versenyidok = new()
        {
            { "úszás",    TimeSpan.Parse(v[5])},
            { "I. depó",  TimeSpan.Parse(v[6])},
            { "kerékpár", TimeSpan.Parse(v[7])},
            { "II. depó", TimeSpan.Parse(v[8])},
            { "futás",    TimeSpan.Parse(v[9])},
        };
    }
}
