namespace Morfologija
{
    public abstract class Vards
    {
        public Vards(String nosaukums)
        {
            Nosaukums = nosaukums;
            Galotne = GetGalotne();
        }


        public String Nosaukums { get; protected set; }

        public Dzimtene Dzimtene { get; protected set; }

        public Skaitlis Skaitlis { get; protected set; }

        public Locijumi Locijums { get; set; }

        public String Galotne { get; protected set; }

        public abstract void Locisana();

        private string GetGalotne()
        {
            if (Nosaukums.EndsWith("is"))
                return "is";
            if (Nosaukums.EndsWith("us"))
                return "us";
            if (Nosaukums.EndsWith("as"))
                return "as";
            if (Nosaukums.EndsWith("es"))
                return "es";
            if (Nosaukums.EndsWith("s"))
                return "s";
            if (Nosaukums.EndsWith("a"))
                return "a";
            if (Nosaukums.EndsWith("e"))
                return "e";
            return String.Empty;

        }

    }

    public enum Dzimtene
    {
        Viriesu = 1,
        Sieviesu = 2
    }
}
