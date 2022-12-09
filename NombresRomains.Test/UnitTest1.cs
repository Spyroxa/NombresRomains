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
        [Fact]
        public void Test2()
        {
            // ETANT DONNE un nombre 2
            const int nombreArabe = 2;
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient II
            Assert.Equal("II", resultat);
        }
        [Fact]
        public void Test3()
        {
            // ETANT DONNE un nombre 3
            const int nombreArabe = 3;
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient III
            Assert.Equal("III", resultat);
        }
    }
}