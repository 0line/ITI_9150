using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro(1, "Can", Genero.Masculino, new PropiedadesAnimal()
            {
                porcertajeAgua = 20,
                porcertajeGrasa = 80
            }, Reino.Animal);
            Gato g = new Gato(2, "Cat", Genero.Femenino, new PropiedadesAnimal()
            {
                porcertajeAgua = 20,
                porcertajeGrasa = 80
            }, Reino.Animal);
            Planta v = new Planta(3, "Plant", Genero.Indefinido, Reino.Vegetal);
            Console.WriteLine(p.ToString() + "\n*************************************************\n" + g.ToString() + "\n*************************************************\n" + v.ToString());
            Console.ReadLine();

        }
    }

}
