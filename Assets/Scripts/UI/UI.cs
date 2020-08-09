using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Text _numberOfActiveBonfiresText;
    [SerializeField] private Text _numberOfMutchesText;

    private int _numberOfActiveBonfires;
    private int _numberOfMutches;

    private void Start()
    {
        _numberOfActiveBonfires = PlayerInventory.BonfiresNumber;
        _numberOfMutches = PlayerInventory.MatchesNumber;
    }

    private void Update()
    {
        if (_numberOfActiveBonfires != PlayerInventory.BonfiresNumber)
        {
            _numberOfActiveBonfiresText.text = (PlayerInventory.BonfiresNumber).ToString() + "/5";
            _numberOfActiveBonfires = PlayerInventory.BonfiresNumber;
        }

        if (_numberOfMutches != PlayerInventory.MatchesNumber)
        {
            _numberOfMutchesText.text = (PlayerInventory.MatchesNumber).ToString();
            _numberOfMutches = PlayerInventory.MatchesNumber;
        }
    }

}
