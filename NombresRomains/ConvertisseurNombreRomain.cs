namespace NombresRomains
{
    public class ConvertisseurNombreRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
            {
                
                <= 3 => UnitéRomaine.Unité.Représenter(nombreArabe),
                4 => "IV",
                <= 8 => "V" + UnitéRomaine.Unité.Représenter(nombreArabe - 5),
                9 => "IX",
                <= 13 => "X" + UnitéRomaine.Unité.Représenter(nombreArabe -10),
                14 => "XIV",
                <= 18 => "X" + "V" + UnitéRomaine.Unité.Représenter(nombreArabe - 15),
                19 => "XIX",
                <= 23 => "X" + "X" + UnitéRomaine.Unité.Représenter(nombreArabe - 20),
                24 => "XXIV",
                <= 28 => "XXV" + UnitéRomaine.Unité.Représenter(nombreArabe - 25),
                29 => "XXIX",
                30 => "XXX",
                _ => throw new NotImplementedException()
            };
    }
}