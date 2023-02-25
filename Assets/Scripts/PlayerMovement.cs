using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
    }

    private void OnEnable()
    {
        InputManager.OnMoveInput += HandlePlayerTouch;
    }

    private void HandlePlayerTouch(Vector3 touchPosition)
    {
        _agent.SetDestination(touchPosition);
    }
}
