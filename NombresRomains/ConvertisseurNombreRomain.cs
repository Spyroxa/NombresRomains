namespace NombresRomains
{
    public class ConvertisseurNombreRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
            {
                1 => UnitéRomaine.Unité.Représenter(nombreArabe),
                _ => throw new NotImplementedException()
            };
    }
}