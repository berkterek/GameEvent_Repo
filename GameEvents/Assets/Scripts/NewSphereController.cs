using UnityEngine;

public class NewSphereController : MonoBehaviour
{
    [SerializeField] MeshRenderer _meshRenderer;
    [SerializeField] NormalEventListener _normalEventListener;

    void OnValidate()
    {
        if (_normalEventListener == null)
        {
            _normalEventListener = GetComponent<NormalEventListener>();
        }
    }

    void OnEnable()
    {
        _normalEventListener.ObjectParameterEvent += HandleOnEventTriggered;
    }

    void OnDisable()
    {
        _normalEventListener.ObjectParameterEvent -= HandleOnEventTriggered;
    }
    
    void HandleOnEventTriggered(object value)
    {
        Color color = (Color)value;
        _meshRenderer.material.color = color;
    }
}