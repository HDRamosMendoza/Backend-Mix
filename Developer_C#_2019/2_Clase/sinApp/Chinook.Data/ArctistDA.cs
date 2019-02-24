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
    public class ArctistDA: BaseConnection
    {
        public int GetCount()
        {
            var result = 0;
                       var sql = "SELECT COUNT(1) FROM Artist";
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

        public IEnumerable<Artist> Gets()
        {
            var result = new List<Artist>();
            var sql = "SELECT ArtistId, Name FROM Artist";

            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                /* 2. Creando una instancia del objeto command. */
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                /* Ejecutando el comando. */
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new Artist();
                    indice = reader.GetOrdinal("ARTISTID");
                    entity.ArtistId = reader.GetInt32(indice);
                    /* Si se usa convert ese usa procesador */

                    indice = reader.GetOrdinal("NAME");
                    entity.Name = reader.GetString(indice);

                    result.Add(entity);
                }
            }

            return result;
        }

        public IEnumerable<Artist> GetsWithParam(string nombre)
        {
            var result = new List<Artist>();
            var sql = "SELECT ArtistId, Name FROM Artist WHERE Name LIKE @FiltroPorNombre";

            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                /* 2. Creando una instancia del objeto command. */
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                /* Configurando los parametros de la consulta SQL. */
                /* Estamos evitando la vulnerabilidad de SQL INJECTION. */
                /* _ _ LIKE " + NOMBRE + "  " */
                cmd.Parameters.Add(new SqlParameter("@FiltroPorNombre", nombre));
                /* Ejecutando el comando. */
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new Artist();
                    indice = reader.GetOrdinal("ARTISTID");
                    entity.ArtistId = reader.GetInt32(indice);
                    /* Si se usa convert ese usa procesador */

                    indice = reader.GetOrdinal("NAME");
                    entity.Name = reader.GetString(indice);

                    result.Add(entity);
                }
            }

            return result;
        }


        public IEnumerable<Artist> GetsWithParamSP(string nombre)
        {
            var result = new List<Artist>();
            var sql = "usp_GetArtists";

            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                /* 2. Creando una instancia del objeto command. */
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                /* Configurando los parametros de la consulta SQL. */
                /* Estamos evitando la vulnerabilidad de SQL INJECTION. */
                /* _ _ LIKE " + NOMBRE + "  " */
                cmd.Parameters.Add(new SqlParameter("@FiltroPorNombre", nombre));
                /* Ejecutando el comando. */
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new Artist();
                    indice = reader.GetOrdinal("ARTISTID");
                    entity.ArtistId = reader.GetInt32(indice);
                    /* Si se usa convert ese usa procesador */

                    indice = reader.GetOrdinal("NAME");
                    entity.Name = reader.GetString(indice);

                    result.Add(entity);
                }
            }

            return result;
        }

        public int InsertArtist(Artist entity)
        {
            var result = 0;
            var sql = "usp_InsertArtist";

            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                /* 2. Creando una instancia del objeto command. */
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                /* Configurando los parametros de la consulta SQL. */
                /* Estamos evitando la vulnerabilidad de SQL INJECTION. */
                /* _ _ LIKE " + NOMBRE + "  " */
                cmd.Parameters.Add(new SqlParameter("@Nombre", entity.Name));
                
                /* Ejecutando el comando. */
                result = Convert.ToInt32(cmd.ExecuteScalar());
               
            }
            return result;
        }
    }
}
