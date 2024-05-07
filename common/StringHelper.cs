using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public static class StringHelper
    {
        /// <summary>
        /// 将数字字符串转换成int
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static int GetInt(this string strValue)
        {
            int reInt = 0;
            int.TryParse(strValue, out reInt);
            return reInt;
        }

        /// <summary>
        /// 将数字字符串转换成decimal
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static decimal GetDecimal(this string strValue)
        {
            decimal reInt = 0;
            decimal.TryParse(strValue, out reInt);
            return reInt;
        }

        /// <summary>
        /// 将数字object转换成decimal
        /// </summary>
        /// <param name="oValue"></param>
        /// <returns></returns>
        public static decimal GetDecimal(this object oValue)
        {
            decimal reDecimal = 0;
            try
            {
                reDecimal = Convert.ToDecimal(oValue);
            }
            catch
            {
                reDecimal = 0;
            }
            return reDecimal;
        }

        /// <summary>
        /// 将object转换成int
        /// </summary>
        /// <param name="oValue"></param>
        /// <returns></returns>
        public static int GetInt(this object oValue)
        {
            int reInt = 0;
            try
            {
                reInt = Convert.ToInt32(oValue);
            }
            catch
            {
                reInt = 0;
            }
            return reInt;
        }

        /// <summary>
        /// 把字符串按照分隔符转换成list
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="speater">分隔符</param>
        /// <param name="toLower">是否转换成小写</param>
        /// <returns></returns>
        public static List<string> GetStrList(this string str, char speater, bool toLower)
        {
            List<string> list = new List<string>();
            string[] ss = str.Split(speater);
            foreach (string s in ss)
            {
                if (!string.IsNullOrEmpty(s) && s != speater.ToString())
                {
                    string strVal = s.Trim();
                    if (toLower) { strVal = s.ToLower(); }
                    list.Add(strVal);
                }
            }
            return list;
        }
        /// <summary>
        /// 把字符串按照“，”分割，换为数组
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] GetStrArray(this string str)
        {
            return str.Split(new char[] { ',' });
        }

        /// <summary>
        /// 把list<string>按照分隔符组装成string
        /// </summary>
        /// <param name="list"></param>
        /// <param name="speater"></param>
        /// <returns></returns>
        public static string GetListStrToString(this List<string> list, string speater)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    sb.Append(list[i]);
                }
                else
                {
                    sb.Append(list[i]);
                    sb.Append(speater);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 得到数组列表以逗号分隔的字符串
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetListToStr(this List<int> list)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1) { sb.Append(list[i].ToString()); }
                else
                {
                    sb.Append(list[i].ToString());
                    sb.Append(',');
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 得到数组列表以逗号分隔的字符串
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetArrayValueStr(this Dictionary<int, int> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, int> kvp in list)
            {
                sb.Append(kvp.Value + ",");
            }
            if (list.Count > 0) { return DelLastComma(sb.ToString()); }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 删除最后结果的一个逗号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DelLastComma(this string str)
        {
            return str.Substring(0, str.LastIndexOf(","));
        }

        /// <summary>
        /// 删除最后结尾的指定字符后的字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="strchar"></param>
        /// <returns></returns>
        public static string DelLastChar(this string str, string strchar)
        {
            return str.Substring(0, str.LastIndexOf(strchar));
        }

        /// <summary>
        /// 把字符串按照指定分隔符装成list
        /// </summary>
        /// <param name="o_str"></param>
        /// <param name="sepeater"></param>
        /// <returns></returns>
        public static List<string> GetSubStringList(string o_str, char sepeater)
        {
            List<string> list = new List<string>();
            string[] ss = o_str.Split(sepeater);
            foreach (string s in ss)
            {
                if (!string.IsNullOrEmpty(s) && s != sepeater.ToString())
                {
                    list.Add(s);
                }
            }
            return list;
        }

        /// <summary>
        /// 得到字符串长度，一个汉字长度为2
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int StrLength(string str)
        {
            System.Text.ASCIIEncoding aSCII = new System.Text.ASCIIEncoding();
            int tempLen = 0;
            byte[] s = aSCII.GetBytes(str);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 2;
                }
                else
                    tempLen += 1;
            }
            return tempLen;
        }

        public static string ClipString(string str, int len)
        {
            bool isShowFix = false;
            if (len % 2 == 1)
            {
                isShowFix = true;
                len--;
            }
            System.Text.ASCIIEncoding aSCII = new System.Text.ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = aSCII.GetBytes(str);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 2;
                }
                else tempLen += 1;
                try
                {
                    tempString += str.Substring(i, 1);
                }
                catch
                {
                    break;
                }
                if (tempLen > len)
                {
                    break;
                }
            }
            byte[] mybyte = System.Text.Encoding.Default.GetBytes(str);
            if (isShowFix && mybyte.Length > len)
                tempString += "...";
            return tempString;
        }

        public static string StringTrim(this string str)
        { 
            return str.Trim(); 
        }

        /// <summary>
        /// 移除指定的子串（以逗号连接）
        /// </summary>
        /// <param name="str"></param>
        /// <param name="reStr"></param>
        /// <returns></returns>
        public static string RemoveStrItem(this string str, string reStr)
        {
            List<string> arrStr = str.GetStrList(',', false);
            arrStr.Remove(reStr);
            return arrStr.GetListStrToString(",");
        }
    }
}
