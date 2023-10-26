namespace Morfologija
{
    public static class VarduAnalizators
    {
        static List<string> ipasibasVarduVardnica=new List<string> { "skaists","priecīgs","lielāks","saulains","milzīgs", "valdzinošs","labvēlīgs" };
        public static Vards VarduDefinicija(string nosaukums)
        {            
            if (ipasibasVarduVardnica.Contains(nosaukums.ToLower()))
                return new IpasibasVards(nosaukums);
            else
                return new LietVards(nosaukums);
        }
    }
}
