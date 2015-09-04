using Core.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CG3D.Config
{
	class ConfigManager
	{
		private static ConfigManager _inst;
		public static Dictionary<string, byte[]> dictCfgBytes = new Dictionary<string, byte[]>();
		/// <summary>
		/// �����ļ��İ汾
		/// </summary>
		public static int configVersion = 0;
		/// <summary>
		/// ��Ҫ��ʼ������������
		/// </summary>
		private int totalCount = 0;
		/// <summary>
		/// ��ǰ��ʼ���õ���������
		/// </summary>
		internal int currCount = 0;

		public static ConfigManager GetInstance()
		{
			if (_inst == null)
			{
				_inst = new ConfigManager();
			}
			return _inst;
		}
		/// <summary>
		/// �Ƿ�ȫ����ʼ�����
		/// </summary>
		public bool hasInit
		{
			get { return totalCount > 0 && currCount >= totalCount; }
		}
		public IEnumerator InitCfg()
		{
			//Debug.Log("��ʼ��ʼ������:" + Time.time);
			currCount = -1;
			totalCount = 0;
            ShipCfg.GetInstance().Init("ship.txt", ref totalCount); yield return new WaitForSeconds(0.02f);
			
            //MyDebug.Log("��ʼ�����ý���:" + Time.time);
			currCount += 1;
			yield break;
		}
	}
}
