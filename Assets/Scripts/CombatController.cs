using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] private int numberOfBulletsShot = 0;
    [SerializeField] private int maxBullets = 2;
    [SerializeField] private bool canFire = true;
    private MovementController playerMove;

    // Start is called before the first frame update
    void Start()
    {
        playerMove = GetComponent<MovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckCanFire();
        if (Input.GetButtonDown("Fire1") && canFire)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity);
        bullet.GetComponent<Projectile>().FireOnPosX = playerMove.IsFacingRight();
        
        numberOfBulletsShot++;
        CheckCanFire();
    }

    private void CheckCanFire()
    {
        if (numberOfBulletsShot == maxBullets)
        {
            canFire = false;
        }
        else if (numberOfBulletsShot < maxBullets)
        {
            canFire = true;
        }
    }

    public void DecrementNumberOfShots()
    {
        numberOfBulletsShot--; 
    }
}
