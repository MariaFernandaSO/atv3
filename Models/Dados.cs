namespace atv3.Models
{
    public class Dados
    {
        public static agenda agendaAtual { get; set; }
        static Dados()
        {
            agendaAtual = new agenda();
        }
    }
}