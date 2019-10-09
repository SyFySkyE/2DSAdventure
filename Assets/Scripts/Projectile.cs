using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    public bool FireOnPosX;

    // Update is called once per frame
    void Update()
    {
        Travel(FireOnPosX);
    }

    public void Travel(bool fireRight)
    {
        FireOnPosX = fireRight;
        if (FireOnPosX)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }

    private void OnDestroy()
    {
        
    }
}
