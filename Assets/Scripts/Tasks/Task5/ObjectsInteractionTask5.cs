using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    private Shelf[] _shelf;

    private void Start()
    {
        _shelf = FindObjectsOfType<Shelf>();

        foreach (var shelf in _shelf)
        {
            shelf.ItemSpawned += OnItemSpawned;
        }
    }   

    private void OnItemSpawned()
    {
        foreach (var shelf in _shelf)
        {
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
            }
        }
    }
}