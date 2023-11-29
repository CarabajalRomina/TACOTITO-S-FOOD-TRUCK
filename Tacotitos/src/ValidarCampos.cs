using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotitos.src
{
    public static class ValidarCampos
    {
        public static string NormalizarString(string cadena)
        {
            if (!string.IsNullOrEmpty(cadena))
            {
                cadena = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1).ToLower();
            }
          
            return cadena;
        }


        public static void VerificarSoloQueSeanNumeros(string cadena, Label lbl)
        {
            if(!string.IsNullOrEmpty(cadena) && !Information.IsNumeric(cadena))
            {
                lbl.Text = "El campo contiene caracteres no numericos";
            }
        }

        public static bool VerificarSoloQueSeanLetras(string cadena)
        {
            var aux = true;
            if (!string.IsNullOrEmpty(cadena) && !cadena.All(char.IsLetter))
            {
                aux = false;
            }
            return aux;
        }


        public static void VerificarSiSeIngresoUnNumeroConUnTopeMax(TextBox txt)
        {
        
        }



    }
}
