public class NormalEventListener : BaseEventListener
{
    public event System.Action NoParameterEvent;
    public event System.Action<object> ObjectParameterEvent; 

    public override void Notify()
    {
        NoParameterEvent?.Invoke();
    }

    public override void Notify(object value)
    {
        ObjectParameterEvent?.Invoke(value);
    }
}