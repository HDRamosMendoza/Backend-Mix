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
    public class GenreDapperDA: BaseConnection
    {
        public int GetCount()
        {
            var result = 0;
            var sql = "SELECT COUNT(0) FROM Genre";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            { result = cn.Query<int>(sql).Single(); }
            return result;
        }

        public IEnumerable<Genre> Gets()
        {
            var result = new List<Genre>();
            var sql = "SELECT GenreId, Name FROM Genre";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            { result = cn.Query<Genre>(sql).ToList(); }
            return result;
        }

        public IEnumerable<Genre> GetsWithParam(string name)
        {
            var result = new List<Genre>();
            var sql = "SELECT GenreId, Name FROM Genre WHERE Name LIKE @FiltroPorNombre ";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {

                result = cn.Query<Genre>(sql,
                    new { FiltroPorNombre = name }
                    ).ToList();
            }

            return result;
        }

        public IEnumerable<Genre> GetsWithParamSP(string name)
        {
            var result = new List<Genre>();
            var sql = "usp_GetGenres";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                result = cn.Query<Genre>(sql,
                   new { FiltroPorNombre = name },
                   commandType: CommandType.StoredProcedure
                   ).ToList();
            }
            return result;
        }

        public int InsertGenre(Genre entity)
        {
            var result = 0;
            var sql = "usp_InsertGenre";
            using (IDbConnection cn = new SqlConnection(GetConection()))
            {
                result = cn.Query<int>(sql,
                        new{ Nombre = entity.Name },
                        commandType: CommandType.StoredProcedure)
                    .Single();
            }
            return result;
        }

        public Boolean UpdateGenreTXDist(Genre entity)
        {
            Boolean result = false;
            using (var tx = new TransactionScope())
            {
                try
                {
                    var dynamicParams = new DynamicParameters();
                    dynamicParams.Add("Nombre", entity.Name);
                    dynamicParams.Add("ID", entity.GenreId);
                    dynamicParams.Add("RESULT", dbType: DbType.Boolean,
                            direction: ParameterDirection.Output);
                    var sql = "usp_UpdateGenre";
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

                }
            }
            return result;
        }

        public Boolean DeleteGenreTXDist(int ID)
        {
            Boolean result = false;
            using (var tx = new TransactionScope())
            {
                try
                {
                    var sql = "usp_DeleteGenre";
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
