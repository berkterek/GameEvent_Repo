using System;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] Color _color;
    [SerializeField] MeshRenderer _meshRenderer;

    [ContextMenu(nameof(ChangeColor))]
    public void ChangeColor()
    {
        _meshRenderer.material.color = _color;
    }
}