using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private GameObject _matchOnHend;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bonfire" && PlayerInventory.MatchesNumber > 0)
        {
            if (!other.GetComponent<Bonfire>().IsFire)
            {
                other.GetComponent<Bonfire>().SetOnFire();
                PlayerInventory.MatchesNumber--;
                PlayerInventory.BonfiresNumber++;
            }            
        }

        if (other.tag == "Match")
        {
            other.gameObject.SetActive(false);
            PlayerInventory.MatchesNumber++;
        }
    }

    public void UseMatch()
    {
        if (!_matchOnHend.activeSelf && PlayerInventory.MatchesNumber > 0)
        {
            _matchOnHend.SetActive(true);
        }
    }
}
