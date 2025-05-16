using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Conversor
{
    public class Transaccio
    {
        public string Client { get; set; }
        public string Email { get; set; }
        public string Data_transaccio { get; set; }
        public string Divisa1 { get; set; }
        public string Divisa2 { get; set; }
        public double Import1 { get; set; }
        public double Import2 { get; set; }
        public bool Descompte1 { get; set; }
        public bool Descompte2 { get; set; }
        private bool _Comprat { get; set; }
        private bool _Venut { get; set; }

        public Transaccio(string client, string email, string data_transaccio, string divisa1, string divisa2, double import1, double import2, bool descompte1, bool descompte2, bool comprat)
        {
            Client = client;
            Email = email;
            Data_transaccio = data_transaccio;
            Divisa1 = divisa1;
            Divisa2 = divisa2;
            Import1 = import1;
            Import2 = import2;
            Descompte1 = descompte1;
            Descompte2 = descompte2;
            Comprat = comprat;
        }

        public bool Venut
        {
            get => _Venut;
            set
            {
                _Venut = value;
                _Comprat = !value;
            }
        }
        public bool Comprat
        {
            get => _Comprat;
            set
            {
                _Venut = !value;
                _Comprat = value;
                
            }
        }

    }
}
