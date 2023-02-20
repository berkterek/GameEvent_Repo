using UnityEngine;
using UnityEngine.Events;

public class UnityEventListener : BaseEventListener
{
    [SerializeField] UnityEvent _unityEvent;
    [SerializeField] UnityEvent<object> _unityEventWithParameter;

    public override void Notify()
    {
        _unityEvent.Invoke();
    }

    public override void Notify(object value)
    {
        _unityEventWithParameter.Invoke(value);   
    }
}