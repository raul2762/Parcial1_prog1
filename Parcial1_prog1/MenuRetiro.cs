using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Parcial1_prog1
{
	public class MenuRetiro
	{
		
		
		public static void ShowMenu()
		{
			int C100 = 0, C200 = 0, C500 = 0, C1000 = 0;
			int total_retiro = 0, retiro_verify = 0;
			MenuDisp menuDisp = MenuDisp.Instancia;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Menu ratiro de dinero");
			Console.WriteLine("*************************************");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Digite la cantidad a retirar: ");
			int cant_retiro = Convert.ToInt32(Console.ReadLine());
			retiro_verify = cant_retiro;
			if (menuDisp.modeDisp1)
			{
				if (cant_retiro >= 1000)
				{
					C1000 = (cant_retiro / 1000);
					cant_retiro = cant_retiro - (C1000 * 1000);
					total_retiro = C1000 * 1000;
				}

				if (cant_retiro >= 200)
				{
					C200 = (cant_retiro / 200);
					cant_retiro = cant_retiro - (C200 * 200);
					total_retiro += (C200 * 200);
				}

				if (retiro_verify == total_retiro)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					if (C200 != 0)
					{
						Console.WriteLine("Billetes de 200: {0}", C200);
					}

					if (C1000 != 0)
					{
						Console.WriteLine("Billetes de 1000: {0}", C1000);
					}
					Console.ReadKey();
					MenuPrincipal.ShowMenu();
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("***Este cajero solo dispensa billetes de 200 y 1000***");
					Console.WriteLine("----------------------------------------------------");
					Console.Write("1-Introducir otro monto 2-Menu Principal: ");
					try
					{
						int opcion = Convert.ToInt32(Console.ReadLine());
						switch (opcion)
						{
							case 1:
								ShowMenu();
								break;
							case 2:
								MenuPrincipal.ShowMenu();
								break;
							default:
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Opcion invalida!");
								Console.ReadKey();
								MenuPrincipal.ShowMenu();
								break;
						}
					}
					catch (Exception)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Opcion invalida!");
						Console.ReadKey();
						MenuPrincipal.ShowMenu();
					}
				}

				
			}
			else if (menuDisp.modeDisp2)
			{
				if (cant_retiro >= 500)
				{
					C500 = (cant_retiro / 500);
					cant_retiro = cant_retiro - (C500 * 500);
					total_retiro = C500 * 500;
				}

				if (cant_retiro >= 100)
				{
					C100 = (cant_retiro / 100);
					cant_retiro = cant_retiro - (C100 * 100);
					total_retiro += (C100 * 100);
				}

				if (retiro_verify == total_retiro)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					if (C100 != 0)
					{
						Console.WriteLine("Billetes de 100: {0}", C100);
					}

					if (C500 != 0)
					{
						Console.WriteLine("Billetes de 500: {0}", C500);
					}
					Console.ReadKey();
					MenuPrincipal.ShowMenu();
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("***Este cajero solo dispensa billetes de 100 y 500***");
					Console.WriteLine("----------------------------------------------------");
					Console.Write("1-Introducir otro monto 2-Menu Principal: ");
					try
					{
						int opcion = Convert.ToInt32(Console.ReadLine());
						switch (opcion)
						{
							case 1:
								ShowMenu();
								break;
							case 2:
								MenuPrincipal.ShowMenu();
								break;
							default:
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Opcion invalida!");
								Console.ReadKey();
								MenuPrincipal.ShowMenu();
								break;
						}
					}
					catch (Exception)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Opcion invalida!");
						Console.ReadKey();
						MenuPrincipal.ShowMenu();
					}
				}
			}
			else if (menuDisp.modeDisp3)
			{
				if (cant_retiro >= 1000)
				{
					C1000 = (cant_retiro / 1000);
					cant_retiro = cant_retiro - (C1000 * 1000);
					total_retiro = C1000 * 1000;
				}

				if (cant_retiro >= 500)
				{
					C500 = (cant_retiro / 500);
					cant_retiro = cant_retiro - (C500 * 500);
					total_retiro += (C500 * 500);
				}

				if (cant_retiro >= 200)
				{
					C200 = (cant_retiro / 200);
					cant_retiro = cant_retiro - (C200 * 200);
					total_retiro += C200 * 200;
				}

				if (cant_retiro >= 100)
				{
					C100 = (cant_retiro / 100);
					cant_retiro = cant_retiro - (C100 * 100);
					total_retiro += (C100 * 100);
				}

				if (retiro_verify == total_retiro)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					if (C100 != 0)
					{
						Console.WriteLine("Billetes de 100: {0}", C100);
					}
					if (C200 != 0)
					{
						Console.WriteLine("Billetes de 200: {0}", C200);
					}
					if (C500 != 0)
					{
						Console.WriteLine("Billetes de 500: {0}", C500);
					}
					if (C1000 != 0)
					{
						Console.WriteLine("Billetes de 1000: {0}", C1000);
					}
					
					Console.ReadKey();
					MenuPrincipal.ShowMenu();
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("***Este cajero solo dispensa billetes de 100 , 200, 500 y 1000***");
					Console.WriteLine("----------------------------------------------------");
					Console.Write("1-Introducir otro monto 2-Menu Principal: ");
					try
					{
						int opcion = Convert.ToInt32(Console.ReadLine());
						switch (opcion)
						{
							case 1:
								ShowMenu();
								break;
							case 2:
								MenuPrincipal.ShowMenu();
								break;
							default:
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Opcion invalida!");
								Console.ReadKey();
								MenuPrincipal.ShowMenu();
								break;
						}
					}
					catch (Exception)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Opcion invalida!");
						Console.ReadKey();
						MenuPrincipal.ShowMenu();
					}
				}
			}
		}
	}
}
