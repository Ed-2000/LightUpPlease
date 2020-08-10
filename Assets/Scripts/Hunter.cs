using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hunter : MonoBehaviour
{
    [SerializeField] private GameObject     _player;
    [SerializeField] private Transform[]    _goals;

    private NavMeshAgent                    _agent;
    private Vector3                         _targetPosition;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _targetPosition = SetRandomTargetPosition(_goals);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (IsApproximatlyEqualTo(transform.position, _targetPosition))
        {
            _targetPosition = SetRandomTargetPosition(_goals);
        }

        _agent.SetDestination(_targetPosition);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _targetPosition = _player.transform.position;
        }
    }

    private bool IsApproximatlyEqualTo(Vector3 tr1, Vector3 tr2, float accuracy = 0.75f)    //повертає true, якщо tr1 знаходиться на відстані accuracy від tr2 
    {
        bool res = false;
        accuracy = Mathf.Abs(accuracy);

        if ((tr1.x + accuracy >= tr2.x && tr1.z + accuracy >= tr2.z) && (tr1.x - accuracy <= tr2.x && tr1.z - accuracy <= tr2.z))
        {
            res = true;
        }

        return res;
    }

    private Vector3 SetRandomTargetPosition(Transform[] positions)
    {
        Vector3 pos = positions[Random.Range(0, positions.Length - 1)].position;
        return pos;
    }
}
