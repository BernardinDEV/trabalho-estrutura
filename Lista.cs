using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;

namespace Trabalho
{
    public class Lista
    {

        public Node head;
        public Node tail;
        public Node contato;


        public Lista()
        {
            head = null;

        }

        // Crud

        public void addList(string nome, string email, string numero)
        {
            var newNode = new Node(nome, email, numero);
            Node aux = head;
            if (head != null)
            {
                while (aux.next != head)
                {
                    aux = aux.next;
                }


            } else
            {
                aux = newNode;
            }
            newNode.next = head;
            head = newNode;
            aux.next = head;
           
        }
        public void removeList(string achar)
        {
            if (head == null)
            {
                Console.Write("Lista Vazia.");
            }
            Node aux = head;
            Node ant = null;
            if (achar == head.nome && head.next == head)
            {
                head = null;
                Console.WriteLine("Contato removido");

            }
            else if(achar == head.nome && head.next != head)
            {
                head = head.next;
                head.next = head;
                

                Console.WriteLine("Contato removido");

            }

            else
            {
                
                while (aux.nome != achar && ant != head)
                {
                    ant = aux;
                    aux = aux.next;

                }
                if (achar == aux.nome)
                {
                    ant.next = aux.next;
                    Console.WriteLine("Contato removido");
                }
                else {
                    Console.WriteLine("Contato nao encontrado");
                }

            }
            


        }
        public void update(string nome, string email, string numero, string achar)
        {
           var aux2 = encontar(achar);
            if (aux2.nome == achar)
            {
                aux2.nome = nome;
                aux2.numero = numero;
                aux2.email = email;
                Console.WriteLine("Contato atualizado com sucesso");
            }
            else {
                Console.WriteLine("Nao encontrado");
            }

        }
        public  Node encontar(string nome)
        {
            if (head == null)
            {
                Console.Write("Lista Vazia.");
            }
            var aux = head;
            if (aux.nome == nome)
            {
                Console.WriteLine($"-> [{aux.nome},{aux.email},{aux.numero}]");
                return aux;
            }
           
            
                aux = aux.next;
                while (aux.nome != nome && aux == head)
                {
                    aux = aux.next;
                }
                if (aux.nome == nome)
                {
                    Console.WriteLine($"-> [{aux.nome},{aux.email},{aux.numero}");
                    return aux;
                }
                else
                {
                    Console.WriteLine("Contato nao encontrado");
                    return head;
                }

            

        }
        //print
        public void printList()
        {

            if (head == null)
            {
                Console.Write("Lista Vazia.");
            }
            Console.Write("[HEAD]");
            var aux = head;
            try
            {
                do
                {
                    Console.Write($"-> [{aux.nome},{aux.email},{aux.numero}]");
                    aux = aux.next;
                } while (aux != head);

                Console.Write("-> [HEAD]");
            }
            catch
            {
                Console.WriteLine("\nErro");
            }
            }
        // salvar 
        public void salvarEmAqruivo()
        {
            if (head == null)
            {
                Console.Write("Lista Vazia.");
            }
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("text", true))
                try
            {
                
               
                var aux = head;

                do
                {
                    sw.Write($"-> [{aux.nome},{aux.email},{aux.numero}]");
                    aux = aux.next;
                } while (aux != head);

                sw.Write("-> [HEAD]");
                Console.WriteLine("Gravado com sucesso");

               
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
           // Ordenarçao
        }
        public void ordenarNome()
        {
            if (head == null)
            {
                Console.Write("Lista Vazia.");
            }

        }
        public void ordenarEmail()
        {
            if (head == null)
            {
                Console.Write("Lista Vazia.");
            }
            List <string> ls = new List <string>();
            var aux = head;
            do
            {
               
                Console.Write($"-> [{aux.nome},{aux.email},{aux.numero}]");
                ls.Add(aux.nome);
                
                
                aux = aux.next;
            } while (aux != head);

            ls.Sort();

        }
        public void navegaçao()
        {

            if (head == null)
            {
                Console.Write("Lista Vazia.");
            }
            Console.Write($"-> [{head.nome},{head.email},{head.numero}]");
            head = head.next;

        }
      




    } 
        
}
