using System;
using System.Collections.Generic;



namespace atv3.Models
{
    public class agenda
    {
        private List<agendamento> agendamento;

        public agenda(){
            agendamento = new List<agendamento>();
        }

        public void AddClientes(string nome, string telefone, string data, string animal, string necessidades){
            agendamento.Add(new agendamento(nome, telefone, data, animal, necessidades));
        }

        public List<agendamento> Lista(){
            return agendamento;
        }
    }
}