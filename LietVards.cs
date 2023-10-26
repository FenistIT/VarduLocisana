using MorfoServices;

namespace Morfologija
{
    public class LietVards : Vards
    {
        public LietVards(string nosaukums) : base(nosaukums)
        {
            if (String.IsNullOrEmpty(Galotne))
                throw new ArgumentException($" Ievadītājs vārds nav atbilst programmas specifikācijām ");

            switch (Galotne)
            {
                case "s":
                    Dzimtene = Dzimtene.Viriesu;
                    Skaitlis = Skaitlis.Vienskaitlis;
                    Deklinacija = new PirmaDeklinacija();
                    break;
                case "is":
                    Dzimtene = Dzimtene.Viriesu;
                    Skaitlis = Skaitlis.Vienskaitlis;
                    Deklinacija = new OtraDeklinacija();
                    break;
                case "us":
                    Dzimtene = Dzimtene.Viriesu;
                    Skaitlis = Skaitlis.Vienskaitlis;
                    Deklinacija = new TresaDeklinacija();
                    break;
                case "a":
                    Dzimtene = Dzimtene.Sieviesu;
                    Skaitlis = Skaitlis.Vienskaitlis;
                    Deklinacija = new CieturtaDeklinacija();
                    break;
                case "as":
                    Dzimtene = Dzimtene.Sieviesu;
                    Skaitlis = Skaitlis.Daudzskaitlis;
                    Deklinacija = new CieturtaDeklinacija();
                    break;
                case "e":
                    Dzimtene = Dzimtene.Sieviesu;
                    Skaitlis = Skaitlis.Vienskaitlis;
                    Deklinacija = new PiektaDeklinacija();
                    break;
                case "es":
                    Dzimtene = Dzimtene.Sieviesu;
                    Skaitlis = Skaitlis.Daudzskaitlis;
                    Deklinacija = new PiektaDeklinacija();
                    break;
                case "i":
                    Dzimtene = Dzimtene.Viriesu;
                    Skaitlis = Skaitlis.Daudzskaitlis;
                    Deklinacija = new PirmaDeklinacija();
                    break;
                default:
                    throw new ArgumentException($" Ievadītājs vārds nav atbilst programmas specifikācijām ");                    
            }
        }

        public Deklinacija Deklinacija { get; protected set; }
        

        public override void Locisana()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"             Lietvārdu \"{Nosaukums}\" {this.Deklinacija.Name} locīšana");
            Console.WriteLine("                 Vienskaitlis   Daudzskaitlis");
            foreach (Locijumi locijums in Enum.GetValues(typeof(Locijumi)))
            {
                if ( locijums != Locijumi.Dativs)
                    Console.WriteLine($"{locijums.GetDescription()}          {GetEnding(locijums, (Skaitlis)1)}          {GetEnding(locijums, (Skaitlis)2)} ");
                if (locijums == Locijumi.Dativs)
                    Console.WriteLine($"{locijums.GetDescription()}          {GetEnding(locijums, (Skaitlis)1)}         {GetEnding(locijums, (Skaitlis)2)} ");
            }
            
        }

        public string GetEnding(Locijumi locijums)
        {
             return Deklinacija.GetEnding(locijums,Skaitlis);
        }
        public string GetEnding(Locijumi locijums, Skaitlis skaitlis)
        {
            return Deklinacija.GetEnding(locijums, skaitlis);
        }
    }
}
