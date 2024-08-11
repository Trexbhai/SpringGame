using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GameEvents
{
    public abstract class GameEventListener<T> : MonoBehaviour
    {
        [SerializeField] private GameEventListener<T> _gameEventAsset;

        public UnityEvent<T> OnGameEventInvoked;


        //subscribe to GameEvent when this component is enabled
        private void OnEnable()
        {
            _gameEventAsset.OnGameEventInvoked.AddListener(GameEventInvoked);
        }

        //unsubscribe from GameEvent when this component is disabled
        private void OnDisable()
        {
            _gameEventAsset.OnGameEventInvoked.RemoveListener(GameEventInvoked);
        }

        private void GameEventInvoked(T param)
        {
            OnGameEventInvoked.Invoke(param);
        }
    }
}