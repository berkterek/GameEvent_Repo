using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : MonoBehaviour
{
    [SerializeField] protected Button _button;

    void OnValidate()
    {
        if (_button == null)
        {
            _button = GetComponent<Button>();
        }
    }

    void OnEnable()
    {
        _button.onClick.AddListener(HandleOnButtonClicked);
    }

    void OnDisable()
    {
        _button.onClick.RemoveListener(HandleOnButtonClicked);
    }

    protected abstract void HandleOnButtonClicked();
}
