using UnityEngine;

public class ButtonWithGameEventWithParameter : BaseButton
{
    [SerializeField] Color _color;
    [SerializeField] GameEvent _gameEvent;
    
    protected override void HandleOnButtonClicked()
    {
        _gameEvent.Invoke(_color);
    }
}