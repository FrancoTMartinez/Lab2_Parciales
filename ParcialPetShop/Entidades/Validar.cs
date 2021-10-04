using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	static public class Validar
	{

		/// <summary>
		/// Valida que el DNI ingresado este bien
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public bool ValidarDNI(string dni) {

			if (dni != string.Empty && dni.All(char.IsDigit) && dni.Length==8) {
				return true;
			}
			return false;
		}

		/// <summary>
		/// Valida cadenas de texto con espacios.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static public bool ValidarCadenaTexto(string str)
		{
			char caracter = ' ' ;
			for (int i = 0; i < str.Length; i++)
			{
				caracter = str[i];
				if (!char.IsLetter(caracter) && caracter != ' ') {
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Valida cadenas de texto con espacios
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static public bool ValidarNumero(string str)
		{
			if (str.All(char.IsDigit) && str != string.Empty)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// Valida que el valor del parametro exista y coincida con alguno de los elementos de la lista estatica clientesList
		/// </summary>
		/// <param name="dni"></param>
		/// <returns></returns>
		static public bool ValidateExistingDNI(string dni)
		{
			List<Cliente> clientesList = Cliente.GetClienteList();
			foreach (Cliente item in clientesList)
			{
				if (item.Dni == dni)
				{
					return false;
				}
			}
			return true;
		}
	}
}
