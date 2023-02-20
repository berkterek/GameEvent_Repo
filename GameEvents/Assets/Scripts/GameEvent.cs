using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Terek Gaming/Events/Game Event")]
public class GameEvent : ScriptableObject
{
    HashSet<BaseEventListener> _events;

    void OnEnable()
    {
        _events = new HashSet<BaseEventListener>();
    }

    public void AddEvent(BaseEventListener eventListener)
    {
        _events.Add(eventListener);
    }

    public void RemoveEvent(BaseEventListener eventListener)
    {
        if (_events.Contains(eventListener))
        {
            _events.Remove(eventListener);
        }
    }

    public void Invoke()
    {
        foreach (var eventListener in _events)
        {
            eventListener.Notify();
        }
    }

    public void Invoke(object value)
    {
        foreach (var eventListener in _events)
        {
            eventListener.Notify(value);
        }
    }
}