namespace NombresRomains.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE un nombre 1
            const int nombreArabe = 1;
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient I
            Assert.Equal("I",resultat);
        }
    }
}