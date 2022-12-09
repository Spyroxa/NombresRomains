using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresRomains
{
    internal class UnitéRomaine
    {
        public static UnitéRomaine Unité => new UnitéRomaine();

        private UnitéRomaine()
        {
        }

        public class NombreChiffreRomain
        {
            public static readonly string Unite = "I";
            public static readonly string Cinq = "V";
            public static readonly string Dix = "X";
        }

        /// <inheritdoc />
        public string Un(int nombreArabe) => new string('I', nombreArabe);

      
        
        public string Cinq(int nombreArabe) => new string('V', nombreArabe);
        public string Dix(int nombreArabe) => new string('X', nombreArabe);

    }

}
