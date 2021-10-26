using System;

namespace Proyecto.Topicos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HagaLaMagia();
        }

        private static void HagaLaMagia()
        {
            var laMagia = new LogicaPrincipal();
            laMagia.BuscarPorProductosDescontinuados();
        }
    }
}
