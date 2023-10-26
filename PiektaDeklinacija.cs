namespace Morfologija
{
    public class PiektaDeklinacija : Deklinacija
    {
        public PiektaDeklinacija()
        {
            Name = "V deklinācija";
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
                    return "e";
                case Locijumi.Genitivs:
                    return "es";
                case Locijumi.Dativs:
                    return "ei";
                case Locijumi.Akuzativs:
                    return "i";
                case Locijumi.Instrumentalis:
                    return "i";
                case Locijumi.Lokativs:
                    return "ē";
                case Locijumi.Vokativs:
                    return "e";
                default:
                    return String.Empty;
            }
        }
        protected override string GetEndingPlural(Locijumi locijums)
        {
            switch (locijums)
            {
                case Locijumi.Nominativs:
                    return "es";
                case Locijumi.Genitivs:
                    return "u";
                case Locijumi.Dativs:
                    return "ēm";
                case Locijumi.Akuzativs:
                    return "es";
                case Locijumi.Instrumentalis:
                    return "ēm";
                case Locijumi.Lokativs:
                    return "ēs";
                case Locijumi.Vokativs:
                    return "es";
                default:
                    return String.Empty;
            }
        }
    }
}
