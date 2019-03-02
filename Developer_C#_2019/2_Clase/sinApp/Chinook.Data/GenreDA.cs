using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class GenreDA: BaseConnection
    {
        public int GetCount()
        {
            var result = 0;
            var sql = "SELECT COUNT(1) FROM Genre";
            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                /* 2. Creando una instancia del objeto command. */
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                /* Ejecutando el comando. */
                result = (int)cmd.ExecuteScalar();
            }
            return result;
        }

        public int UpdateGenre(Genre entity)
        {
            var result = 0;
            var sql = "usp_UpdateGenre";

            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@GenreID", entity.GenreId));
                cmd.Parameters.Add(new SqlParameter("@Nombre", entity.Name));
                
                result = Convert.ToInt32(cmd.ExecuteScalar());

            }
            return result;
        }

        public int DeleteGenre(Genre entity)
        {
            var result = 0;
            var sql = "usp_DeleteGenre";

            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@GenreId", entity.GenreId));

                /* Ejecutando el comando. */
                result = Convert.ToInt32(cmd.ExecuteScalar());

            }
            return result;
        }
    }
}
