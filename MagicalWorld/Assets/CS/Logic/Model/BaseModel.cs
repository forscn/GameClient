using System.Collections.Generic;
using Core.I;
namespace CG3D.Model
{
	public class BaseModel : INotification
	{
		protected List<IObserver> listObservers = new List<IObserver>();
		private bool _hasUpdate = false;

		public void AddObserver(IObserver observer)
		{
			if (!listObservers.Contains(observer))
			{
				listObservers.Add(observer);
			}
		}
		public void RemoveObserver(IObserver observer)
		{
			if (listObservers.Contains(observer))
			{
				listObservers.Remove(observer);
			}
		}
		public void RemoveAllObserver()
		{
			listObservers.Clear();
		}
		public void NotifyObserver()
		{
			_hasUpdate = true;
			foreach (IObserver observer in listObservers)
			{
				observer.Notifyed();
			};
			this._hasUpdate = false;
		}
		public bool hasUpdate
		{
			get { return _hasUpdate; }
		}

	}
}