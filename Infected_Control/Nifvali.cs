/*
* 	<author>Pedro Moreira</author>
*   <email>a12147@alunos.ipca.pt</email>
*	<description>Classe usada para validar o nif</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infected_Control
{
    class Nifvali
    {
        /// <summary>
        /// Valida o Nif
        /// </summary>
        /// <param name="nifString"></param>
        /// <returns></returns>
        public bool IsNIPCCorrect(String nifString)
        {
            int controlDigit = 0;

            for (int i = 0; i < nifString.Length - 1; i++)
            {
                controlDigit += (int)Char.GetNumericValue(nifString[i]) * (10 - i - 1);
            };

            controlDigit = controlDigit % 11;

            if (controlDigit <= 1)
            {
                controlDigit = 0;
            }
            else
            {
                controlDigit = 11 - controlDigit;
            }

            if (controlDigit == (int)Char.GetNumericValue(nifString[8]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
