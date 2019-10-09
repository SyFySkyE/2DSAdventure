using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWallTrigger : MonoBehaviour
{
    [SerializeField] EnemyMovement enemyMove;

    // Start is called before the first frame update
    void Start()
    {
        enemyMove = GetComponentInParent<EnemyMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyMove.ToggleIsFacingRight();
    }
}
