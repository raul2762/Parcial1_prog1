using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_prog1
{
	public class MenuPrincipal
	{
		public static void ShowMenu()
		{
			Console.Clear();
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Cajero Automatico - Solo funcion de retiro");
			Console.WriteLine("**********************************************");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("1 - Configurar Dispensacion de billetes \n2 - Retiro de dinero \n3 - Salir");
			Console.Write("Digite una opcion: ");
			try
			{
				int opcion = Convert.ToInt32(Console.ReadLine());

				switch (opcion)
				{
					case 1:
						MenuDisp.ShowMenu();
						break;
					case 2:
						MenuRetiro.ShowMenu();
						break;
					case 3:
						Environment.Exit(0);
						break;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Opcion invalida!");
						Console.ReadKey();
						ShowMenu();
						break;
				}
			}
			catch (Exception)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Opcion invalida!");
				Console.ReadKey();
				ShowMenu();
			}
		}
	}
}
