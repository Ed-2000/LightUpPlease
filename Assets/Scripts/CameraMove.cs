using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private Vector3 _newPos;
    private Vector3 _distances;

    private void Start()
    {
        _newPos = transform.position;

        _distances = _player.position - _newPos;
    }

    private void LateUpdate()
    {
        _newPos.x = _player.position.x - _distances.x;
        _newPos.z = _player.position.z - _distances.z;

        transform.position = _newPos;
    }
}
