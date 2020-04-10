using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        public int NumDni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Sexo { get; set; }

    }



    public class Deposito
    {

        public string CodDeposito { get; set; }
        public string Direccion { get; set; }
        public int Zona { get; set; }
        public int Telefono { get; set; }
        public string email { get; set; }
        public Ciudad Ciudad { get; set; }

    }


    public class Pasillo
    {

        public string CodPasillo { get; set; }
        public Deposito Deposito { get; set; }
        public int CantidadCompartimientos { get; set; }


    }

    public class Lado
    {

        public string CodLado { get; set; }
        public Pasillo Pasillo { get; set; }
        public Deposito Deposito { get; set; }
        public int CantCompartimentos { get; set; }

    }



    public class Compartimento
    {

        public string CodCompartimento { get; set; }
        public bool Estado { get; set; }
        public Cliente Cliente { get; set; }
        public CertificadoAlmacenamiento CertificadoAlmac { get; set; }
        public CertificadoRetiro CertificadoRet { get; set; }
        public Lado Lado { get; set; }
        public Producto Producto { get; set; }


    }

    public class Producto
    {
        public string CodProducto { get; set; }
        public Marca MarcaProd { get; set; }
        public string Detalles { get; set; }

        public TipoProducto TipoProducto { get; set; }

    }

    public class Marca
    {
        public string CodMarca { get; set; }
        public string Nombre { get; set; }


    }

    public class Ciudad
    {
        public string CodCiudad { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }

        public string Provincia { get; set; }
        public string Pais { get; set; }

    }



    public class Cliente : Persona
    {
        public string CodCliente { get; set; }
        public DateTime FechaRegistracion { get; set; }
        public string TipoCliente { get; set; }

    }

    public class TipoProducto
    {
        public string CodTipoProducto { get; set; }
        public string Descripcion { get; set; }

    }

    public class CertificadoAlmacenamiento
    {
        public string CodCertAlm { get; set; }

        public DateTime FechaALmacenam { get; set; }
        public Cliente CodCliente { get; set; }
        public Compartimento CodCompartimento { get; set; }
        public Empleado Empleado { get; set; }

    }

    public class CertificadoRetiro
    {
        public string CodCertRet { get; set; }

        public DateTime FechaRetiro { get; set; }
        public Cliente CodCliente { get; set; }
        public Compartimento CodCompartimento { get; set; }
        public Empleado Empleado { get; set; }

    }


    public class Empleado : Persona
    {
        public int Legajo { get; set; }
        public string Cargo { get; set; }
        public Deposito Depotrabaja { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

    }
}
