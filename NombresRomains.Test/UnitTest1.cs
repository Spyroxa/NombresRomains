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

        //[Theory]
        //[InlineData(5)]
        //[InlineData(6)]
        //[InlineData(7)]
        //[InlineData(8)]
        //public void TestCinqPlusUnité(int nombreArabe)
        //{
        //    // ETANT DONNE un nombre <nombreArabe> compris entre 5 et 8
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'V' plus <nombreArabe - 5> fois 'I'
        //    var attendu = 'V' + new string('I', nombreArabe - 5);
        //    Assert.Equal(attendu, resultat);
        //}

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

        //[Theory]
        //[InlineData(10)]
        //[InlineData(11)]
        //[InlineData(12)]
        //[InlineData(13)]
        //public void TestDixPlusUnité(int nombreArabe)
        //{
        //    // ETANT DONNE un nombre <nombreArabe> compris entre 10 et 10
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'X' plus <nombreArabe - 10> fois 'I'
        //    var attendu = 'X' + new string('I', nombreArabe - 10);
        //    Assert.Equal(attendu, resultat);
        //}

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

        //[Theory]
        //[InlineData(15)]
        //[InlineData(16)]
        //[InlineData(17)]
        //[InlineData(18)]
        //public void TestQuinzePlusUnité(int nombreArabe)
        //{
        //    // ETANT DONNE un nombre <nombreArabe> compris entre 15 et 18
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient "XV" plus <nombreArabe - 15> fois 'I'
        //    var attendu = "XV" + new string('I', nombreArabe - 15);
        //    Assert.Equal(attendu, resultat);
        //}

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

        //[Theory]
        //[InlineData(20)]
        //[InlineData(21)]
        //[InlineData(22)]
        //[InlineData(23)]
        //public void TestVingPlusUnité(int nombreArabe)
        //{
        //    // ETANT DONNE un nombre <nombreArabe> compris entre 20 et 23
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient "XX" plus <nombreArabe - 20> fois 'I'
        //    var attendu = "XX" + new string('I', nombreArabe - 20);
        //    Assert.Equal(attendu, resultat);
        //}

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

        //[Theory]
        //[InlineData(25)]
        //[InlineData(26)]
        //[InlineData(27)]
        //[InlineData(28)]
        //public void TestVingCinqPlusUnité(int nombreArabe)
        //{
        //    // ETANT DONNE un nombre <nombreArabe> compris entre 25 et 28
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient "XXV" plus <nombreArabe - 25> fois 'I'
        //    var attendu = "XXV" + new string('I', nombreArabe - 25);
        //    Assert.Equal(attendu, resultat);
        //}

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