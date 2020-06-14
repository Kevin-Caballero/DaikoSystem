using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daiko_UC.Models;

namespace Daiko_BLL
{
    //modificar conexion para trabajo remoto
    public class Daiko_BLL
    {
        //aqui se aplicaria logica a los datos recibidos de la BD

        public int InsertarEmpresa(Daiko_UC.Models.Empresa nuevaEmpresa)
        {
            //System.IO.File.WriteAllText("..\\..\\log\\TRC" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"), "Click desde BLL");
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.InsertarEmpresa(nuevaEmpresa);
        }

        public int ActualizarEmpresa(Daiko_UC.Models.Empresa empresaActualizada)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ActualizarEmpresa(empresaActualizada);
        }

        public bool ExisteEmpresa()
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ExisteEmpresa();
        }

        public Daiko_UC.Models.Empresa ObtenerDatosEmpresa()
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ObtenerDatosEmpresa();
        }

        public DataTable ConsultaPaginada(string modulo, string tabla, string parametrosSelect, int offset, int registrosPagina, string orden, int numColumnaOrdenacion)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ConsultaPaginada(modulo, tabla, parametrosSelect, offset, registrosPagina, orden, numColumnaOrdenacion);
        }

        public int NumRegistros(string modulo, string tabla)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.NumRegistros(modulo, tabla);
        }

        public DataTable ConsultaTotal(string modulo, string tabla, string parametrosSelect)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ConsultaTotal(modulo, tabla, parametrosSelect);
        }

        public int InsertaMarca(Marca nuevaMarca)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.InsertarMarca(nuevaMarca);
        }

        public object ObtenerDatos(string modulo, string tabla, string parametrosSelect, string nombreColumnaClave, int id)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ObtenerDatos(modulo, tabla, parametrosSelect, nombreColumnaClave, id);
        }

        public int ActualizarMarca(Marca marcaActualizada)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ActualizarMarca(marcaActualizada);
        }

        public int InsertarFamilia(Familia nuevaFamilia)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.InsertarFamilia(nuevaFamilia);
        }

        public int InsertarAlmacen(Almacen nuevoAlmacen)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.InsertarAlmacen(nuevoAlmacen);
        }

        public int ActualizarAlmacen(Daiko_UC.Models.Almacen almacenActualizado)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ActualizarAlmacen(almacenActualizado);
        }

        public int Eliminar(string modulo, string tabla, string nombreColumnaClave, int id)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.Eliminar(modulo, tabla, nombreColumnaClave, id);
        }

        public int ActualizarFamilia(Familia familiaActualizada)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ActializarFamilia(familiaActualizada);
        }

        public int InsertarProducto(Producto nuevoProducto)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.InsertarProducto(nuevoProducto);
        }

        public DataTable ConsultaTotalJoin(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string parametrosSelect)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ConsultaTotalJoin(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, parametrosSelect);
        }

        public object ConsultaPaginadaJoin(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string parametrosSelect, int offset, int registrosPorPagina, string criterioOrdenacion, int posicionColumnaPK)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ConsultaPaginadaJoin(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, parametrosSelect, offset, registrosPorPagina, criterioOrdenacion, posicionColumnaPK);
        }

        public DataTable ConsultaTotalJoin(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string modulo3, string tabla3, string campoRelacionado3, string parametrosSelect, int offset, int registrosPorPagina, string criterioOrdenacion, int posicionColumnaPK)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ConsultaPaginadaJoin(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, modulo3, tabla3, campoRelacionado3, parametrosSelect, offset, registrosPorPagina, criterioOrdenacion, posicionColumnaPK);
        }

        public int ActualizarProducto(Producto productoActualizado)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ActualizarProducto(productoActualizado);
        }

        public DataTable ConsultaTotal(string modulo1, string tabla1, string campoRelacionado1, string modulo2, string tabla2, string campoRelacionado2, string modulo3, string tabla3, string campoRelacionado3, string parametrosSelect)
        {
            Daiko_DAL.Daiko_DAL oDaikoDAL = new Daiko_DAL.Daiko_DAL();
            return oDaikoDAL.ConsultaTotalJoin(modulo1, tabla1, campoRelacionado1, modulo2, tabla2, campoRelacionado2, modulo3, tabla3, campoRelacionado3, parametrosSelect);
        }
    }
}
