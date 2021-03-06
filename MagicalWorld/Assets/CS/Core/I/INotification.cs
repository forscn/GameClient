using UnityEngine;
using System;
using System.Collections.Generic;
using CG3D.Utils;
namespace Core.I
{
	public interface INotification
	{
		void AddObserver(IObserver observer);
		void RemoveObserver(IObserver observer);
		void NotifyObserver();
	}
}