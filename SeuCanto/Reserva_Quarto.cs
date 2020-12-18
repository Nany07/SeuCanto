using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCanto
{
    class Reserva_Quarto
    {
        private string nomeCliente;               
        private Cliente cliente;
        private string precoQuarto;       
        private Quarto quarto;
        private DateTime dataIniAluguel;               
        private DateTime dataEntrega;
        private decimal precoTotal;
        private int codReserva;
        private int codFunc;


        public int CodReserva { get => codReserva; set => codReserva = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public String PrecoQuarto { get => precoQuarto; set => precoQuarto = value; }
        public decimal PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public DateTime DataIniAluguel { get => dataIniAluguel; set => dataIniAluguel = value; }        
        public DateTime DataEntrega { get => dataEntrega; set => dataEntrega = value; }                     
        internal Quarto Quarto { get => quarto; set => quarto = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public int CodFunc { get => codFunc; set => codFunc = value; }
    }
}
