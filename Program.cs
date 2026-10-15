
using FlottaApp;

int HibasSorokSzama = 0;

List<Jarmu> Lista = new List<Jarmu>();


foreach (string sor in File.ReadLines("jarmuvek.csv").Skip(1))
{
    string[] adatok = sor.Split(";");
    if (adatok.Length != 4)
    {
        HibasSorokSzama++;
        continue;
    }
    string tipus = adatok[0].Trim();
    string rendszam = adatok[1].Trim();
    if (!int.TryParse(adatok[2], out int pontszam))
    {
        HibasSorokSzama++;
        continue;
    }
    int alapar = Convert.ToInt16( adatok[2].Trim());
    if (string.IsNullOrWhiteSpace(tipus) || string.IsNullOrWhiteSpace(rendszam) || string.IsNullOrWhiteSpace(Convert.ToString( alapar)))
    {
        HibasSorokSzama++;
        continue;
    }
    if (tipus == "J" || tipus == "T")
    {
        HibasSorokSzama++;
        continue;
    }
    Lista.Add(new Jarmu(rendszam,alapar));
}