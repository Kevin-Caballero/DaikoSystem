using System;
using System.Collections.Generic;
using System.Text;

namespace Daiko_UC.Models
{
    public class Almacen
    {
        private int _id_almacen;
        private string _nombre;
        private string _telefono;
        private string _direccion;
        private string _codigo_postal;
        private int _id_pais;
        private string _provincia;
        private string _localidad;
        private string _gestion_inventario;
        private string _responsable;
        private string _nota;

        public Almacen(string nombre, string telefono, string direccion, string codigo_postal, int id_pais, string provincia, string localidad, string gestion_inventario, string responsable, string nota, int id=0)
        {
            _id_almacen = id;
            _nombre = nombre;
            _telefono = telefono;
            _direccion = direccion;
            _codigo_postal = codigo_postal;
            _id_pais = id_pais;
            _provincia = provincia;
            _localidad = localidad;
            _gestion_inventario = gestion_inventario;
            _responsable = responsable;
            _nota = nota;
        }

        public int Id_almacen { get => _id_almacen; set => _id_almacen = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Codigo_postal { get => _codigo_postal; set => _codigo_postal = value; }
        public int Id_pais { get => _id_pais; set => _id_pais = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public string Gestion_inventario { get => _gestion_inventario; set => _gestion_inventario = value; }
        public string Responsable { get => _responsable; set => _responsable = value; }
        public string Nota { get => _nota; set => _nota = value; }
    }
}
