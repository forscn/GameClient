using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core.Utils
{
	/// <summary>
	/// 计时器
	/// </summary>
	public class TimerUtil : MonoBehaviour
	{
		private static TimerUtil _inst;
		public delegate void Callback();
		private static List<TimerData> listTimerData = new List<TimerData>();
		private static int timerId = 1;
		private static bool isUpdateLoop = false;

		private static void InitSelf()
		{
			if (_inst == null)
			{
				GameObject goInstance = GameObject.Find(Const.STR_STATIC_INSTANCE_NAME);
				if (goInstance == null)
				{
					goInstance = new GameObject(Const.STR_STATIC_INSTANCE_NAME);
					UnityEngine.Object.DontDestroyOnLoad(goInstance);
				}
				_inst = goInstance.AddComponent<TimerUtil>();
			}
		}
		/// <summary>
		/// 单次计时触发器
		/// </summary>
		/// <param name="delta">触发间隔（秒）</param>
		/// <param name="callBack">回调方法</param>
		/// <returns>计时器ID</returns>
		public static int SetTimeOut(float delta, Callback callBack)
		{
			return SetTimeOut(delta, callBack, 1);
		}
		/// <summary>
		/// 重复计时触发器
		/// </summary>
		/// <param name="delta">触发间隔（秒）</param>
		/// <param name="callBack">回调方法</param>
		/// <param name="repeatCount">重复次数，-1表示无限次</param>
		/// <returns>计时器ID</returns>
		public static int SetTimeOut(float delta, Callback callBack, int repeatCount)
		{
			InitSelf();
			TimerData t = new TimerData();
			t.id = timerId;
			timerId++;
			t.delta = t.currDelta = delta;
			t.callBack = callBack;
			t.repeatCount = repeatCount;
			listTimerData.Add(t);
			return t.id;
		}
		/// <summary>
		/// 移除计时器
		/// </summary>
		/// <param name="id">计时器ID</param>
		public static void RemoveTimeOut(int id)
		{
			foreach (TimerData t in listTimerData)
			{
				if (t.id == id)
				{
					if (isUpdateLoop)
					{
						t.repeatCount = 1;
					}
					else
					{
						listTimerData.Remove(t);
					}
					break;
				}
			}
		}
		/// <summary>
		/// 清除所有计时器
		/// </summary>
		public static void ClearTimeOut()
		{
			listTimerData.Clear();
		}
		void Update()
		{
			isUpdateLoop = true;
			int count = listTimerData.Count;
			TimerData t;
			for (int i = 0; i < count; i++)
			{
				t = listTimerData[i];
				t.currDelta -= Time.deltaTime;
				if (t.currDelta <= 0)
				{
					t.callBack();
					t.repeatCount--;
					if (t.repeatCount == 0)
					{
						listTimerData.Remove(t);
						i--;
						count--;
					}
					else
					{
						t.currDelta += t.delta;
					}
				}
			}
			isUpdateLoop = false;
		}
		private class TimerData
		{
			public int id;
			public Callback callBack;
			public float delta;
			public float currDelta;
			public int repeatCount;
		}
	}
}