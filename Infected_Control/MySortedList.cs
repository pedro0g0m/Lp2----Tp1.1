/*
* 	<author>Pedro Moreira</author>
*   <email>a12147@alunos.ipca.pt</email>
*	<description>Classe que gere uma SortedList</description>
**/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infected_Control
{

    /// <summary>
    /// Purpose: Defenir a SortedList para armazenar os Pacientes
    /// Respeita a interface IOperacoes
    /// Created by: Pedro Moreira
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class MySortedListPaciente : IOperacoes
    {
        #region Attributes
        SortedList st;
        const int CAPACITY = 100;
        #endregion

        #region Contrutor

        /// <summary>
        /// O construtor default
        /// </summary>
        public MySortedListPaciente()
        {
            st = new SortedList(CAPACITY);
        }

        /// <summary>
        /// Ajusta a dimensão da SortedList
        /// </summary>
        public MySortedListPaciente(int n)
        {
            if (n > CAPACITY) n = CAPACITY;
            st = new SortedList(n);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Insere elemento na sortedlist
        /// Método do interface
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool InsertElement(object x)
        {
            if (st.ContainsValue(x)) 
            {
                return false;
            } 
            Paciente p = x as Paciente;

            if (st.ContainsKey(p.Nif)) return false;
            st.Add(p.Nif, p);
            return true;
        }

        /// <summary>
        /// Remove elemento da SortedList
        /// Método do interface
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool RemoveElement(object x)
        {
            if (!st.ContainsValue(x)) return false;
            Paciente p = x as Paciente;
            st.Remove(p.Nif);
            return true;
        }

        /// <summary>
        /// Se não existir, insere
        /// Se existir altera
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool UpdateElement(object x)
        {
            Paciente p = x as Paciente;

            if (!st.ContainsValue(x) && !st.ContainsKey(p.Nif))
                st.Add(((Paciente)x).Nif, x);
            else
            {
                st.Remove(((Paciente)x).Nif);
                st[((Paciente)x).Nif] = x;
            }
            return true;
        }

        #endregion
    }
}
