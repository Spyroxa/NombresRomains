namespace NombresRomains
{
    public class ConvertisseurNombreRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
            {
                
                <= 3 => UnitéRomaine.Unité.Un(nombreArabe),
                4 => "IV",
                <= 8 => UnitéRomaine.Unité.Cinq(nombreArabe) + UnitéRomaine.Unité.Un(nombreArabe - 5),
                9 => "IX",
                <= 13 => "X" + UnitéRomaine.Unité.Un(nombreArabe -10),
                14 => "XIV",
                <= 18 => "X" + UnitéRomaine.Unité.Cinq(nombreArabe) + UnitéRomaine.Unité.Un(nombreArabe - 15),
                19 => "XIX",
                <= 23 => "X" + "X" + UnitéRomaine.Unité.Un(nombreArabe - 20),
                24 => "XXIV",
                <= 28 => "XXV" + UnitéRomaine.Unité.Un(nombreArabe - 25),
                29 => "XXIX",
                30 => "XXX",
                _ => throw new NotImplementedException()
            };
    }
}