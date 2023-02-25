using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum BodyShape 
    {
        Triangle,
        Square,
        Circle
    }
    
    [SerializeField] private SpriteRenderer bodyRenderer;
    [SerializeField] private SpriteRenderer faceRenderer;
    [SerializeField] private Sprite happyFace;
    [SerializeField] private Sprite angryFace;
    [SerializeField] private Sprite triangleBody;
    [SerializeField] private Sprite squareBody;
    [SerializeField] private Sprite circleBody;

    public BodyShape Shape { get; private set; }
        
    public void SetToAngry()
    {
        faceRenderer.sprite = angryFace;
    }

    public void SetToHappy()
    {
        faceRenderer.sprite = happyFace;
    }

    public void SetBodyColor(Color color)
    {
        bodyRenderer.color = color;
    }

    public void SetBodyShape(BodyShape shape)
    {
        Shape = shape;
        switch (shape)
        {
            case BodyShape.Triangle:
                bodyRenderer.sprite = triangleBody;
                break;
            case BodyShape.Square:
                bodyRenderer.sprite = squareBody;
                break;
            case BodyShape.Circle:
                bodyRenderer.sprite = circleBody;
                break;
        }
    }

}
