using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morfologija
{
    public class PirmaDeklinacija:Deklinacija
    {

        public PirmaDeklinacija()
        {
            Name = "I deklinācija";
        }
        public override string GetEnding(Locijumi locijums, Skaitlis skaitlis)
        {
            switch (skaitlis)
            {
                case Skaitlis.Vienskaitlis:
                    return GetEndingSingular(locijums);
                case Skaitlis.Daudzskaitlis:
                    return GetEndingPlural(locijums);
                default:
                    return String.Empty;
            }

        }

        protected override string GetEndingSingular(Locijumi locijums)
        {
            switch (locijums)
            {
                case Locijumi.Nominativs:
                    return "s";
                case Locijumi.Genitivs:
                    return "a";
                case Locijumi.Dativs:
                    return "am";
                case Locijumi.Akuzativs:
                    return "u";
                case Locijumi.Instrumentalis:
                    return "u";
                case Locijumi.Lokativs:
                    return "ā";
                case Locijumi.Vokativs:
                    return "s";
                default:
                    return String.Empty;
            }
        }
        protected override string GetEndingPlural(Locijumi locijums)
        {
            switch (locijums)
            {
                case Locijumi.Nominativs:
                    return "i";
                case Locijumi.Genitivs:
                    return "u";
                case Locijumi.Dativs:
                    return "iem";
                case Locijumi.Akuzativs:
                    return "us";
                case Locijumi.Instrumentalis:
                    return "iem";
                case Locijumi.Lokativs:
                    return "os";
                case Locijumi.Vokativs:
                    return "i";
                default:
                    return String.Empty;
            }
        }
    }
}
