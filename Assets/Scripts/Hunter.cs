using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hunter : MonoBehaviour
{
    private NavMeshAgent        _agent;
    private Vector3             _target;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _target = Vector3.zero;
    }

    private void Update()
    {

        _agent.SetDestination(_target);
    }

}
