namespace NombresRomains.Test
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{
        //    // ETANT DONNE un nombre 1
        //    const int nombreArabe = 1;
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient I
        //    Assert.Equal("I",resultat);
        //}
        //[Fact]
        //public void Test2()
        //{
        //    // ETANT DONNE un nombre 2
        //    const int nombreArabe = 2;
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient II
        //    Assert.Equal("II", resultat);
        //}
        //[Fact]
        //public void Test3()
        //{
        //    // ETANT DONNE un nombre 3
        //    const int nombreArabe = 3;
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient III
        //    Assert.Equal("III", resultat);
        //} test plus nécessaire donc mis en commentaire
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
        public void Test5()
        {
            // ETANT DONNE un nombre 5
            const int nombreArabe = 5;
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient V
            Assert.Equal("V", resultat);
        }
        [Fact]
        public void Test6()
        {
            // ETANT DONNE un nombre 6
            const int nombreArabe = 6;
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient VI
            Assert.Equal("VI", resultat);
        }
        [Fact]
        public void Test7()
        {
            // ETANT DONNE un nombre 7
            const int nombreArabe = 7;
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient VII
            Assert.Equal("VII", resultat);
        }
    }
}