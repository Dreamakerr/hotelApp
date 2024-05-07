using common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL.Base
{
    /// <summary>
    /// 数据转换类
    /// </summary>
    public class dbConvert
    {
        /// <summary>
        /// 将DataRow转换为实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static T DataRowToModel<T>(DataRow dr, string cols)
        {
            T model = Activator.CreateInstance<T>();
            PropertyInfo[] properties = PropertyHelper.getProperties<T>(cols);
            if (dr != null)
            {
                foreach (PropertyInfo p in properties)
                {
                    string colName = p.getColName();
                    if (dr[colName] is DBNull)
                        p.SetValue(model, null);
                    else
                    {
                        SetPropertyValue(p, model, dr[colName]);
                    }
                }
                return model;
            }
            else
                return default(T);

        }

        /// <summary>
        /// 将DataTable转换为List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static List<T> DataTableToList<T>(DataTable dt, string cols)
        {
            List<T> list = new List<T>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    T model = DataRowToModel<T>(dr, cols);
                    list.Add(model);
                }
            }
            return list;
        }

        /// <summary>
        /// 将SqlDataReader转换为Model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static T DataReaderToModel<T>(SqlDataReader dr, string cols)
        {
            T model = Activator.CreateInstance<T>();
            PropertyInfo[] properties = PropertyHelper.getProperties<T>(cols);
            if (dr != null)
            {
                if (dr.Read())
                {
                    foreach (PropertyInfo p in properties)
                    {
                        string colName = p.getColName();
                        if (dr[colName] is DBNull)
                            p.SetValue(model, null);
                        else
                        {
                            SetPropertyValue(p, model, dr[colName]);
                        }
                    }
                }
                dr.Close();
                return model;
            }
            else
                return default(T);

        }

        /// <summary>
        /// 将SqlDataReader转换为List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static List<T> DataReaderToList<T>(SqlDataReader dr, string cols)
        {
            List<T> list = new List<T>();
            PropertyInfo[] properties = PropertyHelper.getProperties<T>(cols);
            if (dr != null)
            {
                while (dr.Read())
                {
                    T model = Activator.CreateInstance<T>();
                    foreach (PropertyInfo p in properties)
                    {
                        string colName = p.getColName();
                        if (dr[colName] is DBNull)
                            p.SetValue(model, null);
                        else
                        {
                            SetPropertyValue(p, model, dr[colName]);
                        }
                    }
                    list.Add(model);
                }
                dr.Close();

            }
            return list;
        }

        /// <summary>
        /// 将model中p属性的值设置为val
        /// </summary>
        /// <param name="p"></param>
        /// <param name="model"></param>
        /// <param name="val"></param>
        private static void SetPropertyValue(PropertyInfo p, object model, object val)
        {
            if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                p.SetValue(model, Convert.ChangeType(val, Nullable.GetUnderlyingType(p.PropertyType)));
            }
            else
                p.SetValue(model, Convert.ChangeType(val, p.PropertyType));
        }
    }
}
