using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_prog1
{
	public class ModoDisp
	{
		private static ModoDisp _instancia = null;
		public static ModoDisp Instancia
		{
			get
			{
				if (_instancia == null)
				{
					_instancia = new ModoDisp();
				}
				return _instancia;
			}
		}


	}
}
