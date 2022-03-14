namespace atv3.Models
{
    public class agendamento
    {
        public string nome {get; set;}
        public string telefone {get; set;}
        public string data {get; set;}
        public string animal {get; set;}
        public string necessidades {get; set;}


        public agendamento (string n, string t, string d, string a, string ne){
            nome = n;
            telefone = t;
            data = d;
            animal = a;
            necessidades = ne;
        }

        public agendamento(){

        }
    }
}