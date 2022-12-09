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
                //10 => "X",
                //11 => "XI",
                //12 => "XII",
                //13 => "XIII",
                <= 13 => "X" + UnitéRomaine.Unité.Représenter(nombreArabe -10),
                14 => "XIV",
                //15 => "XV",
                //16 => "XVI",
                //17 => "XVII",
                //18 => "XVIII",
                <= 18 => "X" + "V" + UnitéRomaine.Unité.Représenter(nombreArabe - 15),
                19 => "XIX",
                //20 => "XX",
                //21 => "XXI",
                //22 => "XXII",
                //23 => "XXIII",
                <= 23 => "X" + "X" + UnitéRomaine.Unité.Représenter(nombreArabe - 20),
                24 => "XXIV",
                25 => "XXV",
                _ => throw new NotImplementedException()
            };
    }
}