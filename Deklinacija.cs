using System.ComponentModel;

namespace Morfologija
{
    public abstract class Deklinacija
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public void PrintTabel()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(Name);
            foreach (int i in Enum.GetValues(typeof(Locijumi)))
            {
                Console.WriteLine( $"{Enum.GetName(typeof(Locijumi),i)} , {GetEnding((Locijumi)i,(Skaitlis)1)} , {GetEnding((Locijumi)i, (Skaitlis) 2)} ");
            }            
        }

        public virtual string GetEnding(Locijumi locijums, Skaitlis skaitlis)
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

        protected abstract string GetEndingSingular(Locijumi locijums);

        protected abstract string GetEndingPlural(Locijumi locijums);
        
    }
    public enum Skaitlis
    {
        Vienskaitlis=1,
        Daudzskaitlis=2
    }
    public enum Locijumi
    {
        [Description("Nominatīvs    ")]
        Nominativs =1,

        [Description("Ģenitīvs      ")]
        Genitivs =2,

        [Description("Datīvs        ")]
        Dativs =3,

        [Description("Akuzatīvs     ")]
        Akuzativs =4,

        [Description("Instrumentālis")]
        Instrumentalis =5,

        [Description("Lokatīvs      ")]
        Lokativs =6,

        [Description("Vokatīvs      ")]
        Vokativs =7
    }
}