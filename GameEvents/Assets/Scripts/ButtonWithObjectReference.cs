using UnityEngine;

public class ButtonWithObjectReference : BaseButton
{
    [SerializeField] CubeController _cubeController;
    
    protected override void HandleOnButtonClicked()
    {
        _cubeController.ChangeColor();
    }
}