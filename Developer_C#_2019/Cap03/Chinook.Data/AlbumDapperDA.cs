using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Dapper;
using System.Linq;

namespace Chinook.Data
{
    public class AlbumDapperDA: BaseConnection
    {
        public int GetCount()
        {
            var result = 0;
            var sql = "SELECT COUNT(0) FROM Album";
            /* 1. Crear el objeto Connection*/
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {

                result = cn.Query<int>(sql).Single();
            }

            return result;
        }

        public IEnumerable<Album> Gets()
        {
            var result = new List<Album>();
            var sql = "SELECT AlbumId, Title FROM Album";
            /* 1. Crear el objeto Connection*/
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {

                result = cn.Query<Album>(sql).ToList();
            }

            return result;
        }

        public IEnumerable<Album> GetsWithParam(string name)
        {
            var result = new List<Album>();
            var sql = "SELECT AlbumId, Title FROM Album WHERE Title LIKE @FiltroPorNombre ";
            /* 1. Crear el objeto Connection*/
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {

                result = cn.Query<Album>(sql,
                    new { FiltroPorNombre = name }
                    ).ToList();
            }

            return result;
        }

        public IEnumerable<Album> GetsWithParamSP(string name)
        {
            var result = new List<Album>();
            var sql = "usp_GetAlbums";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                result = cn.Query<Album>(sql,
                   new { FiltroPorNombre = name },
                   commandType: CommandType.StoredProcedure
                   ).ToList();
            }
            return result;
        }

        public int InsertAlbum(Album entity)
        {
            var result = 0;
            var sql = "usp_InsertAlbum";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                result = cn.Query<int>(sql,
                        new {
                            Nombre = entity.Title,
                            IdFK = entity.ArtistId
                        },
                        commandType: CommandType.StoredProcedure)
                    .Single();
            }
            return result;
        }

        public Boolean UpdateAlbumTXDist(Album entity)
        {
            Boolean result = false;
            using (var tx = new TransactionScope())
            {
                try
                {
                    var dynamicParams = new DynamicParameters();
                    dynamicParams.Add("Nombre", entity.Title);
                    dynamicParams.Add("ID", entity.AlbumId);
                    dynamicParams.Add("RESULT", dbType: DbType.Boolean,
                            direction: ParameterDirection.Output);
                    var sql = "usp_UpdateAlbum";
                    using (IDbConnection cn = new SqlConnection(GetConection()))
                    {
                        cn.Execute(sql,
                          dynamicParams,
                           commandType: CommandType.StoredProcedure);
                        result = dynamicParams.Get<Boolean>("RESULT");
                    }
                    tx.Complete();
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }

        public Boolean DeleteAlbumTXDist(int ID)
        {
            Boolean result = false;
            using (var tx = new TransactionScope())
            {
                try
                {
                    var sql = "usp_DeleteAlbum";
                    using (IDbConnection cn = new SqlConnection(GetConection()))
                    {
                        result = cn.Execute(sql,
                            new { ID = ID },
                             commandType: CommandType.StoredProcedure) > 0;
                    }
                    tx.Complete();
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }

    }
}
