

namespace Daiko_UC.Models
{
    public class Empresa
    {
        private int _id_empresa;
        private string _razon_social;
        private string _nombre_comercial;
        private string _cif;
        private string _direccion_fiscal;
        private string _codigo_postal;
        private string _telefono;
        private string _fax;
        private byte[] _logo;

        public Empresa(string razon_social, string nombre_comercial, string cif, string direccion_fiscal, string codigo_postal, string telefono, string fax, byte[] logo)
        {
            _razon_social = razon_social;
            _nombre_comercial = nombre_comercial;
            _cif = cif;
            _direccion_fiscal = direccion_fiscal;
            _codigo_postal = codigo_postal;
            _telefono = telefono;
            _fax = fax;
            _logo = logo;
        }

        public int Id_empresa { get => _id_empresa; set => _id_empresa = value; }
        public string Razon_social { get => _razon_social; set => _razon_social = value; }
        public string Nombre_comercial { get => _nombre_comercial; set => _nombre_comercial = value; }
        public string Cif { get => _cif; set => _cif = value; }
        public string Direccion_fiscal { get => _direccion_fiscal; set => _direccion_fiscal = value; }
        public string Codigo_postal { get => _codigo_postal; set => _codigo_postal = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public byte[] Logo { get => _logo; set => _logo = value; }

    }
}

