using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawner : MonoBehaviour
{
    [SerializeField] private Transform[]        _positions;
    [SerializeField] private int                _numberOfBonfires;
    [SerializeField] private GameObject         _bonfirePrefab;

    private List<GameObject>                    _bonfires;
    private List<int>                           _positionsNumber;

    private void Start()
    {
        _bonfires = new List<GameObject>();
        _positionsNumber = new List<int>();

        while(_positionsNumber.Count != _numberOfBonfires)
        {
            int number = Random.Range(0, _positions.Length);
            if (!EntryCheck(number, _positionsNumber))
            {
                _positionsNumber.Add(number);
            }
        }

        for (int i = 0; i < _numberOfBonfires; i++)
        {
            GameObject newBonfire = Instantiate(_bonfirePrefab, _positions[_positionsNumber[i]]);
            //_bonfires.Add(newBonfire);
        }
    }

    private bool EntryCheck(int number, List<int> numbers)
    {
        foreach (var num in numbers)
        {
            if (number == num) return true;
        }

        return false;
    }

}
