namespace NombresRomains
{
    public class ConvertisseurNombreRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
            {
                //1 => UnitéRomaine.Unité.Représenter(nombreArabe),
                //2 => "II",
                //3 => "III",
                <= 3 => UnitéRomaine.Unité.Représenter(nombreArabe),
                4 => "IV",
                //5 => "V",
                //6 => "VI",
                //7 => "VII",
                //8 => "VIII",
                <= 8 => "V" + UnitéRomaine.Unité.Représenter(nombreArabe - 5),
                9 => "IX",
                10 => "X",
                11 => "XI",
                12 => "XII",
                13 => "XIII",
                _ => throw new NotImplementedException()
            };
    }
}