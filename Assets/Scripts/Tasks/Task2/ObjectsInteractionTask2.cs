using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private GameObject _lamp;
    [SerializeField] private GameObject _lampRoot;
    
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)   
    private void Awake()
    {
        _lamp.transform.position = _lampRoot.transform.position;
        Instantiate(_lamp);
    }
}