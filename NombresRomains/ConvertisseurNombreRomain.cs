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
                _ => throw new NotImplementedException()
            };
    }
}