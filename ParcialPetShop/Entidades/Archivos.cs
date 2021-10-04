using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
	public class Archivos
	{
			private static int numeroFactura;

		static Archivos() {
			numeroFactura = 0;
		}
		/// <summary>
		/// Genero el archivo Factura en una carpeta en el escritorio
		/// </summary>
		/// <param name="str"></param>
		static public void Exportar(string str) {

			StringBuilder directoryPath = new StringBuilder();

			directoryPath.Append(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Factura");

			if (!Directory.Exists(directoryPath.ToString())) {

				Directory.CreateDirectory(directoryPath.ToString());
			}
			StringBuilder filePath = new StringBuilder();
			numeroFactura++;

			filePath.Append(directoryPath.ToString() + $"\\factura{numeroFactura}.txt");

			StreamWriter sw = new StreamWriter(filePath.ToString());
				
			sw.WriteLine(str);

			sw.WriteLine("Tu comercio de Confianza.");
			
			sw.WriteLine(" ");
			sw.WriteLine(" ");

			sw.WriteLine("Gracias Vuelva Prontos.");

			sw.Close();
		}

	}
}
