using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using Daiko_UC.Models;

namespace Daiko_DAL
{
    public class Daiko_DAL
    {
        private static string cadenaConexion = "";


        public int InsertarEmpresa(Daiko_UC.Models.Empresa nuevaEmpresa)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "INSERT INTO [General].Empresa (id_empresa,razon_social,nombre_comercial,cif,direccion_fiscal,codigo_postal,telefono,fax,logo) " +
                                      "VALUES (@p_id_empresa,@p_razon_social,@p_nombre_comercial,@p_cif,@p_codigo_postal,@p_direccion_fiscal,@p_telefono,@p_fax,@p_logo)";

                int id = ObtenerSiguienteID("General", "Empresa", "id_empresa");

                comando.Parameters.AddWithValue("@p_id_empresa", id);
                comando.Parameters.AddWithValue("@p_razon_social", nuevaEmpresa.Razon_social);
                comando.Parameters.AddWithValue("@p_nombre_comercial", nuevaEmpresa.Nombre_comercial);
                comando.Parameters.AddWithValue("@p_cif", nuevaEmpresa.Cif);
                comando.Parameters.AddWithValue("@p_direccion_fiscal", nuevaEmpresa.Direccion_fiscal);
                comando.Parameters.AddWithValue("@p_codigo_postal", nuevaEmpresa.Codigo_postal);
                comando.Parameters.AddWithValue("@p_telefono", nuevaEmpresa.Telefono);
                comando.Parameters.AddWithValue("@p_fax", nuevaEmpresa.Fax);
                comando.Parameters.AddWithValue("@p_logo", nuevaEmpresa.Logo);

                comando.Connection = conexion;

                conexion.Open();

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"),id + " " + nuevaEmpresa.Razon_social + " " + nuevaEmpresa.Nombre_comercial + " " + nuevaEmpresa.Cif + " " + nuevaEmpresa.Direccion_fiscal + " " + nuevaEmpresa.Codigo_postal + " " + nuevaEmpresa.Telefono + " " + nuevaEmpresa.Fax + " " );

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message);
            }
            return 0;
        }

        public int InsertarMarca(Marca nuevaMarca)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "INSERT INTO [Almacen].marcas (id_marca,nombre) " +
                    "VALUES (@p_id_marca,@p_nombre)";

                int id = ObtenerSiguienteID("Almacen","marcas","id_marca");

                comando.Parameters.AddWithValue("@p_id_marca",id);
                comando.Parameters.AddWithValue("@p_nombre",nuevaMarca.Nombre);

                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: InsertarMarca()");
                return 0;
            }
        }

        public int InsertarFamilia(Familia nuevaFamilia)
        {
            try
            {

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "INSERT INTO [Almacen].familias (id_familia,codigo_familia,id_estado) " +
                    "VALUES (@p_id_familia,@p_codigo_familia,@p_id_estado)";

                int id = ObtenerSiguienteID("Almacen","familias","id_familia");

                comando.Parameters.AddWithValue("@p_id_familia",id);
                comando.Parameters.AddWithValue("@p_codigo_familia", nuevaFamilia.Nombre_familia);
                comando.Parameters.AddWithValue("@p_id_estado", nuevaFamilia.Id_estado);

                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message);
                return 0;
            }
        }

        public int InsertarProducto(Producto nuevoProducto)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "INSERT INTO Almacen.Catalogo (id_producto,id_almacen,codigo_interno,nombre,id_familia,id_marca,fecha_alta,fecha_baja,descripcion,precio_sin_iva,iva,precio_mayorista,stock_minimo,stock,pedido_minimo,imagen)" +
                    "VALUES (@p_id_producto,@p_id_almacen,@p_codigo_interno,@p_nombre,@p_id_familia,@p_id_marca,@p_fecha_alta,@p_fecha_baja,@p_descripcion,@p_precio_sin_iva,@p_iva,@p_precio_mayorista,@p_stock_minimo,@p_stock,@p_pedido_minimo,@p_imagen) ";

                int id = ObtenerSiguienteID("Almacen","catalogo","id_producto");

                comando.Parameters.AddWithValue("@p_id_producto",id);
                comando.Parameters.AddWithValue("@p_id_almacen",nuevoProducto.Id_almacen);
                comando.Parameters.AddWithValue("@p_nombre", nuevoProducto.Nombre);
                comando.Parameters.AddWithValue("@p_codigo_interno",nuevoProducto.Codigo_interno);
                comando.Parameters.AddWithValue("@p_id_familia",nuevoProducto.Id_familia);
                comando.Parameters.AddWithValue("@p_id_marca",nuevoProducto.Id_marca);
                comando.Parameters.AddWithValue("@p_fecha_alta",nuevoProducto.Fecha_alta);
                comando.Parameters.AddWithValue("@p_fecha_baja",nuevoProducto.Fecha_baja);
                comando.Parameters.AddWithValue("@p_descripcion",nuevoProducto.Descripcion);
                comando.Parameters.AddWithValue("@p_precio_sin_iva",nuevoProducto.Precio_sin_iva);
                comando.Parameters.AddWithValue("@p_iva",nuevoProducto.Iva);
                comando.Parameters.AddWithValue("@p_precio_mayorista",nuevoProducto.Precio_mayorista);
                comando.Parameters.AddWithValue("@p_stock_minimo",nuevoProducto.Stock_minimo);
                comando.Parameters.AddWithValue("@p_stock",nuevoProducto.Stock);
                comando.Parameters.AddWithValue("@p_pedido_minimo",nuevoProducto.Pedido_minimo);
                comando.Parameters.AddWithValue("@p_imagen",nuevoProducto.Imagen);

                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: InsertarProducto()");
            }
            return 0;
        }

        public int InsertarAlmacen(Almacen nuevoAlmacen)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "INSERT INTO Almacen.almacenes (id_almacen,nombre,telefono,direccion,codigo_postal,id_pais,provincia,localidad,gestion_inventario,responsable,nota) " +
                    "VALUES (@p_id_almacen,@p_nombre,@p_telefono,@p_direccion,@p_codigo_postal,@p_id_pais,@p_provincia,@p_localidad,@p_gestion_inventario,@p_responsable,@p_nota)";

                int id = ObtenerSiguienteID("Almacen", "almacenes", "id_almacen");

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), comando.CommandText);

                comando.Parameters.AddWithValue("@p_id_almacen", id);
                comando.Parameters.AddWithValue("@p_nombre", nuevoAlmacen.Nombre);
                comando.Parameters.AddWithValue("@p_telefono", nuevoAlmacen.Telefono);
                comando.Parameters.AddWithValue("@p_direccion", nuevoAlmacen.Direccion);
                comando.Parameters.AddWithValue("@p_codigo_postal", nuevoAlmacen.Codigo_postal);
                comando.Parameters.AddWithValue("@p_id_pais", nuevoAlmacen.Id_pais);
                comando.Parameters.AddWithValue("@p_provincia", nuevoAlmacen.Provincia);
                comando.Parameters.AddWithValue("@p_localidad", nuevoAlmacen.Localidad);
                comando.Parameters.AddWithValue("@p_gestion_inventario", nuevoAlmacen.Gestion_inventario);
                comando.Parameters.AddWithValue("@p_responsable", nuevoAlmacen.Responsable);
                comando.Parameters.AddWithValue("@p_nota", nuevoAlmacen.Nota);


                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: InsertarAlmacen()");
            }
            return 0;
        }


        public int ActualizarEmpresa(Daiko_UC.Models.Empresa empresaActualizada)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                if (empresaActualizada.Logo != Array.Empty<byte>())
                {
                    comando.CommandText = "UPDATE [General].Empresa SET " +
                                      "razon_social = @p_razon_social, nombre_comercial = @p_nombre_comercial, cif = @p_cif, " +
                                      "direccion_fiscal = @p_direccion_fiscal, codigo_postal = @p_codigo_postal, telefono = @p_telefono, fax = @p_fax, logo = @p_logo";

                    comando.Parameters.AddWithValue("@p_razon_social", empresaActualizada.Razon_social);
                    comando.Parameters.AddWithValue("@p_nombre_comercial", empresaActualizada.Nombre_comercial);
                    comando.Parameters.AddWithValue("@p_cif", empresaActualizada.Cif);
                    comando.Parameters.AddWithValue("@p_direccion_fiscal", empresaActualizada.Direccion_fiscal);
                    comando.Parameters.AddWithValue("@p_codigo_postal", empresaActualizada.Codigo_postal);
                    comando.Parameters.AddWithValue("@p_telefono", empresaActualizada.Telefono);
                    comando.Parameters.AddWithValue("@p_fax", empresaActualizada.Fax);
                    comando.Parameters.AddWithValue("@p_logo", empresaActualizada.Logo);
                }
                else
                {
                    comando.CommandText = "UPDATE [General].Empresa SET " +
                                      "razon_social = @p_razon_social, nombre_comercial = @p_nombre_comercial, cif = @p_cif, " +
                                      "direccion_fiscal = @p_direccion_fiscal, codigo_postal = @p_codigo_postal, telefono = @p_telefono, fax = @p_fax";

                    comando.Parameters.AddWithValue("@p_razon_social", empresaActualizada.Razon_social);
                    comando.Parameters.AddWithValue("@p_nombre_comercial", empresaActualizada.Nombre_comercial);
                    comando.Parameters.AddWithValue("@p_cif", empresaActualizada.Cif);
                    comando.Parameters.AddWithValue("@p_direccion_fiscal", empresaActualizada.Direccion_fiscal);
                    comando.Parameters.AddWithValue("@p_codigo_postal", empresaActualizada.Codigo_postal);
                    comando.Parameters.AddWithValue("@p_telefono", empresaActualizada.Telefono);
                    comando.Parameters.AddWithValue("@p_fax", empresaActualizada.Fax);
                }

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), empresaActualizada.Razon_social + " " + empresaActualizada.Nombre_comercial + " " + empresaActualizada.Cif + " " + empresaActualizada.Direccion_fiscal + " " + empresaActualizada.Codigo_postal + " " + empresaActualizada.Telefono + " " + empresaActualizada.Fax + " " + empresaActualizada.Logo);

                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ActualizarEmpresa()");
            }
            return 0;
        }

        public int ActualizarAlmacen(Daiko_UC.Models.Almacen almacenActualizado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "UPDATE [Almacen].almacenes " +
                    "SET nombre = @p_nombre, telefono = @p_telefono, direccion = @p_direccion, codigo_postal = @p_codigo_postal, id_pais = @p_id_pais, " +
                    "provincia = @p_provincia, localidad = @p_localidad, gestion_inventario = @p_gestion_inventario, responsable = @p_responsable, nota = @p_nota " +
                    "WHERE id_almacen = @p_id_almacen";

                comando.Parameters.AddWithValue("@p_nombre", almacenActualizado.Nombre);
                comando.Parameters.AddWithValue("@p_telefono", almacenActualizado.Telefono);
                comando.Parameters.AddWithValue("@p_direccion", almacenActualizado.Direccion);
                comando.Parameters.AddWithValue("@p_codigo_postal", almacenActualizado.Codigo_postal);
                comando.Parameters.AddWithValue("@p_id_pais", almacenActualizado.Id_pais);
                comando.Parameters.AddWithValue("@p_provincia", almacenActualizado.Provincia);
                comando.Parameters.AddWithValue("@p_localidad", almacenActualizado.Localidad);
                comando.Parameters.AddWithValue("@p_gestion_inventario", almacenActualizado.Gestion_inventario);
                comando.Parameters.AddWithValue("@p_responsable", almacenActualizado.Responsable);
                comando.Parameters.AddWithValue("@p_nota", almacenActualizado.Nota);
                comando.Parameters.AddWithValue("@p_id_almacen", almacenActualizado.Id_almacen);

                comando.Connection = conexion;

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), almacenActualizado.Id_almacen + " " + almacenActualizado.Nombre + " " + almacenActualizado.Telefono + " " + almacenActualizado.Direccion + " " + almacenActualizado.Codigo_postal + " " + almacenActualizado.Codigo_postal + " " + almacenActualizado.Id_pais + " " + almacenActualizado.Provincia + " " + almacenActualizado.Localidad + " " + almacenActualizado.Gestion_inventario + " " + almacenActualizado.Responsable + " " + almacenActualizado.Nota);

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ActualizarAlmacen()");
            }
            return 0;
        }

        public int ActializarFamilia(Familia familiaActualizada)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "UPDATE [Almacen].familias " +
                    "SET codigo_familia = @p_nombre_familia, id_estado = @p_id_estado " +
                    "WHERE id_familia = @p_id_familia";

                comando.Parameters.AddWithValue("@p_nombre_familia", familiaActualizada.Nombre_familia);
                comando.Parameters.AddWithValue("@p_id_estado", familiaActualizada.Id_estado);
                comando.Parameters.AddWithValue("@p_id_familia", familiaActualizada.Id_familia);

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), familiaActualizada.Nombre_familia + " " + familiaActualizada.Id_estado.ToString() + " " + familiaActualizada.Id_familia.ToString());

                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ActualizarAlmacen()");
            }
            return 0;
        }

        public int ActualizarMarca(Marca marcaActualizada)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "UPDATE [Almacen].marcas " +
                    "SET nombre = @p_nombre " +
                    "WHERE id_marca = @p_id_marca";

                comando.Parameters.AddWithValue("@p_id_marca", marcaActualizada.Id_marca);
                comando.Parameters.AddWithValue("@p_nombre", marcaActualizada.Nombre);

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), familiaActualizada.Nombre_familia + " " + familiaActualizada.Id_estado.ToString() + " " + familiaActualizada.Id_familia.ToString());

                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ActualizarMarca()");
                return 0;
            }
        }

        public int ActualizarProducto(Producto productoActualizado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "UPDATE [Almacen].catalogo " +
                    "SET id_producto = @p_id_producto, id_almacen = @p_id_almacen, codigo_interno = @p_codigo_interno, nombre = @p_nombre, id_familia = @p_id_familia, id_marca = @p_id_marca, fecha_alta = @p_fecha_alta, fecha_baja = @p_fecha_baja, descripcion = @p_descripcion, precio_sin_iva = @p_precio_sin_iva, iva = @p_iva, precio_mayorista = @p_precio_mayorista,stock_minimo = @p_stock_minimo, pedido_minimo = @p_pedido_minimo, imagen = @p_imagen " +
                    " WHERE id_producto = @p_id_producto";

                comando.Parameters.AddWithValue("@p_id_producto", productoActualizado.Id_producto);
                comando.Parameters.AddWithValue("@p_id_almacen", productoActualizado.Id_almacen);
                comando.Parameters.AddWithValue("@p_nombre", productoActualizado.Nombre);
                comando.Parameters.AddWithValue("@p_codigo_interno", productoActualizado.Codigo_interno);
                comando.Parameters.AddWithValue("@p_id_familia", productoActualizado.Id_familia);
                comando.Parameters.AddWithValue("@p_id_marca", productoActualizado.Id_marca);
                comando.Parameters.AddWithValue("@p_fecha_alta", productoActualizado.Fecha_alta);
                comando.Parameters.AddWithValue("@p_fecha_baja", productoActualizado.Fecha_baja);
                comando.Parameters.AddWithValue("@p_descripcion", productoActualizado.Descripcion);
                comando.Parameters.AddWithValue("@p_precio_sin_iva", productoActualizado.Precio_sin_iva);
                comando.Parameters.AddWithValue("@p_iva", productoActualizado.Iva);
                comando.Parameters.AddWithValue("@p_precio_mayorista", productoActualizado.Precio_mayorista);
                comando.Parameters.AddWithValue("@p_stock_minimo", productoActualizado.Stock_minimo);
                comando.Parameters.AddWithValue("@p_pedido_minimo", productoActualizado.Pedido_minimo);
                comando.Parameters.AddWithValue("@p_imagen", productoActualizado.Imagen);

                comando.Connection = conexion;

                System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), productoActualizado.Id_producto + " " + productoActualizado.Id_almacen + " " + productoActualizado.Nombre + " " + productoActualizado.Codigo_interno + " " + productoActualizado.Id_familia + " " + productoActualizado.Id_marca + " " + productoActualizado.Fecha_alta + " " + productoActualizado.Fecha_baja + " " + productoActualizado.Descripcion + " " + productoActualizado.Precio_sin_iva + " " + productoActualizado.Iva + " " + productoActualizado.Precio_mayorista + " " + productoActualizado.Stock_minimo + " " + productoActualizado.Pedido_minimo);

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ActualizarProducto()");
            }
            return 0;
        }


        public int Eliminar(string modulo, string tabla, string nombreColumnaClave, int id)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "DELETE FROM [" + modulo + "]." + tabla + " WHERE " + nombreColumnaClave + " = " + id;

                comando.Connection = conexion;

                conexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }

                conexion.Close();

                return -1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: Eliminar()");
            }
            return 0;
        }


        public DataTable ConsultaPaginada(string modulo, string tabla, string parametrosSelect, int offset, int registrosPagina, string orden, int numColumnaOrdenacion)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                DataTable datos = new DataTable();

                SqlCommand comando = new SqlCommand("SELECT " + parametrosSelect + " FROM [" + modulo + "]." + tabla + " ORDER BY " + numColumnaOrdenacion + " " + orden + " offset " + offset + " rows fetch next " + registrosPagina + " rows only", conexion);

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), comando.CommandText);

                conexion.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(comando))
                {
                    da.Fill(datos);
                }

                conexion.Close();

                return datos;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ConsultaPaginada()");
            }
            return null;
        }

        public DataTable ConsultaPaginadaJoin(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string parametrosSelect, int offset, int registrosPagina, string orden, int numColumnaOrdenacion)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand("SELECT " + parametrosSelect + " FROM [" + modulo1 + "]." + tabla1 + " " +
                                    "JOIN " + "[" + modulo2 + "]." + tabla2 + " " +
                                    "ON [" + modulo1 + "]." + tabla1 + "." + campoRelacionado1 + " = " + "[" + modulo2 + "]." + tabla2 + "." + campoRelacionado2 + " " +
                                    "ORDER BY " + numColumnaOrdenacion + " " + orden + " offset " + offset + " rows fetch next " + registrosPagina + " rows only",conexion);

                DataTable datos = new DataTable();

                conexion.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(comando))
                {
                    da.Fill(datos);
                }

                conexion.Close();

                return datos;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ConsultaPaginadaJoin()");
                return null;
            }
        }

        public DataTable ConsultaPaginadaJoin(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string modulo3, string tabla3, string campoRelacionado3, string parametrosSelect, int offset, int registrosPagina, string orden, int numColumnaOrdenacion)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand("SELECT " + parametrosSelect + " FROM [" + modulo1 + "]." + tabla1 + " " +
                                    "JOIN " + "[" + modulo2 + "]." + tabla2 + " " +
                                    "ON [" + modulo1 + "]." + tabla1 + "." + campoRelacionado2 + " = " + "[" + modulo2 + "]." + tabla2 + "." + campoRelacionado2 + " " +
                                    "JOIN " + "[" + modulo3 + "]." + tabla3 + " " +
                                    "ON [" + modulo1 + "]." + tabla1 + "." + campoRelacionado3 + " = " + "[" + modulo3 + "]." + tabla3 + "." + campoRelacionado3 + " " +
                                    "ORDER BY " + numColumnaOrdenacion + " " + orden + " offset " + offset + " rows fetch next " + registrosPagina + " rows only", conexion);

                DataTable datos = new DataTable();

                conexion.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(comando))
                {
                    da.Fill(datos);
                }

                conexion.Close();

                return datos;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ConsultaPaginadaJoin()");
                return null;
            }
        }

        public DataTable ConsultaTotal(string modulo, string tabla, string parametrosSelect)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                DataTable datos = new DataTable();


                comando.CommandText = "SELECT " + parametrosSelect + " FROM [" + modulo + "]." + tabla;

                comando.Connection = conexion;

                conexion.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(comando))
                {
                    da.Fill(datos);
                }

                conexion.Close();

                return datos;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ConsultaTotal()");
                return null;
            }
        }

        public DataTable ConsultaTotalJoin(string modulo1, string tabla1,string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string parametrosSelect)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                DataTable datos = new DataTable();

                comando.CommandText = "SELECT " + parametrosSelect + " FROM [" + modulo1 + "]." + tabla1 + " JOIN " + " [" + modulo2 + "]." + tabla2 + " " +
                    "ON [" + modulo1 + "]." + tabla1 + "." + campoRelacionado1 + " = " + "[" + modulo2 + "]." + tabla2 + "." + campoRelacionado2;

                comando.Connection = conexion;

                conexion.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(comando))
                {
                    da.Fill(datos);
                }

                conexion.Close();

                return datos;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ConsultaTotalJoin()");
                return null;
            }
        }

        public DataTable ConsultaTotalJoin(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string modulo3, string tabla3, string campoRelacionado3, string parametrosSelect)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                DataTable datos = new DataTable();

                comando.CommandText = "SELECT " + parametrosSelect + " FROM [" + modulo1 + "]." + tabla1 + " " +
                                    "JOIN " + "[" + modulo2 + "]." + tabla2 + " " +
                                    "ON [" + modulo1 + "]." + tabla1 + "." + campoRelacionado2 + " = " + "[" + modulo2 + "]." + tabla2 + "." + campoRelacionado2 + " " +
                                    "JOIN " + "[" + modulo3 + "]." + tabla3 + " " +
                                    "ON [" + modulo1 + "]." + tabla1 + "." + campoRelacionado3 + " = " + "[" + modulo3 + "]." + tabla3 + "." + campoRelacionado3;


                comando.Connection = conexion;

                conexion.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(comando))
                {
                    da.Fill(datos);
                }

                conexion.Close();

                return datos;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ConsultaTotalJoin()");
                return null;
            }
        }



        public int NumRegistros(string modulo, string tabla)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "SELECT COUNT(*) FROM [" + modulo + "]." + tabla;

                comando.Connection = conexion;

                conexion.Open();

                int res = (int)comando.ExecuteScalar();

                conexion.Close();

                return res;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: NumRegistros()");
            }
            return 0;
        }

        private int ObtenerSiguienteID(string modulo, string tabla, string nombreColumnaClave)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "SELECT TOP 1 " + nombreColumnaClave + " FROM [" + modulo + "]." + tabla + " ORDER BY " + nombreColumnaClave + " DESC";

                System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), comando.CommandText);
                comando.Connection = conexion;

                conexion.Open();

                var res = comando.ExecuteScalar();

                return res is null ? 1 : (int)res + 1;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ObtenerSiguienteID()");
            }
            return 0;
        }

        public Daiko_UC.Models.Empresa ObtenerDatosEmpresa()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "SELECT * FROM [General].Empresa";

                comando.Connection = conexion;

                conexion.Open();

                SqlDataReader dr;

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        string razonSocial = dr.GetString(1);
                        string nombreComercial = dr.GetString(2);
                        string cif = dr.GetString(3);
                        string codigoFiscal = dr.GetString(4);
                        string codigoPostal = dr.GetString(5);
                        string telefono = dr.GetString(6);
                        string fax = dr.GetString(7);
                        byte[] logo = (byte[])dr[8];

                        Daiko_UC.Models.Empresa empresa = new Daiko_UC.Models.Empresa(razonSocial, nombreComercial, cif, codigoFiscal, codigoPostal, telefono, fax, logo);
                        return empresa;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ObtenerDatosEmpresa()");
                return null;
            }
        }

        public object ObtenerDatos(string modulo, string tabla, string parametrosSelect, string nombreColumnaClave, int id)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                object objeto = new object();

                comando.CommandText = "SELECT " + parametrosSelect + " FROM [" + modulo + "]." + tabla + " WHERE " + nombreColumnaClave + " = " + id;

                comando.Connection = conexion;

                conexion.Open();

                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), comando.CommandText);

                SqlDataReader dr;

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    switch (tabla.ToLower())
                    {
                        case "almacenes":
                            if (dr.Read())
                            {

                                //crear objeto almacen y convertirlo a objeto generico para devolverlo
                                int id_almacen = dr.GetInt32(0);
                                string nombre = dr.GetString(1);
                                string telefono = dr.GetString(2);
                                string direccion = dr.GetString(3);
                                string codigo_postal = dr.GetString(4);
                                int id_pais = dr.GetInt32(5);
                                string provincia = dr.GetString(6);
                                string localidad = dr.GetString(7);
                                string gestion_inventario = dr.GetString(8);
                                string responsable = dr.GetString(9);
                                string nota = dr.GetString(10);

                                //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), string.Format("id={0} nombre={1} telefono={2} dir={3} dp={4} pais={5} prov={6} loc={7} gestion={8} resp={9} nota={10}",id_almacen,nombre,telefono,direccion,codigo_postal,id_pais,provincia,localidad,gestion_inventario,responsable,nota));

                                Almacen almacen = new Almacen(nombre, telefono, direccion, codigo_postal, id_pais, provincia, localidad, gestion_inventario, responsable, nota, id_almacen);
                                return (object)almacen;
                            }
                            break;

                        case "familias":
                            if (dr.Read())
                            {
                                int id_familia = dr.GetInt32(0);
                                string nombre_familia = dr.GetString(1);
                                int id_estado = dr.GetInt32(2);

                                Familia familia = new Familia(nombre_familia,id_estado,id_familia);
                                return (object)familia;
                            }
                            break;

                        case "marcas":
                            if (dr.Read())
                            {
                                int id_marca = dr.GetInt32(0);
                                string nombre_marca = dr.GetString(1);

                                Marca marca = new Marca(nombre_marca, id_marca);
                                return (object)marca;
                            }
                            break;

                        case "catalogo":
                            if (dr.Read()) { 
                                int id_producto = dr.GetInt32(0);
                                int id_almacen = dr.GetInt32(1);
                                string codigo_interno = dr.GetString(2);
                                string nombre = dr.GetString(3);
                                int id_familia = dr.GetInt32(4);
                                int id_marca = dr.GetInt32(5);
                                DateTime fecha_alta = dr.GetDateTime(6);
                                DateTime fecha_baja = dr.GetDateTime(7);
                                string descripcion = dr.GetString(8);
                                decimal precio_sin_iva = dr.GetDecimal(9);
                                int iva = dr.GetInt32(10);
                                decimal precio_mayorista = dr.GetDecimal(11);
                                int stock_minimo = dr.GetInt32(12);
                                int stock = dr.GetInt32(13);
                                int pedido_minimo = dr.GetInt32(14);
                                byte[] logo = (byte[])dr[15];

                                Producto producto = new Producto(id_almacen, codigo_interno, nombre, id_familia, id_marca, fecha_alta, fecha_baja, descripcion, precio_sin_iva, iva, precio_mayorista, stock_minimo, stock, pedido_minimo, logo,id_producto);
                                return (object)producto;
                            }
                            break;

                        case "movimientos":

                            break;

                        case "gastos":

                            break;

                        case "pedidos":
                            if (modulo.ToLower() == "compras")
                            {

                            }
                            else if (modulo.ToLower() == "ventas")
                            {

                            }
                            break;

                        case "proveedores":

                            break;

                        case "clientes":

                            break;

                        case "facturas":

                            break;

                        case "presupuestos":

                            break;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ObtenerDatos()");
            }
            return null;
        }

        public bool ExisteEmpresa()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand();

                comando.CommandText = "SELECT COUNT(*) FROM [General].Empresa";

                comando.Connection = conexion;

                conexion.Open();

                int numEmpresas = (int)comando.ExecuteScalar();

                conexion.Close();

                return numEmpresas < 1 ? false : true;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("..\\..\\log\\EXC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), ex.Message + " Desde: ExisteEmpresa()");
            }
            return true;
        }

    }
}


