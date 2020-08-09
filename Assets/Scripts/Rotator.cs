using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private GameObject[] _returnables;

    private void Awake()
    {
        for (int i = 0; i < _returnables.Length; i++)
        {
            _returnables[i].transform.Rotate(0, Random.Range(0, 360f), 0);
            _returnables[i].isStatic = true;
        }
    }
}
