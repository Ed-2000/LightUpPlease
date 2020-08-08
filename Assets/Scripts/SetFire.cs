using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFire : MonoBehaviour
{
    [SerializeField] private float      _burningTime = 7f;

    private float                       _toExtinction;

    private void Start()
    {
        _toExtinction = _burningTime;
    }

    private void Update()
    {
        _toExtinction -= Time.deltaTime;
        if (_toExtinction <= 0)
        {
            gameObject.SetActive(false);
            _toExtinction = _burningTime;
            PlayerInventory.MatchesNumber--;
        }
    }
}
