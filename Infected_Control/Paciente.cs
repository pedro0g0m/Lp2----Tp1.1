/*
* 	<author>Pedro Moreira</author>
*   <email>a12147@alunos.ipca.pt</email>
*	<description>Classe usada para representar o Obj Paciente</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infected_Control
{
    /// <summary>
    /// Purpose: Defenir o Obj Paciente para ser uado pelo resto do trabalho
    /// Created by: Pedro Moreira
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Paciente
    {
        #region Attributes
        static int totObjects = 0;

        int idade;
        string frstnome;
        string lstnome;
        int nif;
        string distrito;
        bool estado;
        string doenca;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// O construtor default
        /// </summary>
        public Paciente()
        {
            totObjects = 0;
            estado = true;
        }

        /// <summary>
        /// O construtor com todos os campos existentes 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ln"></param>
        /// <param name="i"></param>
        /// <param name="nif"></param>
        public Paciente(string n, string ln, int i, int nif)
        {
            frstnome = n;
            lstnome = ln;
            idade = i;
            this.nif = nif;
            totObjects++;
            estado = true;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade de instância
        /// </summary>
        public int TotPacientes => totObjects;

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public string Distrito
        {
            get => distrito;
            set => distrito = value;
        }

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public string Frstnome
        {
            get => frstnome;
            set => frstnome = value;
        }

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public string Lstnome
        {
            get => lstnome;
            set => lstnome = value;
        }

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public int Nif
        {
            get => nif;
            set => nif = value;
        }

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public string Doenca
        {
            get => doenca;
            set => doenca = value;
        }

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public bool Estado
        {
            get => estado;
            set => estado = value;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Comparar objeto local com outro externo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Paciente p = (Paciente)obj;    
            return (String.Compare(p.frstnome, this.frstnome) == 0) && (this.lstnome == p.lstnome) && (this.nif == p.nif); 
        }

        /// <summary>
        /// Para talvez usar mais tarde!
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hashCode = -266144417;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(frstnome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lstnome);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(nif);
            return hashCode;
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Override do operador 
        /// </summary>
        /// <param name="p1">obejeto a comparar</param>
        /// <param name="p2">obejeto a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Paciente p1, Paciente p2)
        {
            return p1.Equals(p2);
        }

        /// <summary>
        /// Override do operador 
        /// </summary>
        /// <param name="p1">obejeto a comparar</param>
        /// <param name="p2">obejeto a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Paciente p1, Paciente p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Paciente()
        {
        }
        #endregion

        #endregion
    }
}
