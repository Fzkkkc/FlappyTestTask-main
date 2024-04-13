using System.Collections.Generic;
using UnityEngine;

namespace UserInterface.LosePanelUI
{
    public class LosePanelObserver : MonoBehaviour
    {
        private List<IObserver> _observers = new List<IObserver>();
        
        public void AddObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyLosePanelStarted()
        {
            foreach (var observer in _observers)
            {
                observer.OnInspectStarted();
            }
        }

        public void NotifyLosePanelEnded()
        {
            foreach (var observer in _observers)
            {
                observer.OnInspectEnded();
            }
        }
    }
}