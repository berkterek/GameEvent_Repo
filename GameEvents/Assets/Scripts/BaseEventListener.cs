using UnityEngine;

public abstract class BaseEventListener : MonoBehaviour
{
    [SerializeField] GameEvent _gameEvent;

    void OnEnable()
    {
        _gameEvent.AddEvent(this);
    }

    void OnDisable()
    {
        _gameEvent.RemoveEvent(this);
    }

    public abstract void Notify();
    public abstract void Notify(object value);
}