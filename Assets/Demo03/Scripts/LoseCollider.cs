﻿using Demo03.Scripts;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameSessionScritableObject.Instance.TriggerLoseCollider();
    }
}
