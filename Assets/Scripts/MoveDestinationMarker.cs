using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MoveDestinationMarker : MonoBehaviour
{
    [SerializeField] private float lifeTime;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        var tweenSequence = DOTween.Sequence();
        var color = _spriteRenderer.color;
        var alphaValue = color.a;
        
        tweenSequence.Append(transform.DOScale(0, lifeTime).SetEase(Ease.InBack));
        tweenSequence.Join(DOVirtual.Float(alphaValue, 0.2f, lifeTime, value =>
        {
            color.a = value;
            _spriteRenderer.color = color;
        })).SetEase(Ease.InBack);
        tweenSequence.OnComplete(() => { Destroy(gameObject); });
    }
}
