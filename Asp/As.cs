using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá mundo!");
            
            Teste.Main();
            TesteElse.Main();
        }
    }

    class Teste {
        public static void Main() {
            for (int i = 10; i >= 1; i--) {
                Console.WriteLine(i);
            }
        }
    }

    class TesteElse {
        public static void Main() {
            Console.WriteLine("Digite o seu comando: ");
            int a = Int32.Parse(Console.ReadLine());
            string mensagem = "Variável ";
            if (a >= 1 && a <= 10) {
                Console.WriteLine(mensagem + a);
            } else {
                Console.WriteLine("Fora do intervalo de 1 a 10.");
            }
        }
    }
}
