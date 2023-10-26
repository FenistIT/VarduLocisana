namespace Morfologija
{
    public class OtraDeklinacija : Deklinacija
    {
        public OtraDeklinacija() 
        {
            Name = "II deklinācija";
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
                    return "is";
                case Locijumi.Genitivs:
                    return "a";
                case Locijumi.Dativs:
                    return "im";
                case Locijumi.Akuzativs:
                    return "i";
                case Locijumi.Instrumentalis:
                    return "i";
                case Locijumi.Lokativs:
                    return "ī";
                case Locijumi.Vokativs:
                    return "i";
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
