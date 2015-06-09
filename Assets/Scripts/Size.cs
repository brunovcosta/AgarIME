﻿using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Size : MonoBehaviour {
    [SerializeField]
    public float size;

    public float GetSize() {
        return size;
    }

    public delegate void GetEaten();
    public GetEaten OnGetEaten;

    public void Decay() {
        size -= 0.001f * size * Time.fixedDeltaTime;
        if (size < 10f)
            size = 10f;
    }

    public void Eat(Size eaten) {
        size += eaten.size;
        if (eaten.OnGetEaten != null)
            eaten.OnGetEaten();
    }
}