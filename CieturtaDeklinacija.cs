namespace Morfologija
{
    public class CieturtaDeklinacija :Deklinacija
    {
        public CieturtaDeklinacija()
        {
            Name = "IV deklinācija";
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
                    return "a";
                case Locijumi.Genitivs:
                    return "as";
                case Locijumi.Dativs:
                    return "ai";
                case Locijumi.Akuzativs:
                    return "u";
                case Locijumi.Instrumentalis:
                    return "u";
                case Locijumi.Lokativs:
                    return "ā";
                case Locijumi.Vokativs:
                    return "a";
                default:
                    return String.Empty;
            }
        }
        protected override string GetEndingPlural(Locijumi locijums)
        {
            switch (locijums)
            {
                case Locijumi.Nominativs:
                    return "as";
                case Locijumi.Genitivs:
                    return "u";
                case Locijumi.Dativs:
                    return "ām";
                case Locijumi.Akuzativs:
                    return "as";
                case Locijumi.Instrumentalis:
                    return "ām";
                case Locijumi.Lokativs:
                    return "ās";
                case Locijumi.Vokativs:
                    return "as";
                default:
                    return String.Empty;
            }
        }
    }
}
