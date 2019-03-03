using Chinook.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;

namespace Chinook.Data
{
    public class ArctistDapperDA: BaseConnection
    {
        public int GetCount()
        {
            var result = 0;
            var sql = "SELECT COUNT(1) FROM Artist";
            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                result = cn.Query<int>(sql).Single();                
            }       
            return result;
        }
        /*
         Si se tine una tabla productos.Tiene  10 campos.
         Y si tenemos un select que querremos traer el ID y el PRECIO
         
             */
        public IEnumerable<Artist> Gets()
        {
            var result = new List<Artist>();
            var sql = "SELECT ArtistId, Name FROM Artist";

            /* 1. Crear el objeto connection. */
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                result = cn.Query<Artist>(sql).ToList();
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
                result = cn.Query<Artist>(sql,
                    new { FiltroPorNombre = nombre }).ToList();
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
                result = cn.Query<Artist>(sql,
                    new { FiltroPorNombre = nombre },
                    commandType:CommandType.StoredProcedure
                    ).ToList();
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
                result = cn.Query<int>(sql,
                    new {
                        Nombre = entity.Name
                    },
                     commandType: CommandType.StoredProcedure).Single();
               
            }
            return result;
        }

        /* Transaccion */
        public int InsertArtistTX(Artist entity)
        {
            var result = 0;
            var sql = "usp_InsertArtist";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                cn.Open();
                // Iniciando la transaccion local.
                var transaction = cn.BeginTransaction();
                
                try
                {
                    result = cn.Query(sql,
                    new { Nombre = entity.Name },
                    commandType: CommandType.StoredProcedure,
                    transaction: transaction).Single();
                }
                catch(Exception ex)
                {
                    // Con el metodo Rollback se deshace la transacción
                    transaction.Rollback();
                }
            }
            return result;
        }


        public int InsertArtistTXDist(Artist entity)
        {
            /* Transacciones distribuidas */
            var result = 0;
            
            using (var tx = new TransactionScope())
            {
                try {
                    var sql = "usp_InsertArtist";
                    /*  Crear el objeto connection. */
                    using (IDbConnection cn = new SqlConnection(GetConection()))
                    {
                        cn.Open();
                        /* 2. Creando una instancia del objeto command. */
                        IDbCommand cmd = new SqlCommand(sql);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = cn;
                        cmd.Parameters.Add(new SqlParameter("@Nombre", entity.Name));

                        /* Ejecutando el comando. */
                        result = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                    /* No se usa rollback no es necesario */
                    tx.Complete();
                }
                catch(Exception)
                {

                }
            }
            return result;
        }

        public int UpdateArtistTXDist(Artist entity)
        {
            /* Transacciones distribuidas */
            Boolean result = false;

            using (var tx = new TransactionScope())
            {
                try
                {
                    var dynamicParams = new DynamicParameters();
                    dynamicParams.Add("Nombre", entity.Name);
                    dynamicParams.Add("ID", entity.ArtistId);
                    dynamicParams.Add("Nombre", dbType:DbType.Int32,
                        direction:ParameterDirection.Output);


                    var sql = "usp_UpdateArtist";
                    /*  Crear el objeto connection. */
                    using (IDbConnection cn = new SqlConnection(GetConection()))
                    {
                        cn.Query(sql,
                           dynamicParams,
                           commandType: CommandType.StoredProcedure);

                        result = dynamicParams.Get<Boolean>("RESULT");
                    }
                    /* No se usa rollback no es necesario */
                    tx.Complete();
                }
                catch (Exception)
                {

                }
            }
            return result;
        }

    }
}
