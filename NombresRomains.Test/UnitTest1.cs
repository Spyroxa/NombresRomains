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
        //[Fact]
        //public void Test5()
        //{
        //    // ETANT DONNE un nombre 5
        //    const int nombreArabe = 5;
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient V
        //    Assert.Equal("V", resultat);
        //}
        //[Fact]
        //public void Test6()
        //{
        //    // ETANT DONNE un nombre 6
        //    const int nombreArabe = 6;
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient VI
        //    Assert.Equal("VI", resultat);
        //}
        //[Fact]
        //public void Test7()
        //{
        //    // ETANT DONNE un nombre 7
        //    const int nombreArabe = 7;
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient VII
        //    Assert.Equal("VII", resultat);
        //}
        //[Fact]
        //public void Test8()
        //{
        //    // ETANT DONNE un nombre 8
        //    const int nombreArabe = 8;
        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient VIII
        //    Assert.Equal("VIII", resultat);
        //} plus utile donc mis en commentaire pour le moment
        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestCinqPlusUnité(int nombreArabe)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre 5 et 8
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'V' plus <nombreArabe - 5> fois 'I'
            var attendu = 'V' + new string('I', nombreArabe - 5);
            Assert.Equal(attendu, resultat);
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
        //[Fact]
        //public void Test10()
        //{
        //    // ETANT DONNE le nombre 10
        //    const int nombreArabe = 10;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'X'
        //    Assert.Equal("X", resultat);
        //}
        //[Fact]
        //public void Test11()
        //{
        //    // ETANT DONNE le nombre 11
        //    const int nombreArabe = 11;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XI'
        //    Assert.Equal("XI", resultat);
        //}
        //[Fact]
        //public void Test12()
        //{
        //    // ETANT DONNE le nombre 12
        //    const int nombreArabe = 12;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XII'
        //    Assert.Equal("XII", resultat);
        //}
        //[Fact]
        //public void Test13()
        //{
        //    // ETANT DONNE le nombre 13
        //    const int nombreArabe = 13;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XIII'
        //    Assert.Equal("XIII", resultat);
        //} plus utile
        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        public void TestDixPlusUnité(int nombreArabe)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre 10 et 10
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient 'X' plus <nombreArabe - 10> fois 'I'
            var attendu = 'X' + new string('I', nombreArabe - 10);
            Assert.Equal(attendu, resultat);
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
        //[Fact]
        //public void Test15()
        //{
        //    // ETANT DONNE le nombre 15
        //    const int nombreArabe = 15;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XV'
        //    Assert.Equal("XV", resultat);
        //}
        //[Fact]
        //public void Test16()
        //{
        //    // ETANT DONNE le nombre 16
        //    const int nombreArabe = 16;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XVI'
        //    Assert.Equal("XVI", resultat);
        //}
        //[Fact]
        //public void Test17()
        //{
        //    // ETANT DONNE le nombre 17
        //    const int nombreArabe = 17;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XVII'
        //    Assert.Equal("XVII", resultat);
        //}
        //[Fact]
        //public void Test18()
        //{
        //    // ETANT DONNE le nombre 18
        //    const int nombreArabe = 18;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XVIII'
        //    Assert.Equal("XVIII", resultat);
        //} plus utile

        [Theory]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        public void TestQuinzePlusUnité(int nombreArabe)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre 15 et 18
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient "XV" plus <nombreArabe - 15> fois 'I'
            var attendu = "XV" + new string('I', nombreArabe - 15);
            Assert.Equal(attendu, resultat);
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
        //[Fact]
        //public void Test20()
        //{
        //    // ETANT DONNE le nombre 20
        //    const int nombreArabe = 20;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XX'
        //    Assert.Equal("XX", resultat);
        //}
        //[Fact]
        //public void Test21()
        //{
        //    // ETANT DONNE le nombre 21
        //    const int nombreArabe = 21;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XXI'
        //    Assert.Equal("XXI", resultat);
        //}
        //[Fact]
        //public void Test22()
        //{
        //    // ETANT DONNE le nombre 22
        //    const int nombreArabe = 22;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XXII'
        //    Assert.Equal("XXII", resultat);
        //}
        //[Fact]
        //public void Test23()
        //{
        //    // ETANT DONNE le nombre 23
        //    const int nombreArabe = 23;

        //    // QUAND on le convertit en nombres romains
        //    var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

        //    // ALORS on obtient 'XXIII'
        //    Assert.Equal("XXIII", resultat);
        //} plus utile
        [Theory]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        public void TestVingPlusUnité(int nombreArabe)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre 20 et 23
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomains.Convertir(nombreArabe);

            // ALORS on obtient "XX" plus <nombreArabe - 20> fois 'I'
            var attendu = "XX" + new string('I', nombreArabe - 20);
            Assert.Equal(attendu, resultat);
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
    }
}