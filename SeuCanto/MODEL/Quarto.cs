using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCanto
{
    class Quarto
    {
        
        private int nro_quarto;       
        private string tipo;
        private int qtdePessoas;
        private decimal precoDia;
        

        public int Nro_quarto { get => nro_quarto; set => nro_quarto = value; }       
        public string Tipo { get => tipo; set => tipo = value; }
        public int QtdePessoas { get => qtdePessoas; set => qtdePessoas = value; }        
        public decimal PrecoDia { get => precoDia; set => precoDia = value; }
        
    }
}
