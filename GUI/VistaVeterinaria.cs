using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class VistaVeterinaria : IVistas
    {
        ServicioVeterinario servicio = new ServicioVeterinario();
        public void Capturar()
        {
            int op;

            do
            {
                Veterinario veterinario = new Veterinario();
                Console.Clear();
                Console.SetCursorPosition(10,8); Console.Write("ID");
                Console.SetCursorPosition(10, 10); Console.Write("NOMBRES");
                Console.SetCursorPosition(10, 12); Console.Write("DIRECCION");
                Console.SetCursorPosition(10, 14); Console.Write("TELEFONO");


                Console.SetCursorPosition(21, 8); veterinario.Id = int.Parse(Console.ReadLine());
                if (veterinario.Id==0)
                {
                    Console.Clear();
                    Console.SetCursorPosition(40, 1); Console.Write("GRACIAS POR USAR PRODUCTOS JOHNP ....");
                    break;
                }
                Console.SetCursorPosition(21, 10); veterinario.Nombres= Console.ReadLine();
                Console.SetCursorPosition(21,12); veterinario.Direccion = Console.ReadLine();
                Console.SetCursorPosition(21, 14); veterinario.Telefono = Console.ReadLine();

                var mensaje=servicio.Guardar(veterinario);
                Console.Clear();
                Console.SetCursorPosition(40, 1); Console.Write(mensaje);
                Console.ReadKey();

            } while (true);
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }

        public void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(30, 5); Console.Write("M E N U   V E T E R I N A R I O");

                Console.SetCursorPosition(32, 10); Console.Write("1. Capturar");
                Console.SetCursorPosition(32, 12); Console.Write("2. Consultar");
                Console.SetCursorPosition(32, 14); Console.Write("3. otro ...");
                Console.SetCursorPosition(32, 16); Console.Write("4. otro mas");

                Console.SetCursorPosition(32, 22); Console.Write("0. Salir");
                Console.SetCursorPosition(32, 24); Console.Write("Digite una opción: ");
                Console.SetCursorPosition(51, 24); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Capturar();
                        break;
                    case 2:
                        Consultar();
                        break;

                   
                }

            } while (op !=0);
        }

        public  void Consultar()
        {
            Console.Clear();
            Console.WriteLine("deberias haberlo programado ...");
            Console.ReadKey();
        }
    }
}
