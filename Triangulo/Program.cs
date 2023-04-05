namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Triângulo");

            do
            {
                Triangulo triangulo = new Triangulo();
                Console.Clear();
                Console.WriteLine("Informe os lados de um triângulo, separado por espaço: ");
                string ladosTriangulo = Console.ReadLine();
                String[] lados = ladosTriangulo.Split(" ");

                triangulo.primeiroLado = int.Parse(lados[0]);
                triangulo.segundoLado = int.Parse(lados[1]);
                triangulo.terceiroLado = int.Parse(lados[2]);

                triangulo.VerificarTriangulo();
                Console.ReadLine();

            } while (true);
        }
    }
}