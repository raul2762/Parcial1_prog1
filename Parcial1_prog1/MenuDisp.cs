using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_prog1
{
	public class MenuDisp
	{
		private static bool _modeDisp1, _modeDisp2, _modeDisp3 = true;
		public bool modeDisp1 { get { return _modeDisp1; } }
		public bool modeDisp2 { get { return _modeDisp2; } }
		public bool modeDisp3 { get { return _modeDisp3; } }

		private static MenuDisp _instancia = null;
		public static MenuDisp Instancia
		{
			get
			{
				if (_instancia == null)
				{
					_instancia = new MenuDisp();
				}
				return _instancia;
			}

		}

		public static void ShowMenu()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Modo de dispensacion de billetes");
			Console.WriteLine("*************************************");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("1 - [200,1000] \n2 - [100,500] \n3 - [100,200,500,1000] ");
			try
			{
				int opcion = Convert.ToInt32(Console.ReadLine());

				switch (opcion)
				{
					case 1:
						_modeDisp1 = true;
						_modeDisp2 = false;
						_modeDisp3 = false;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Modo seleccionado correctamente!");
						Console.ReadKey();
						MenuPrincipal.ShowMenu();
						break;
					case 2:
						_modeDisp1 = false;
						_modeDisp2 = true;
						_modeDisp3 = false;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Modo seleccionado correctamente!");
						Console.ReadKey();
						MenuPrincipal.ShowMenu();
						break;
					case 3:
						_modeDisp1 = false;
						_modeDisp2 = false;
						_modeDisp3 = true;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Modo seleccionado correctamente!");
						Console.ReadKey();
						MenuPrincipal.ShowMenu();
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
