using CG3D.Model;
//using CG3D.UI.Common;
using CG3D.Utils;
using Core.Resource;
using Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace CG3D.Config
{
	public class BaseCfg
	{
		private static Regex regLanguage = new Regex("L\\([^\\)]*?\\)");
		private static MatchCollection matchCollection;
		private static string strLanguageKey;

		protected string fileName;
		protected Dictionary<string, int> dictHead;
		protected int _count;
		protected string[][] arrCfg;
		public virtual void Init(string _fileName, ref int count)
		{
			if (_count > 0) return;
			fileName = _fileName;
			count++;
            //ResourceManager.GetInstance().LoadResourceAsyc("Config/" + fileName + "?" + MdlPlayer.enterGameCount, new ResourceManager.CallbackDelegate(LoadCallback));
            TextAsset t = (TextAsset)Resources.Load("Config/" + fileName, typeof(TextAsset));
            Parse(t.text);
            //if (!ConfigManager.dictCfgBytes.ContainsKey(fileName))
            //{
            //	MyDebug.LogError("Zip不包含的配置：" + fileName);
            //	return;
            //}
            //LoadCallback("", ResourceManager.CALLBACK_TYPE.SUCCESS, ConfigManager.dictCfgBytes[fileName]);
        }
		protected virtual void LoadCallback(string _url, ResourceManager.CALLBACK_TYPE type, object data)
		{
			if (type == ResourceManager.CALLBACK_TYPE.SUCCESS)
			{
				//MyDebug.Log("下载成功：" + fileName);
				//try
				{
					string str;
					if (data is string)
					{
						//Debug.Log("是String:" + fileName);
						str = data as string;
					}
					else
					{
						byte[] tempBytes = data as byte[];
						if (tempBytes.Length == 0)
						{
							MyDebug.LogError(fileName + ",字节长度为 0！");
							return;
						}
						str = Encoding.Unicode.GetString(tempBytes, 2, tempBytes.Length - 2);//去掉Unicode编码的前两字节FF FE
					}
					//Debug.Log(fileName+","+str);
					Parse(str);
				}
				//catch (Exception e)
				//{
				//	MyDebug.LogError("解析错误：" + fileName + ":" + e.Message);
				//}
			}
			else if (type == ResourceManager.CALLBACK_TYPE.ERROR)
			{
                //ReenterPanel.GetInstance().OpenWith("配置：" + fileName);
			}
		}
        /// <summary>
        /// 重制配置数据
        /// </summary>
        public virtual void Reset()
        {
            _count = 0;
            arrCfg = null;
        }
		protected virtual void Parse(string str)
		{
			if (_count > 0) return;
			//MyDebug.Log("解析：" + fileName);
			string[] arrLine = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);
			_count = arrLine.Length;
			//UnityEngine.Debug.Log(arrLine[_count - 1]);
			if (string.IsNullOrEmpty(arrLine[_count - 1]))
			{
				_count--;//去掉配置最后一行空白
			}
			arrCfg = new string[_count][];
			for (int i = 0; i < _count; i++)
			{
				arrCfg[i] = arrLine[i].Split("\t"[0]);
                RestoreLanguage(arrCfg[i]);
            }
			//Debug.Log(fileName + ",count=" + _count + ",arrLine[0]" + arrLine[0]);

			dictHead = new Dictionary<string, int>();
			for (int j = 0; j < arrCfg[0].Length; j++)
			{
				if (dictHead.ContainsKey(arrCfg[0][j]))
				{
					MyDebug.LogError("已经包含key：" + fileName + ",列=" + j + ",值=" + arrCfg[0][j]);
					return;
				}
				dictHead.Add(arrCfg[0][j], j);
				//if (fileName == "arena_data.txt")
				//{
				//	Debug.Log(j + "=" + arrCfg[0][j]);
				//}
			}
			MyDebug.Log("解析成功：" + fileName);
			ConfigManager.GetInstance().currCount++;
		}
		/// <summary>
		/// 还原语言包
		/// </summary>
		/// <param name="arrStr"></param>
		protected virtual void RestoreLanguage(string[] arrStr)
		{
			for (int i = 0; i < arrStr.Length; i++)
			{
				matchCollection = regLanguage.Matches(arrStr[i]);
				for (int j = 0; j < matchCollection.Count; j++)
				{
					strLanguageKey = matchCollection[j].Value;
					strLanguageKey = strLanguageKey.Substring(2, strLanguageKey.Length - 3);
					arrStr[i] = arrStr[i].Replace(matchCollection[j].Value, Locale.GetString(strLanguageKey));
				}
			}
		}
		public virtual int count
		{
			get { return _count - 2; }
		}
		public virtual DataAdapter GetById(int id)
		{
			string strId = id.ToString();
			return GetSingleBy("id", strId);
		}
		public virtual DataAdapter GetByStrId(string strId)
		{
			return GetSingleBy("id", strId);
		}
		public virtual List<DataAdapter> GetByIds(string ids)
		{
			List<DataAdapter> list = new List<DataAdapter>();
			int keyIndex = dictHead["id"];
			for (int i = 0; i < _count; i++)
			{
				if (ids.Contains(arrCfg[i][keyIndex]))
				{
					DataAdapter da = new DataAdapter();
					da.fileName = fileName;
					da.arrStrData = arrCfg[i];
					da.dictHead = dictHead;
					list.Add(da);
				}
			}
			return list;
		}
		public virtual DataAdapter GetSingleBy(string key, string value)
		{
			if (!dictHead.ContainsKey(key))
			{
				MyDebug.LogError("配置【" + fileName + "】不包含键等于【" + key + "】的列");
				return null;
			}
			int keyIndex = dictHead[key];
			for (int i = 0; i < _count; i++)
			{
				if (arrCfg[i][keyIndex] == value)
				{
					DataAdapter da = new DataAdapter();
					da.fileName = fileName;
					da.arrStrData = arrCfg[i];
					da.dictHead = dictHead;
					return da;
				}
			}
			MyDebug.LogWarning("找不到配置：" + fileName + ",key=" + key + ",value=" + value);
			return null;
		}
		public virtual List<DataAdapter> GetMultiBy(string key, string value)
		{
			if (!dictHead.ContainsKey(key))
			{
				throw new Exception("配置【" + fileName + "】不包含键等于【" + key + "】的列");
			}
			int keyIndex = dictHead[key];
			List<DataAdapter> list = new List<DataAdapter>();
			for (int i = 0; i < _count; i++)
			{
				if (arrCfg[i][keyIndex] == value)
				{
					DataAdapter da = new DataAdapter();
					da.fileName = fileName;
					da.arrStrData = arrCfg[i];
					da.dictHead = dictHead;
					list.Add(da);
				}
			}
			return list;
		}
		public virtual List<DataAdapter> GetMultiBy(string key1, string value1, string key2, string value2)
		{
			if (!dictHead.ContainsKey(key1))
			{
				throw new Exception("配置【" + fileName + "】不包含键等于【" + key1 + "】的列");
			}
			int keyIndex1 = dictHead[key1];
			int keyIndex2 = dictHead[key2];
			List<DataAdapter> list = new List<DataAdapter>();
			for (int i = 0; i < _count; i++)
			{
				if (arrCfg[i][keyIndex1] == value1 && arrCfg[i][keyIndex2] == value2)
				{
					DataAdapter da = new DataAdapter();
					da.fileName = fileName;
					da.arrStrData = arrCfg[i];
					da.dictHead = dictHead;
					list.Add(da);
				}
			}
			return list;
		}
		public virtual List<DataAdapter> GetAll()
		{
			List<DataAdapter> list = new List<DataAdapter>();
			for (int i = 2; i < _count; i++)
			{
				DataAdapter da = new DataAdapter();
				da.fileName = fileName;
				da.arrStrData = arrCfg[i];
				da.dictHead = dictHead;
				list.Add(da);
			}
			return list;
		}
		public virtual List<DataAdapter> GetTopAll(int maxCount)
		{
			List<DataAdapter> list = new List<DataAdapter>();
			for (int i = 2; i < _count && i < maxCount; i++)
			{
				DataAdapter da = new DataAdapter();
				da.fileName = fileName;
				da.arrStrData = arrCfg[i];
				da.dictHead = dictHead;
				list.Add(da);
			}
			return list;
		}
	}
}
