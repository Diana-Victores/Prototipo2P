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
    public bool InsertHabitacion (string _nomb, string _cons, string _area, string _camp, string text)
    {
        using (con)
        {
            OdbcCommand cmd = new OdbcCommand();
            con.Open();
            cmd.Connection = con;

            #region Query
            String query = @"INSERT INTO hotelsancarlos(idHabitacion,idTipoHabitacion,idTipoCama,precio) VALUE(?,?,?,?);";
            #endregion
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.Parameters.Add("@idHabitacion", OdbcType.VarChar).Value = _nomb;
            cmd.Parameters.Add("@idTipoHabitacion", OdbcType.VarChar).Value = _cons;
            cmd.Parameters.Add("@idTipoCama", OdbcType.VarChar).Value = _area;
            cmd.Parameters.Add("@precio", OdbcType.VarChar).Value = _camp;
            

            cmd.ExecuteNonQuery();
            con.Close();
        }
        return true;
    }

        public bool TipoHabitacion(string _a, string _b, string _c, string text)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO hotelsancarlos(idTipoHabitacion,nombre,estatus) VALUE(?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.Add("@idTipoHabitacion", OdbcType.VarChar).Value = _a;
                cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _b;
                cmd.Parameters.Add("@estatus", OdbcType.VarChar).Value = _c;
               


                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }



    }
}



