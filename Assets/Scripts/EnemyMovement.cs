using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D enemyRb;
    private bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingRight)
        {
            enemyRb.velocity = Vector2.right * moveSpeed;
        }
        else
        {
            enemyRb.velocity = Vector2.left * moveSpeed;
        }
    }

    public void ToggleIsFacingRight()
    {
        isFacingRight = !isFacingRight;
    }
}
