using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static int MatchesNumber
    {
        get { return _matchesNumber; }

        set
        {
            _matchesNumber = value;

            if (_matchesNumber < 0)
            {
                _matchesNumber = 0;
            }
        }
    }

    public static int BonfiresNumber
    {
        get { return _bonfiresNumber; }
        set { _bonfiresNumber = value; }
    }

    private static int _matchesNumber;
    private static int _bonfiresNumber;

    
}
