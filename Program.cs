
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
    int alapar = Convert.ToInt32(adatok[2]);
    if (string.IsNullOrWhiteSpace(tipus) || string.IsNullOrWhiteSpace(rendszam) || string.IsNullOrWhiteSpace(Convert.ToString( alapar)))
    {
        HibasSorokSzama++;
        continue;
    }
    if (tipus != "J" || tipus != "T")
    {
        HibasSorokSzama++;
        continue;
    }
    if(tipus == "T")
    {
       teherauto teherauto = new teherauto(Convert.ToDouble(adatok[3]),rendszam, alapar);
       Lista.Add(teherauto);
    }
    if (tipus == "J")
    {
        Jarmu jarmu = new Jarmu(rendszam, alapar);
        Lista.Add(jarmu);
    }
}

Console.WriteLine("sikeresen beolvasott Jarmuvek szama: " + Lista.Count);
foreach (var i in Lista)
{
    i.ToString();
}
//Console.WriteLine("a floatta osszesitett adoja:" + Lista.Sum(j => j.Adokalkulacio())); ?

Console.WriteLine("jarmuvek szama: " + Jarmu.OsszesJarmuSzama);

