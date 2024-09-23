using System;

namespace Aula{

    class Program{

        static void Main(string[] args){

            Pilha pilha = new();
            // Pilha pilhaletras = new();
            // Pilha pilha2 = new();
            // Pilha pilha3 = new();

            // pilhaletras.push("O");
            // pilhaletras.push("L");
            // pilhaletras.push("A");

            //EX 1A E 1B
            // pilha.push(100);
            // pilha.push(100);
            // pilha.push(200);
            // pilha.push(200);
            // pilha.pop();
            // pilha.pop();


            // pilha.imprimir();
            // pilha.percurso();

            //EXX 1 C
            // int valor = 200;
            // No noAtual;
            // noAtual = null;

        //     Boolean verif = pilha.consulta(valor, ref noAtual);

        //     if(verif == true){
        //         Console.WriteLine("A busca encontrou!");
        //     }else{
        //             Console.WriteLine("A busca não encontrou!");
        //     }

        //EXX 1 D
        //     pilha.imprimir();
        //     pilha.percurso();

            // pilha.imprimir();
            // pilha.NumerosImpares();

        // pilha.imprimir();
        // Console.WriteLine("\n");    
        // pilha.SepararPositivosNegativos(pilha2, pilha3);

        // // Exibir os resultados
        // Console.WriteLine("Pilha de números positivos (Pilha2):");
        // pilha2.imprimir();
        
        // Console.WriteLine("\n");    
        
        // Console.WriteLine("Pilha de números negativos (Pilha3):");
        // pilha3.imprimir();

        
        // Console.WriteLine("Pilha Inicial:");
        // pilhaletras.imprimir();

        // // Inverter a pilha
        // pilhaletras.inverter();

        // Console.WriteLine("Pilha Final (Inversa):");
        // pilhaletras.imprimir();

        pilha.push("R");
        pilha.push("A");
        pilha.push("D");
        pilha.push("A");
        pilha.push("R");

        Console.WriteLine("Pilha Inicial (RADAR):");
        pilha.imprimir();

        if (pilha.Palindromo())
        {
            Console.WriteLine("Resposta: É PALÍNDROMO");
        }
        else
        {
            Console.WriteLine("Resposta: NÃO É PALÍNDROMO");
        }

        // Exemplo 2: Verificar a palavra PROGRAMAR (que não é palíndromo)
        Pilha pilha2 = new Pilha();
        
        pilha2.push("P");
        pilha2.push("R");
        pilha2.push("O");
        pilha2.push("G");
        pilha2.push("R");
        pilha2.push("A");
        pilha2.push("M");
        pilha2.push("A");
        pilha2.push("R");
        
        Console.WriteLine("\nPilha Inicial (PROGRAMAR):");
        pilha2.imprimir();

        if (pilha2.Palindromo())
        {
            Console.WriteLine("Resposta: É PALÍNDROMO");
        }
        else
        {
            Console.WriteLine("Resposta: NÃO É PALÍNDROMO");
        }
    }


        }   

    } 
