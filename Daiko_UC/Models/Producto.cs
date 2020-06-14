using System;
using System.Collections.Generic;
using System.Text;

namespace Daiko_UC.Models
{
    public class Producto
    {
        private int _id_producto;
        private int _id_almacen;
        private string _codigo_interno;
        private string _nombre;
        private int _id_familia;
        private int _id_marca;
        private DateTime _fecha_alta;
        private DateTime _fecha_baja;
        private string _descripcion;
        private decimal _precio_sin_iva;
        private int _iva;
        private decimal _precio_mayorista;
        private int _stock_minimo;
        private int _stock;
        private int _pedido_minimo;
        private byte[] _imagen;

        public Producto(int id_almacen, string codigo_interno, string nombre, int id_familia, int id_marca, DateTime fecha_alta, DateTime fecha_baja, string descripcion, decimal precio_sin_iva, int iva, decimal precio_mayorista, int stock_minimo, int stock, int pedido_minimo, byte[] imagen, int id_producto=0)
        {
            _id_producto = id_producto;
            _id_almacen = id_almacen;
            _codigo_interno = codigo_interno;
            _nombre = nombre;
            _id_familia = id_familia;
            _id_marca = id_marca;
            _fecha_alta = fecha_alta;
            _fecha_baja = fecha_baja;
            _descripcion = descripcion;
            _precio_sin_iva = precio_sin_iva;
            _iva = iva;
            _precio_mayorista = precio_mayorista;
            _stock_minimo = stock_minimo;
            _stock = stock;
            _pedido_minimo = pedido_minimo;
            _imagen = imagen;
        }

        public int Id_producto { get => _id_producto; set => _id_producto = value; }
        public int Id_almacen { get => _id_almacen; set => _id_almacen = value; }
        public string Codigo_interno { get => _codigo_interno; set => _codigo_interno = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Id_familia { get => _id_familia; set => _id_familia = value; }
        public int Id_marca { get => _id_marca; set => _id_marca = value; }
        public DateTime Fecha_alta { get => _fecha_alta; set => _fecha_alta = value; }
        public DateTime Fecha_baja { get => _fecha_baja; set => _fecha_baja = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public decimal Precio_sin_iva { get => _precio_sin_iva; set => _precio_sin_iva = value; }
        public int Iva { get => _iva; set => _iva = value; }
        public decimal Precio_mayorista { get => _precio_mayorista; set => _precio_mayorista = value; }
        public int Stock_minimo { get => _stock_minimo; set => _stock_minimo = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int Pedido_minimo { get => _pedido_minimo; set => _pedido_minimo = value; }
        public byte[] Imagen { get => _imagen; set => _imagen = value; }
    }
}
