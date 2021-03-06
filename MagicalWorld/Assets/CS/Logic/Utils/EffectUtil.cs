using CG3D.Config;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace CG3D.Utils
{
	public class EffectUtil
	{
		public static void CreateLightining(Vector3 pos1, Vector3 pos2)
		{
			Object o = Resources.Load("Effect/lightining");
			if (o == null)
			{
				return;
			}
			GameObject go = (GameObject)GameObject.Instantiate(o);
			LineRenderer line = go.GetComponent<LineRenderer>();
			line.SetPosition(0, pos1);
			line.SetPosition(1, pos2);
		}
		public static GameObject CreateEffect(string str, Vector3 pos)
		{
			return CreateEffect(str, pos, Vector3.zero, 5, null, true);
		}
		public static GameObject CreateEffect(string str, Vector3 pos, Transform parent)
		{
			return CreateEffect(str, pos, Vector3.zero, 5, parent, true);
		}
		public static GameObject CreateEffect(string str, Vector3 pos, Transform parent, float delta)
		{
			return CreateEffect(str, pos, Vector3.zero, delta, parent, true);
		}
		public static GameObject CreateEffect(string str, Vector3 pos, Transform parent, bool needAutoDestroy)
		{
			return CreateEffect(str, pos, Vector3.zero, 5, parent, needAutoDestroy);
		}
		public static GameObject CreateEffect(string str, Vector3 pos, Vector3 rotate)
		{
			return CreateEffect(str, pos, rotate, 5, null, true);
		}
		public static GameObject CreateEffect(string str, Vector3 pos, Vector3 rotate, float delta)
		{
			return CreateEffect(str, pos, rotate, delta, null, true);
		}
		public static GameObject CreateEffect(string str, Vector3 pos, Vector3 rotate, float delta, Transform parent, bool needAutoDestroy)
		{
			return CreateEffect(str, pos, Vector3.zero, rotate, delta, parent, needAutoDestroy);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <param name="pos"></param>
		/// <param name="rotate"></param>
		/// <param name="delta">持续时间</param>
		public static GameObject CreateEffect(string str, Vector3 pos, Vector3 scale, Vector3 rotate, float delta, Transform parent, bool needAutoDestroy)
		{
			Object o = Resources.Load("Effect/" + str);
			if (o == null)
			{
				return null;
			}
			GameObject go = (GameObject)GameObject.Instantiate(o);
			if (parent != null) go.transform.parent = parent;
			if (needAutoDestroy)
			{
				DestroySelf ds = go.AddComponent<DestroySelf>();
				ds.delta = delta;
			}
			if (scale != Vector3.zero)
			{
				go.transform.localScale = scale;
			}
			go.transform.localPosition = pos;
			go.transform.Rotate(rotate);
			return go;
		}
	}
}
