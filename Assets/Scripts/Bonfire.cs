using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    [SerializeField] private GameObject _fire;

    public void SetOnFire()
    {
        _fire.SetActive(true);
    }
}
