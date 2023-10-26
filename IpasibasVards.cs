using MorfoServices;

namespace Morfologija
{
    public class IpasibasVards:Vards
    {
        public IpasibasVards(string nosaukums) : base(nosaukums)
        {
        }             

        public IpasibasGalotne IpasibasGalotne { get;  set; }

        public override void Locisana()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"                                  Īpašības vārdu \"{Nosaukums}\" locīšana");
            Console.WriteLine("                       Vienskaitlis                    Daudzskaitlis");
            Console.WriteLine("               Vīriešu dzimt.  Sieviešu dzimt.   Vīriešu dzimt.  Sieviešu dzimt.");
            foreach (Locijumi locijums in Enum.GetValues(typeof(Locijumi)))
            {
                if(locijums!=Locijumi.Vokativs && locijums != Locijumi.Dativs)
                    Console.WriteLine($"{locijums.GetDescription()}      {GetEnding(locijums, (Dzimtene)1, (Skaitlis)1)}             {GetEnding(locijums, (Dzimtene)2, (Skaitlis)1)}                 {GetEnding(locijums, (Dzimtene)1, (Skaitlis)2)}                   {GetEnding(locijums, (Dzimtene)2, (Skaitlis)2)}  ");
                if (locijums == Locijumi.Dativs)
                    Console.WriteLine($"{locijums.GetDescription()}      {GetEnding(locijums, (Dzimtene)1, (Skaitlis)1)}            {GetEnding(locijums, (Dzimtene)2, (Skaitlis)1)}                {GetEnding(locijums, (Dzimtene)1, (Skaitlis)2)}                 {GetEnding(locijums, (Dzimtene)2, (Skaitlis)2)}  ");
            }
        }

        public string GetEnding(Locijumi locijums,Dzimtene dzimtene, Skaitlis skaitlis)
        {
            Deklinacija deklinacija;
            switch (dzimtene)
            {
                case Dzimtene.Viriesu:
                    deklinacija = new PirmaDeklinacija();
                    break;
                case Dzimtene.Sieviesu:
                    deklinacija = new CieturtaDeklinacija();
                    break;
                default:
                    deklinacija = new PirmaDeklinacija();
                    break;
            }
            return deklinacija.GetEnding(locijums, skaitlis);
        }       
    }

    public enum IpasibasGalotne
    {
        Noteikta = 1,
        Nenoteikta = 2
    }

    
}
