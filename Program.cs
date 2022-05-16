using System;
using System.Collections.Generic;

namespace ejercicio_frase
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Cortar la frase
            Console.WriteLine("Ingrese la frase que desee invertir");
            string frase = Console.ReadLine();

            List<string> fraseEnLista = convertirStringALista(frase);

            //2 - Invertir palabra
            List<string> fraseEnListaConPalabrasInvertidas = invertirPalabrasDeLaLista(fraseEnLista);

            //3 - Join
            string fraseConPalabrasInvertidas = convertirListaEnString(fraseEnListaConPalabrasInvertidas);

            Console.WriteLine(fraseConPalabrasInvertidas);
        }

        static string convertirListaEnString(List<string> listaDePalabras)
        {
            return string.Join(' ', listaDePalabras.ToArray());
        }

        static List<string> invertirPalabrasDeLaLista(List<string> listaPalabras)
        {
            List<string> listaDePalabrasInvertidas = new List<string>();
            foreach (string palabra in listaPalabras)
            {
                listaDePalabrasInvertidas.Add(invertirPalabra(palabra));
            }
            return listaDePalabrasInvertidas;
        }
        

        static List<string> convertirStringALista(string frase)
        {
            List<string> fraseCortadaEnLista = new List<string>();
            string palabraAcumulada = String.Empty;

            for (int posicion = 0; posicion < frase.Length; posicion++)
            {
                if (frase[posicion] == ' ')
                {
                    fraseCortadaEnLista.Add(palabraAcumulada);
                    palabraAcumulada = "";
                }
                else if (posicion == frase.Length - 1)
                {
                    palabraAcumulada += frase[posicion];
                    fraseCortadaEnLista.Add(palabraAcumulada);
                }
                else
                {
                    palabraAcumulada += frase[posicion];
                }
            }
            return fraseCortadaEnLista;
        }

        // <sumary>
        // Dado una palabra(string), devuelve la palabra invertida(string)
        // </sumary>

        static string invertirPalabra(string palabra)
        {
            string palabraInvertida = String.Empty;
            for (int posicion = 0; posicion < palabra.Length; posicion++)
            {
                palabraInvertida += palabra[palabra.Length - (posicion + 1)];
            }

            return palabraInvertida;
        }
        
    }
}
