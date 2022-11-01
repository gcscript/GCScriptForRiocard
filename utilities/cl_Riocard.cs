namespace utilities;

public static class cl_Riocard
{
    public static string TreatType(string type)
    {
        return cl_Tools.TreatText(type).Replace("CARTAO PERSONALIZADO ", "").Replace("CARTÃO AO PORTADOR", "PORTADOR");
    }
}
