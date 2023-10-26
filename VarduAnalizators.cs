namespace Morfologija
{
    public static class VarduAnalizators
    {
        static List<string> ipasibasVarduVardnica=new List<string> { "skaists","prieks","lielāks","saulains","milzīgs"};
        public static Vards VarduDefinicija(string nosaukums)
        {            
            if (ipasibasVarduVardnica.Contains(nosaukums.ToLower()))
                return new IpasibasVards(nosaukums);
            else
                return new LietVards(nosaukums);
        }
    }
}
