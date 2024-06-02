using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
    [SerializeField] private GameObject _waffle;
    [SerializeField] private GameObject _waffleRoot;
    private Toaster _toaster;

    private void Start()
    {
        _waffle.transform.position = _waffleRoot.transform.position;

        _toaster = FindObjectOfType<Toaster>();
        _toaster.TimerIsUp += OnTimerIsUp;
    }

    private void OnTimerIsUp()
    {
        Instantiate(_waffle);
    }
}