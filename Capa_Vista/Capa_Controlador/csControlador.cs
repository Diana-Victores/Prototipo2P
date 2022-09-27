using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using System.Data.Odbc;
using System.Data;



namespace Capa_Controlador
{
    public class clscontrolador
    {
    OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=hotelsancarlos");
    public bool InsertHabitacion (string _nomb, string _cons, string _area, string _camp, string _IDE)
    {
        using (con)
        {
            OdbcCommand cmd = new OdbcCommand();
            con.Open();
            cmd.Connection = con;

            #region Query
            String query = @"INSERT INTO hotelsancarlos(Nombre,Tabla,Campos,Alias, ID) VALUE(?,?,?,?,?);";
            #endregion
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.Parameters.Add("@Nombre", OdbcType.VarChar).Value = _nomb;
            cmd.Parameters.Add("@Tabla", OdbcType.VarChar).Value = _cons;
            cmd.Parameters.Add("@Campos", OdbcType.VarChar).Value = _area;
            cmd.Parameters.Add("@Alias", OdbcType.VarChar).Value = _camp;
            cmd.Parameters.Add("@ID", OdbcType.Int).Value = _IDE;

            cmd.ExecuteNonQuery();
            con.Close();
        }
        return true;
    }

    }
}



