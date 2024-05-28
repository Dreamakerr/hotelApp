using common;
using hotelManagementApp.dataLayer.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer.Base
{
    public class BasedataLayer<T> : BQuery<T> where T : class
    {
        //增  单条    批量
        public int Add(T model, string cols, int isReturn)
        {
            if (model == null)
                return 0;
            sqlModel insert = CreateSql.CreateInsertSql<T>(model, cols, isReturn);
            string sql = insert.Sql;
            SqlParameter[] paras = insert.Paras;
            if (isReturn == 0)
                return sqlHelper.ExecuteNonQuery(sql, 1, paras);
            else
            {
                object oId = sqlHelper.ExecuteScalar(sql, 1, paras);
                return oId.GetInt();
            }
        }

        /// <summary>
        /// 批量插入信息
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public bool AddList(List<T> list, string cols)
        {
            List<commandInfo> comList = new List<commandInfo>();
            foreach (T t in list)
            {
                sqlModel insert = CreateSql.CreateInsertSql<T>(t, cols, 0);
                commandInfo com = new commandInfo()
                {
                    commandText = insert.Sql,
                    IsProc = false,
                    Paras = insert.Paras
                };
                comList.Add(com);
            }
            return sqlHelper.ExecuteTrans(comList);
        }

        //改
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cols"></param>
        /// <param name="strWhere"></param>
        /// <param name="paras">附加的参数</param>
        /// <returns></returns>
        public bool Update(T model, string cols, string strWhere, params SqlParameter[] paras)
        {
            if (model == null)
                return false;
            sqlModel update = CreateSql.CreateUpdateSql<T>(model, cols, strWhere);
            string sql = update.Sql;
            SqlParameter[] paras0 = update.Paras;
            List<SqlParameter> listParas = paras0.ToList();
            if (paras != null && paras.Length > 0)
            {
                listParas.AddRange(paras);
            }
            return sqlHelper.ExecuteNonQuery(sql, 1, listParas.ToArray()) > 0;
        }

        /// <summary>
        /// 修改单个信息
        /// </summary>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public bool Update(T t, string cols)
        {
            return Update(t, cols, "");
        }

        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="list"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public bool UpdateList(List<T> list, string cols)
        {
            List<commandInfo> comList = new List<commandInfo>();
            foreach (T t in list)
            {
                sqlModel update = CreateSql.CreateUpdateSql<T>(t, cols, "");
                commandInfo com = new commandInfo()
                {
                    commandText = update.Sql,
                    IsProc = false,
                    Paras = update.Paras
                };
                comList.Add(com);
            }
            return sqlHelper.ExecuteTrans(comList);
        }

        //删
        /// <summary>
        /// 条件删除
        /// </summary>
        /// <param name="delType">0 update  1  delete </param>
        /// <param name="strWhere">条件</param>
        /// <param name="isDeleted">0 1    2</param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public bool Delete(int delType, string strWhere, int isDeleted, params SqlParameter[] paras)
        {
            string delSql = "";
            if (delType == 0)
                delSql = CreateSql.CreateLogicDeleteSql<T>(strWhere, isDeleted);
            else if (delType == 1)
                delSql = CreateSql.CreateDeleteSql<T>(strWhere);
            List<commandInfo> comList = GetCommandList(delSql, false, paras);
            return sqlHelper.ExecuteTrans(comList);
        }


        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool Delete(int id, int delType, int isDeleted)
        {
            Type type = typeof(T);
            string primaryKey = type.getPrimaryName();
            string strWhere = $"{primaryKey}={id} ";
            return Delete(delType, strWhere, isDeleted);
        }

        /// <summary>
        /// 批量按主键删除
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool DeleteList(List<int> idList, int delType, int isDeleted)
        {
            List<string> sqlList = new List<string>();
            Type type = typeof(T);
            string primaryKey = type.getPrimaryName();
            //1.
            //foreach (int id in idList)
            //{
            //    string strWhere = $"{primaryKey}={id} ";
            //    string delSql = "";
            //    if (delType == 0)
            //        delSql = CreateSql.CreateLogicDeleteSql<T>(strWhere, isDeleted);
            //    else if (delType == 1)
            //        delSql = CreateSql.CreateDeleteSql<T>(strWhere);
            //    sqlList.Add(delSql);
            //}
            //2.
            string strIds = string.Join(",", idList);
            string delSql = "";
            string strWhere = $"{primaryKey} in ({strIds}) ";
            if (delType == 0)
                delSql = CreateSql.CreateLogicDeleteSql<T>(strWhere, isDeleted);
            else if (delType == 1)
                delSql = CreateSql.CreateDeleteSql<T>(strWhere);
            sqlList.Add(delSql);

            return sqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 生成删除sql(级联删除) 主表中不包括多层次关系
        /// </summary>
        /// <param name="delType"></param>
        /// <param name="strWhere"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tables"></param>
        /// <returns></returns>
        public List<string> GetDeleteSql(int delType, string strWhere, int isDeleted, string[] tables)
        {
            List<string> sqlList = new List<string>();
            if (delType == 0)
            {
                foreach (string table in tables)
                {
                    sqlList.Add($"update {table} set IsDeleted={isDeleted} where {strWhere}");
                }
            }
            else
            {
                foreach (string table in tables)
                {
                    sqlList.Add($"delete from  {table} where {strWhere}");
                }
            }
            return sqlList;
        }

        /// <summary>
        /// 生成按主键删除的sql(级联删除) 主表中不包括多层次关系
        /// </summary>
        /// <param name="delType"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tables"></param>
        /// <returns></returns>
        public List<string> GetDeleteSql(int delType, int id, int isDeleted, string[] tables)
        {
            Type type = typeof(T);
            string primaryKey = type.getPrimaryName();
            string strWhere = $"{primaryKey}={id}";
            return GetDeleteSql(delType, strWhere, isDeleted, tables);
        }

        /// <summary>
        ///  批量 生成按主键删除的sql(级联删除) 主表中不包括多层次关系
        /// </summary>
        /// <param name="delType"></param>
        /// <param name="Ids"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tables"></param>
        /// <returns></returns>
        public List<string> GetDeleteListSql(int delType, List<int> Ids, int isDeleted, string[] tables)
        {
            List<string> sqlList = new List<string>();
            foreach (int id in Ids)
            {
                sqlList.AddRange(GetDeleteSql(delType, id, isDeleted, tables));
            }
            return sqlList;
        }

        /// <summary>
        /// 将一步操作封装成 List<CommandInfo>
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        private List<commandInfo> GetCommandList(string sql, bool isProc, params SqlParameter[] paras)
        {
            List<commandInfo> comList = new List<commandInfo>();
            commandInfo comInfo = null;
            if (paras != null && paras.Length > 0)
                comInfo = new commandInfo() { commandText = sql, IsProc = isProc, Paras = paras };
            else
                comInfo = new commandInfo() { commandText = sql, IsProc = isProc };
            comList.Add(comInfo);
            return comList;
        }
    }
}
