using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private GameObject _finish;

    private void Update()
    {
        if (PlayerInventory.BonfiresNumber == 5)
        {
            _finish.SetActive(true);
        }
    }
}
