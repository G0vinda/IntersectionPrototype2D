using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarMovement : MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] private Sprite[] carSprites;

    [Header("Movement Values")] 
    [SerializeField] private float speed;
    [SerializeField] private float distanceUntilRespawn;

    private SpriteRenderer _spriteRenderer;
    private Vector3 _startPosition;
    private float _drivenDistance;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startPosition = transform.position;
        Reset();
    }

    private void Reset()
    {
        var spriteIndex = Random.Range(0, carSprites.Length);
        _spriteRenderer.sprite = carSprites[spriteIndex];
        _drivenDistance = 0;
    }

    private void Update()
    {
        var speedFactor = speed * Time.deltaTime;
        transform.localPosition += transform.up * speedFactor;
        _drivenDistance += speedFactor;
        if (_drivenDistance >= distanceUntilRespawn)
        {
            transform.position = _startPosition;
            Reset();
        }
    }
}
