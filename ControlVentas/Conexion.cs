using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControlVentas
{
    class Conexion
    {
        // servidor, bd, user, pass

        string servidor, bd, usuario, clave;
        SqlConnection conexion;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter dadap;

        public Conexion()
        {
            string cadena = "server= .; database= Northwind; integrated security = true";
            conexion = new SqlConnection(cadena);
            servidor = "."; bd = "Northwind"; usuario = ""; clave = "";
        }

        public Conexion(string servidor, string bd)
        {
            string cadena = "server= " + servidor + "; database= " + bd + "; integrated security = true";
            conexion = new SqlConnection(cadena);
            this.servidor = servidor; this.bd = bd;
            this.usuario = ""; this.clave = "";
        }

        public Conexion(string servidor, string bd, string usuario, string clave)
        {
            string cadena = "server= " + servidor + "; database= " + bd + "; user id=" + usuario + "; pwd= " + clave + " integrated security = true";
            conexion = new SqlConnection(cadena);
            this.servidor = servidor; this.bd = bd;
            this.usuario = usuario; this.clave = clave;
        }

        public bool Conectar()
        {
            try
            {
                this.conexion.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
        }

        public bool Desconectar()
        {
            try
            {
                this.conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
        }

        public DataSet RetornarRegistros(string tabla)
        {
            if (Conectar())
            {
                try
                {
                    command = new SqlCommand("select * from " + tabla + "", conexion); // instruccion sql
                    dadap = new SqlDataAdapter(command); // guarda la info(datos)
                    dset = new DataSet("Tabla");
                    dadap.Fill(dset, "Tabla");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                    dset = null;
                }
            }
            Desconectar();
            return dset;
        }

        public DataSet Consulta(string sentencia)
        {
            if (Conectar())
            {
                try
                {
                    command = new SqlCommand(sentencia, conexion); // instruccion sql
                    dadap = new SqlDataAdapter(command); // guarda la info(datos)
                    dset = new DataSet("Tabla");
                    dadap.Fill(dset, "Tabla");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                    dset = null;
                }
            }
            Desconectar();
            return dset;
        }

        public DataSet Consulta(string tabla, string campos, string condicion)
        {
            if (Conectar())
            {
                try
                {
                    command = new SqlCommand("select " + campos + " from " + tabla + " where " + condicion, conexion); // instruccion sql
                    dadap = new SqlDataAdapter(command); // guarda la info(datos)
                    dset = new DataSet("Tabla");
                    dadap.Fill(dset, "Tabla");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                    dset = null;
                }
            }
            Desconectar();
            return dset;
        }

        public bool InsertarSQL(string sentencia)
        {
            if (Conectar())
            {
                try
                {
                    command = new SqlCommand(sentencia, conexion);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                    Desconectar();
                    return false;
                }
                Desconectar();
                return true;
            }
            return false;
        }

        //public bool Eliminar(string tabla, string id)
        //{
        //    string cadena = "delete " + tabla + " where Codigo = " + id;
        //    if (Conectar())
        //    {
        //        try
        //        {
        //            command = new SqlCommand(cadena, conexion);
        //            command.ExecuteNonQuery();
        //        }
        //        catch (Exception e)
        //        {
        //            Desconectar();
        //            MessageBox.Show("Error: " + e.Message);
        //            return false;
        //        }
        //        Desconectar();
        //        return true;
        //    }
        //    return false;
        //}

        //public bool ModificarAmigo(Contacto contacto)
        //{
        //    string[] fecha = contacto.FechaNacimiento.Split('/');
        //    contacto.FechaNacimiento = fecha[1] + "/" + fecha[0] + "/" + fecha[2];
        //    string sentencia = "update Amigos set " +
        //      "Apellidos = '" + contacto.Apellidos + "', " +
        //      "Nombres = '" + contacto.Nombres + "', " +
        //      "FechaNace = '" + contacto.FechaNacimiento + "', " +
        //      "Sexo = '" + contacto.Sexo + "', " +
        //      "Telefono = '" + contacto.Telefono + "', " +
        //      "Celular = '" + contacto.Celular + "', " +
        //      "Ciudad = '" + contacto.Ciudad + "', " +
        //      "Universidad = '" + contacto.Universidad + "', " +
        //      "Carrera = '" + contacto.Carrera + "' " +
        //      "where Codigo = " + contacto.Id + "";

        //    if (Conectar())
        //    {
        //        try
        //        {
        //            command = new SqlCommand(sentencia, conexion);
        //            command.ExecuteNonQuery();
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("Error: " + e.Message);
        //            Desconectar();
        //            return false;
        //        }
        //        Desconectar();
        //        return true;
        //    }
        //    return false;
        //}

        //public bool AgregarAmigo(Contacto contacto)
        //{
        //    string[] fecha = contacto.FechaNacimiento.Split('/');
        //    contacto.FechaNacimiento = fecha[1] + "/" + fecha[0] + "/" + fecha[2];
        //    string sentencia = "insert into Amigos (" +
        //        "Codigo, " +
        //        "Apellidos, " +
        //        "Nombres, " +
        //        "FechaNace, " +
        //        "Sexo, " +
        //        "Telefono, " +
        //        "Celular, " +
        //        "Ciudad, " +
        //        "Universidad, " +
        //        "Carrera " +
        //      ") values (" +
        //      "" + contacto.Id + ", " +
        //      "'" + contacto.Apellidos + "', " +
        //      "'" + contacto.Nombres + "', " +
        //      "'" + contacto.FechaNacimiento + "', " +
        //      "'" + contacto.Sexo + "', " +
        //      "'" + contacto.Telefono + "', " +
        //      "'" + contacto.Celular + "', " +
        //      "'" + contacto.Ciudad + "', " +
        //      "'" + contacto.Universidad + "', " +
        //      "'" + contacto.Carrera + "'"
        //      + ")";

        //    if (Conectar())
        //    {
        //        try
        //        {
        //            command = new SqlCommand(sentencia, conexion);
        //            command.ExecuteNonQuery();
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("Error: " + e.Message);
        //            Desconectar();
        //            return false;
        //        }
        //        Desconectar();
        //        return true;
        //    }
        //    return false;
        //}
    }
}
