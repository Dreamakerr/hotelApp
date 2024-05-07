using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public static class AttributeHelper
    {
        /// <summary>
        /// 获取映射表名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string getTName(this Type type)
        {
            string tableName = "";
            TableAttribute tableAttr = type.GetCustomAttribute<TableAttribute>();
            if (tableAttr != null)
            {
                tableName = tableAttr.TableName;
            }
            if(string.IsNullOrEmpty(tableName) )
            {
                tableName = type.Name;
            }
            return tableName;
        }

        /// <summary>
        /// 获取列名
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string getColName(this PropertyInfo property)
        {
            string colName = "";
            ColumnAttribute attr = property.GetCustomAttribute<ColumnAttribute>();
            if (attr != null)
            {
                colName = attr.ColumnName;
            }
            if(string.IsNullOrEmpty(colName) )
            {
                colName = property.Name;
            }
            return colName;
        }

        /// <summary>
        /// 获取主键名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string getPrimaryName(this Type type)
        {
            string priName = "";
            PrimaryKeyAttribute attr = type.GetCustomAttribute<PrimaryKeyAttribute>();
            if(attr != null)
            {
                priName = attr.KeyName;
            }
            return priName;
        }

        /// <summary>
        /// 判断指定属性是否为主键
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool isPrimaryKey(this PropertyInfo property)
        {
            Type type = property.DeclaringType;
            string primaryKey = type.getPrimaryName();//获取该类型的主键名
            string colName = property.getColName();//获取该属性的映射列名
            return (primaryKey == colName);
        }

        /// <summary>
        /// 判断主键是否自增
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool isAutoIncrement(this Type type)
        {
            PrimaryKeyAttribute attribute = type.GetCustomAttribute<PrimaryKeyAttribute>();
            if (attribute != null)
            {
                return attribute.autoIncrement;
            }
            return false;
        }
    }
}
