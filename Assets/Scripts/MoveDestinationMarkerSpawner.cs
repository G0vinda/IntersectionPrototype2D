using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDestinationMarkerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject moveDestinationMarkerPrefab;

    private void OnEnable()
    {
        InputManager.OnMoveInput += SpawnMarker;
    }

    private void OnDisable()
    {
        InputManager.OnMoveInput -= SpawnMarker;
    }

    private void SpawnMarker(Vector3 position)
    {
        Instantiate(moveDestinationMarkerPrefab, position, Quaternion.identity);
    }
}
