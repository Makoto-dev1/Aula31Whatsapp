using System;

namespace Aula31Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda contacts = new Agenda();
            Contato p1 = new Contato("Paulao","(11) 91234-5678");


            Mensagem texto = new Mensagem();
            texto.Texto = "Opa!";
            texto.Destinatario = p1;


            contacts.Cadastrar(p1);
            contacts.Excluir("linha");
            System.Console.WriteLine(texto.Enviar(texto.Destinatario));       
        }
    }
}
