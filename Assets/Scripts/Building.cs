using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Building : MonoBehaviour
{
    public enum BuildingType
    {
        Hospital,
        Store,
        Restaurant,
        Childcare,
        Home,
        Office,
        JobCenter,
        Bank,
        Gym
    }
    
    [SerializeField] private BuildingType type;

    [SerializeField] private Sprite hospitalSprite;
    [SerializeField] private Sprite storeSprite;
    [SerializeField] private Sprite restaurantSprite;
    [SerializeField] private Sprite childcareSprite;
    [SerializeField] private Sprite homeSprite;
    [SerializeField] private Sprite officeSprite;
    [SerializeField] private Sprite jobCenterSprite;
    [SerializeField] private Sprite bankSprite;
    [SerializeField] private Sprite gymSprite;
    
    [SerializeField] private Color hospitalColor;
    [SerializeField] private Color storeColor;
    [SerializeField] private Color restaurantColor;
    [SerializeField] private Color childcareColor;
    [SerializeField] private Color homeColor;
    [SerializeField] private Color officeColor;
    [SerializeField] private Color jobCenterColor;
    [SerializeField] private Color bankColor;
    [SerializeField] private Color gymColor;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        SetAppearanceToType();
    }

    private void Update()
    {
        SetAppearanceToType();
    }

    private void SetAppearanceToType()
    {
        switch (type)
        {
            case BuildingType.Hospital:
                _spriteRenderer.sprite = hospitalSprite;
                _spriteRenderer.color = hospitalColor;
                break;
            case BuildingType.Store:
                _spriteRenderer.sprite = storeSprite;
                _spriteRenderer.color = storeColor;
                break;
            case BuildingType.Restaurant:
                _spriteRenderer.sprite = restaurantSprite;
                _spriteRenderer.color = restaurantColor;
                break;
            case BuildingType.Childcare:
                _spriteRenderer.sprite = childcareSprite;
                _spriteRenderer.color = childcareColor;
                break;
            case BuildingType.Home:
                _spriteRenderer.sprite = homeSprite;
                _spriteRenderer.color = homeColor;
                break;
            case BuildingType.Office:
                _spriteRenderer.sprite = officeSprite;
                _spriteRenderer.color = officeColor;
                break;
            case BuildingType.JobCenter:
                _spriteRenderer.sprite = jobCenterSprite;
                _spriteRenderer.color = jobCenterColor;
                break;
            case BuildingType.Bank:
                _spriteRenderer.sprite = bankSprite;
                _spriteRenderer.color = bankColor;
                break;
            case BuildingType.Gym:
                _spriteRenderer.sprite = gymSprite;
                _spriteRenderer.color = gymColor;
                break;
        }
    }

    public BuildingType GetBuildingType()
    {
        return type;
    }
}
