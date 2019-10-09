using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    [SerializeField] CombatController player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("destory");
        if (collision.gameObject.tag == "Player Bullet")
        {
            player.DecrementNumberOfShots(); // TODO Tech debt. Should this be in bullet?
            Destroy(collision.gameObject);
        }
    }
}
