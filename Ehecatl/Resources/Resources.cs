using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehecatl
{
    class Resources
    {
        string language;
        #region Dictionary
        public string INVALID_FILE()
        {
            if (language == "Eng")
            {
                return "The Excel file is invalid! Please select a valid file.";
            }
            else
            {
                return "El archivo Excel es inválido! Por favor seleccione un archivo válido";
            }
        }
        static string TEST;
        #endregion

        public Resources(string language)
        {
            this.language = language;
        }
    }
}
