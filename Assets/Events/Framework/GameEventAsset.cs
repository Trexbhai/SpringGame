using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GameEvents
{
    // GameEventAsset could be anything: ScreenShake, Play sound, Expplosion.
    public class GameEventAsset<T> : ScriptableObject
    {
        // <T> adds a generic type to our class that is defined when an instance is created.GetComponenet gets components only but this can take anything (floats, strings, gameobjects)
        [SerializeField] private bool _log = true;
        [SerializeField] private T _currentValue;
        public T CurrentValue => _currentValue;
        public UnityEvent<T> OnInvoked;

        public void Invoke(T param)
        {
            //logs event name, paramater value, and pings event asset in project folder when clicked  
            if (_log) Debug.Log($"{name} event invoked: {param}", this);
            _currentValue = param;

            // ?. checks on invoke is null before calling invoke method
            // not necessary for UnityEvents. They chec for null internally
            OnInvoked?.Invoke(param);
        }
    }
}