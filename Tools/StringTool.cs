using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Tools
{
    public static class StringTool
    {
        /// <summary>
        /// 专用的分割方法。分割","符号，避免双引号内存在","符号的问题
        /// </summary>
        /// <param name="s">被分割的字符串</param>
        /// <returns></returns>
        public static string[] SingleSplit(this string s)
        {
            string[] ss = s.Split(',');
            List<string> ls = new List<string>();
            string es = "";
            
            foreach (var v in ss)
            {
                if (v.Contains("\""))
                {
                    if (v.Substring(0, 1) == "\"")
                    {
                        string nv = v;
                        nv = v.Remove(0, 1);
                        if (nv.Substring(nv.Length - 1, 1) == "\"")
                        {
                            ls.Add(nv.Remove(nv.Length - 1, 1));
                        }
                        else
                        {
                            if (es == "")
                            {
                                es = nv + ",";
                            }
                            else
                            {
                                es += v + ",";
                            }
                        }
                    }
                    else
                    {
                        if (v.Substring(v.Length - 1, 1) == "\"")
                        {
                            if (es != "")
                            {
                                es += v.Remove(v.Length - 1, 1);
                                ls.Add(es);
                                es = "";
                            }
                            else
                            {
                                ls.Add(v);
                            }
                        }
                        else
                        {
                            if (es == "")
                            {
                                ls.Add(v);
                            }
                            else
                            {
                                es += v + ",";
                            }
                        }
                    }
                }
                else
                {
                    if (es == "")
                    {
                        ls.Add(v);
                    }
                    else
                    {
                        es += v + ",";
                    }
                }
            }
            return ls.ToArray();
        }
    }
}