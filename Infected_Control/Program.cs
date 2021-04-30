using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infected_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            MySortedListPaciente sl = new MySortedListPaciente();

            Paciente p1 = new Paciente();
            p1.Nif = 3;
            p1.Distrito = "braga";
            p1.Frstnome = "Pedro";
            p1.Lstnome = "Moreira";

            Paciente p2 = new Paciente();
            p2.Distrito = "braga";
            p2.Nif = 123;
            p2.Frstnome = "Maria";
            p2.Lstnome = "marta";

            Paciente p3 = new Paciente();
            p3.Distrito = "Porto";
            p3.Nif = 1;
            p3.Frstnome = "Joao";
            p3.Lstnome = "Maria";

            #region Adicionar

            bool aux = sl.InsertElement(p1);

            if (aux != true) Console.WriteLine("Paciente {0} {1} ja registado", p1.Frstnome, p1.Lstnome);

            bool aux1 = sl.InsertElement(p1);

            if (aux1 != true) Console.WriteLine("Paciente {0} {1} ja registado" , p1.Frstnome, p1.Lstnome);

            bool aux2 = sl.InsertElement(p2);

            if (aux2 != true) Console.WriteLine("Paciente {0} {1} ja registado", p2.Frstnome, p2.Lstnome);

            /*
             * Nao funciona com a minha sortList.
             *  teri de usar uma SortList generica
            */
            //try
            //{
            //    sl.InsertElement(p1);
            //}
            //catch (ArgumentException e)
            //{
            //    string error = (e.Message).Substring(0, 24);
            //    Console.WriteLine(error);
            //}

            //try
            //{
            //    sl.InsertElement(p2);
            //}
            //catch (ArgumentException e)
            //{
            //    string error = (e.Message).Substring(0, 24);
            //    Console.WriteLine(error);
            //}

            #endregion

            #region Alterar/Remover

            p2.Nif = 456;

            sl.UpdateElement(p2);
            sl.UpdateElement(p3);

            p1.Estado = false;
            sl.UpdateElement(p1);

            sl.RemoveElement(p1);

            #endregion


            Console.ReadKey();

        }
    }
}
