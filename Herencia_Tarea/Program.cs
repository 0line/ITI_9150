using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            SerVivo ser = new SerVivo();
            SerVivo p = new SerVivo(1, "Can", Genero.Masculino, new PropiedadesSerVivo()
            {
                porcertajeAgua = 20,
                porcertajeGrasa = 80
            }, Reino.Animal);
            SerVivo g = new SerVivo(2, "Cat", Genero.Femenino, new PropiedadesSerVivo()
            {
                porcertajeAgua = 20,
                porcertajeGrasa = 80
            }, Reino.Animal);
            SerVivo v = new SerVivo(3, "Plant", Genero.Indefinido, Reino.Vegetal);
            Console.WriteLine(p.ToString() + "\n*************************************************\n" + g.ToString() + "\n*************************************************\n" + v.ToString());
            Console.ReadLine();
        }
    }
}
