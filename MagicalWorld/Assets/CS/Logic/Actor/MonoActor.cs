using UnityEngine;
using System.Collections;

//using CG3D.Scene;
using CG3D.Config;
using System.Collections.Generic;
//using CG3D.UI.Bean;
//using CG3D.Data;
using Core.Utils;
using CG3D.Utils;
using CG3D.Model;

namespace CG3D.Actor
{
	public class MonoActor : MonoBehaviour
	{
		
		// 初始化调用
		public virtual void Awake()
		{
			
		}
		void Update()
		{
			
		}
	
		public virtual void DestroySelf()
		{
			GameObject.Destroy(gameObject);
		}
	}
}
