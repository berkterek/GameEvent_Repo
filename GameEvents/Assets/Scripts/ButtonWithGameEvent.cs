using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWithGameEvent : BaseButton
{
    [SerializeField] GameEvent _gameEvent;

    protected override void HandleOnButtonClicked()
    {
        _gameEvent.Invoke();
    }
}