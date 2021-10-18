using System;
using System.Collections.Generic;
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando a lista de strings
            List<string> list = new List<String>();

            //Adicionando elementos na Lista
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("Andre");
            //Adiciona um elemento na posição sugerida
            list.Insert(2, "Lucas");

            //Realiza um loop de leitura dos elementos 
            foreach (string obj in list)
            {
                //Conta quantos Elementos que tem em minha Lista
                Console.WriteLine("Elementos que tem em minha Lista: " + list.Count);
                //Ele Encontra o primeiro elemento com que começa com a letra A,Usando a função lambda
                string s1 = list.Find(x => x[0] == 'A'); Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //Ele Encontra o Ultimo elemento que termina com a letra A,Usando a função lambda
                string s2 = list.FindLast(x => x[0] == 'A'); Console.WriteLine("Primeiro elemento que começa com a letra A: " + s2);
            }

            //Busca o elemento pela sua Posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição de 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última Posição de 'A': " + pos2);
            //Busca todos os elementos com tamanho de 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

                // Tira coisa da lista
                list.Remove("Andre");
                Console.WriteLine("===================");
                foreach (string obj in list)
                {
                    Console.WriteLine(obj);
                }

                //Tira um determinado Elemento
                list.RemoveAll(x => x[0] == 'W');
                Console.WriteLine("+++++++++++++++++++");
                foreach (string obj in list)
                {
                    Console.WriteLine(obj);
                }

                //Tira um determinado Elemento da posição da lista
                list.RemoveAt(3);
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                foreach (string obj in list)
                {
                    Console.WriteLine(obj);
                }

                //Tira elementos da lista a partir da posição e quantos elementos vai remover
                list.RemoveRange(1, 2);
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                foreach (string obj in list)
                {
                    Console.WriteLine(obj);
                }
        }
    }
} 



          
