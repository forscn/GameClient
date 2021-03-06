using UnityEngine;
using Core.Utils;

namespace CG3D.Utils
{
    /// <summary>
    /// http://www.xuanyusong.com/archives/2632
    /// IOS专用推送
    /// 
    /// Android上不支持，IOS源生的API中就支持固定时间循环推送，
    /// 而Android上需要自己开启一个Services，启动一个AlarmManager的定时器任务
    /// </summary>
    public class IOSNotification : MonoBehaviour
	{
		private static bool hasInit =false;
		private static string[] arrData;
		public static void InitData(string[] arr)
		{
			hasInit = true;
			arrData = arr;
			int count = arrData.Length / 2;
			for (int i = 0; i < count; i++)
			{
				arrData[i * 2 + 1] = Locale.GetString(arrData[i * 2 + 1]);
				MyDebug.Log("通知：" + arrData[i * 2] + "," + arrData[i * 2 + 1]);
			}
			DoNotification();
		}
		//本地推送
		public static void NotificationMessage(string message, int hour, int minute, bool isRepeatDay)
		{
			int year = System.DateTime.Now.Year;
			int month = System.DateTime.Now.Month;
			int day = System.DateTime.Now.Day;
			System.DateTime newDate = new System.DateTime(year, month, day, hour, minute, 0);
			NotificationMessage(message, newDate, isRepeatDay);
		}
		//本地推送 你可以传入一个固定的推送时间
		public static void NotificationMessage(string message, System.DateTime newDate, bool isRepeatDay)
		{
#if UNITY_IPHONE
			CleanNotification();
			LocalNotification localNotification = new LocalNotification();
			localNotification.fireDate = newDate;
			localNotification.alertBody = message;
			localNotification.applicationIconBadgeNumber = 1;
			localNotification.hasAction = true;
			if (isRepeatDay)
			{
				//是否每天定期循环		
				localNotification.repeatCalendar = CalendarIdentifier.ChineseCalendar;
				localNotification.repeatInterval = CalendarUnit.Day;
			}
			localNotification.soundName = LocalNotification.defaultSoundName;
			NotificationServices.ScheduleLocalNotification(localNotification);
			MyDebug.LogWarning("DO通知：" + message + "," + newDate);
#endif
		}
		void Awake()
		{
			//第一次进入游戏的时候清空，有可能用户自己把游戏冲后台杀死，这里强制清空	
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
				GameObject.DontDestroyOnLoad(gameObject);
			}
		}
		private static void DoNotification()
		{
			if (hasInit)
			{
				int count = arrData.Length / 2;
				for (int i = 0; i < count; i++)
				{
					string[] arrTime = arrData[i * 2].Split(":"[0]);
					if (arrTime.Length < 2)
					{
						MyDebug.LogError("通知时间：" + arrData[i * 2] + " 不满足格式HH:MM");
						continue;
					}
					NotificationMessage(arrData[i * 2 + 1], int.Parse(arrTime[0]), int.Parse(arrTime[1]), true);
				}
			}
			//10秒后发送	
			//NotificationMessage("whats msg: 10秒后发送", System.DateTime.Now.AddSeconds(10), false);
		}
		//清空所有本地消息
		private static void CleanNotification()
		{
#if UNITY_IPHONE
			LocalNotification l = new LocalNotification();
			l.applicationIconBadgeNumber = -1;
			NotificationServices.PresentLocalNotificationNow(l);
			NotificationServices.CancelAllLocalNotifications();
			NotificationServices.ClearLocalNotifications();
#endif
		}
	}
}