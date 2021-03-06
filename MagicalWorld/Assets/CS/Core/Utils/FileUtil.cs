using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Text;

namespace Core.Utils
{
	public class FileUtil
	{
		// 获取直接可读取路径,会查找可写目录和打包目录,都没有则返回无长度字符串
		public static string GetReadPath(string path)
		{
			StringBuilder sb = new StringBuilder();

			// windows 下检查本地资源目录
			if (UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsEditor ||
				UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsPlayer ||
				UnityEngine.Application.platform == UnityEngine.RuntimePlatform.OSXEditor)
			{
				sb.Append(Environment.CurrentDirectory).Append("/window_res_dir/").Append(path);
				return sb.ToString();
			}

			// 然后检查可写目录
			string writePath = GetWritePath(path);
			if (File.Exists(writePath))
			{
				sb.Append(writePath);
				return sb.ToString();
			}

			// 以上目录都没有的时候再检查内部打包目录
			string resPath = GetResPath(path);
			if (File.Exists(resPath))
			{
				sb.Append(resPath);
			}


			return sb.ToString();
		}
		// 获取打包资源路径
		public static string GetResPath(string path)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(UnityEngine.Application.persistentDataPath).Append("/Resources/").Append(path);

			return sb.ToString();
		}

		// 获取可写目录路径
		public static string GetWritePath(string path)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(UnityEngine.Application.persistentDataPath).Append("/Documents/").Append(path);
			return sb.ToString();
		}
		// 获取WWW可读取路径,会查找可写目录和打包目录,都没有则返回无长度字符串
		public static string GetWWWReadPath(string path)
		{
			StringBuilder sb = new StringBuilder();

			// windows 下检查本地资源目录
			if (UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsEditor ||
				UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsPlayer)
			{
				sb.Append("file:///").Append(Environment.CurrentDirectory).Append("/window_res_dir/").Append(path);
				return sb.ToString();
			}

			// 然后检查可写目录
			string writePath = GetWritePath(path);
			if (File.Exists(writePath))
			{
				sb.Append("file:///").Append(writePath);
				return sb.ToString();
			}

			// 以上目录都没有的时候再检查内部打包目录
			string resPath = GetResPath(path);
			if (File.Exists(resPath))
			{
				sb.Append("file:///").Append(resPath);
			}


			return sb.ToString();
		}
		public static void SaveByteFile(string file, byte[] byteFile)
		{
			string baseLocalUrl = file.Substring(0, file.LastIndexOf("/"));
			try
			{
				if (!Directory.Exists(baseLocalUrl))
				{
					Directory.CreateDirectory(baseLocalUrl);
				}
				if (File.Exists(file))
				{
					File.Delete(file);
					File.WriteAllBytes(file, byteFile);
				}
				else
				{
					File.WriteAllBytes(file, byteFile);
				}
			}
			catch (Exception e)
			{
				Debug.Log("SaveByteFile Exception:" + e.Message);
			}
		}
	}
}