using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Triangulo
    {
        public int primeiroLado;
        public int segundoLado;
        public int terceiroLado;

        public void VerificarTriangulo()
        {
            if (primeiroLado < segundoLado + terceiroLado && segundoLado < primeiroLado + terceiroLado && terceiroLado < primeiroLado + segundoLado)
            {
                if (primeiroLado == segundoLado && primeiroLado == terceiroLado)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if(primeiroLado == segundoLado || primeiroLado == terceiroLado || segundoLado == terceiroLado)
                {
                    Console.WriteLine("Triângulo isóceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Triângulo inválido");
            }
        }
    }
}
