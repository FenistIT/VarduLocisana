using MorfoServices;
using System.Text;

namespace Morfologija
{
    public class IpasibasVards:Vards
    {
        public IpasibasVards(string nosaukums) : base(nosaukums)
        {
        }             

        public IpasibasGalotne IpasibasGalotne { get;  set; }

        public override String Locisana()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"                                  Īpašības vārdu \"{Nosaukums}\" locīšana");
            stringBuilder.AppendLine("                       Vienskaitlis                    Daudzskaitlis");
            stringBuilder.AppendLine("               Vīriešu dzimt.  Sieviešu dzimt.   Vīriešu dzimt.  Sieviešu dzimt.");
            foreach (Locijumi locijums in Enum.GetValues(typeof(Locijumi)))
            {
                if (locijums == Locijumi.Nominativs)
                    stringBuilder.AppendLine($"{locijums.GetDescription()}   {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)1)}       {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)1)}             {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)2)}                {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)2)}  ");
                if (locijums == Locijumi.Genitivs)
                    stringBuilder.AppendLine($"{locijums.GetDescription()}   {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)1)}       {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)1)}            {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)2)}                {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)2)}  ");
                if (locijums == Locijumi.Dativs)
                    stringBuilder.AppendLine($"{locijums.GetDescription()}   {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)1)}      {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)1)}            {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)2)}              {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)2)}  ");
                if (locijums == Locijumi.Instrumentalis)
                    stringBuilder.AppendLine($"{locijums.GetDescription()}   {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)1)}       {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)1)}             {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)2)}              {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)2)}  ");

                if (locijums == Locijumi.Akuzativs || locijums == Locijumi.Lokativs)
                    stringBuilder.AppendLine($"{locijums.GetDescription()}   {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)1)}       {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)1)}             {this.Sakne}{GetEnding(locijums, (Dzimtene)1, (Skaitlis)2)}               {this.Sakne}{GetEnding(locijums, (Dzimtene)2, (Skaitlis)2)}  ");
            }
            return stringBuilder.ToString();
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
