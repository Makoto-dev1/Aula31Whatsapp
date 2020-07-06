namespace Aula31Whatsapp
{
    public class Mensagem
    {
        public string Texto {get; set;}
        public Contato Destinatario {get; set;}
        public string Enviar(Contato Destinatario){
            
            return $"Sua mensagem: '{Texto}' foi enviada para: {Destinatario.Nome}";
        }
    }
}