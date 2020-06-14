using System;
using System.Collections.Generic;
using System.Text;

namespace Daiko_UC.Models
{
    public class Familia
    {
        private int _id_familia;
        private string _nombre_familia;
        private int _id_estado;

        public Familia(string nombre_familia, int id_estado, int id_familia=0)
        {
            Id_familia = id_familia;
            Nombre_familia = nombre_familia;
            Id_estado = id_estado;
        }

        public int Id_familia { get => _id_familia; set => _id_familia = value; }
        public string Nombre_familia { get => _nombre_familia; set => _nombre_familia = value; }
        public int Id_estado { get => _id_estado; set => _id_estado = value; }
    }
}
