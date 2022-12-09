namespace NombresRomains.Test
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnités(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 1 et 3
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(n);

            // ALORS on obtient <n> fois 'I'
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void Test4()
        {
            // ETANT DONNE un nombre 4
            const int nombreArabe = 4;
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient IV
            Assert.Equal("IV", resultat);
        }



        [Fact]
        public void Test9()
        {
            // ETANT DONNE le nombre 9
            const int nombreArabe = 9;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'IX'
            Assert.Equal("IX", resultat);
        }


        [Fact]
        public void Test14()
        {
            // ETANT DONNE le nombre 14
            const int nombreArabe = 14;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XIV'
            Assert.Equal("XIV", resultat);
        }

        [Fact]
        public void Test19()
        {
            // ETANT DONNE le nombre 19
            const int nombreArabe = 19;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XIX'
            Assert.Equal("XIX", resultat);
        }


        [Fact]
        public void Test24()
        {
            // ETANT DONNE le nombre 24
            const int nombreArabe = 24;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XXIV'
            Assert.Equal("XXIV", resultat);
        }


        [Fact]
        public void Test29()
        {
            // ETANT DONNE le nombre 29
            const int nombreArabe = 29;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XXIX'
            Assert.Equal("XXIX", resultat);
        }

        [Fact]
        public void Test30()
        {
            // ETANT DONNE le nombre 30
            const int nombreArabe = 30;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XXX'
            Assert.Equal("XXX", resultat);
        }

        [Theory]
        [InlineData(5, "V", 5)]
        [InlineData(6, "V", 5)]
        [InlineData(7, "V", 5)]
        [InlineData(8, "V", 5)]
        [InlineData(10, "X", 10)]
        [InlineData(11, "X", 10)]
        [InlineData(12, "X", 10)]
        [InlineData(13, "X", 10)]
        [InlineData(15, "XV", 15)]
        [InlineData(16, "XV", 15)]
        [InlineData(17, "XV", 15)]
        [InlineData(18, "XV", 15)]
        [InlineData(20, "XX", 20)]
        [InlineData(21, "XX", 20)]
        [InlineData(22, "XX", 20)]
        [InlineData(23, "XX", 20)]
        [InlineData(25, "XXV", 25)]
        [InlineData(26, "XXV", 25)]
        [InlineData(27, "XXV", 25)]
        [InlineData(28, "XXV", 25)]
        public void TestSymbolePlusUnité(int nombreArabe, string symbole, int valeurSymbole)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre <valeurSymbole> et <valeurSymbole> + 3
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient <symbole> plus <nombreArabe - valeurSymbole> fois 'I' 
            var attendu = symbole + new string('I', nombreArabe - valeurSymbole);
        }
    }
}