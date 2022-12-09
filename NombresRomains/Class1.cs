using System;
using System.Collections.Generic;
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

        /// <inheritdoc />
        public string Représenter(int nombreArabe) => new string('I', nombreArabe);

    }

}
