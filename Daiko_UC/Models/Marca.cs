using System;
using System.Collections.Generic;
using System.Text;

namespace Daiko_UC.Models
{
    public class Marca
    {
        private int _id_marca;
        private string _nombre;

        public Marca(string nombre, int id_marca=0)
        {
            _id_marca = id_marca;
            _nombre = nombre;
        }

        public int Id_marca { get => _id_marca; set => _id_marca = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
