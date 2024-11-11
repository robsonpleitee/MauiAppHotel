﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {

        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }

        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get 
            
            {
            double valorAdultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
            double valorCriancas = QntCriancas * QuartoSelecionado.ValorDiariaCriança;


                double total =(valorAdultos+ valorCriancas) * Estadia;

                return total;
            }
        }

    }
}
