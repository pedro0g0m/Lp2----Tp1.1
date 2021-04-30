/*
* 	<author>Pedro Moreira</author>
*   <email>a12147@alunos.ipca.pt</email>
*	<description>Interface com os metodos necessarios</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infected_Control
{
    interface IOperacoes
    {
        bool InsertElement(object x);
        bool RemoveElement(object x);
        bool UpdateElement(object x);
    }
}
