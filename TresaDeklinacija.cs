namespace Morfologija
{
    public class TresaDeklinacija:Deklinacija
    {
        public TresaDeklinacija()
        {
            Name = "III deklinācija";
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
                    return "us";
                case Locijumi.Genitivs:
                    return "us";
                case Locijumi.Dativs:
                    return "um";
                case Locijumi.Akuzativs:
                    return "u";
                case Locijumi.Instrumentalis:
                    return "u";
                case Locijumi.Lokativs:
                    return "ū";
                case Locijumi.Vokativs:
                    return "us";
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
