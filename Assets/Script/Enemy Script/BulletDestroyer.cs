﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wall") || (col.gameObject.CompareTag("Player")) || (col.gameObject.CompareTag("Ennemy")))
        {
            Destroy(gameObject);
        }
    }
}