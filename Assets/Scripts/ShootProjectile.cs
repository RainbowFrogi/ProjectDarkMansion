using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootProjectile : MonoBehaviour
{
    public TextMeshProUGUI BulletText;
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public float shootcooldown;
    //int bulletsLeft = 6;


    private void Start()
    {
    }

    void Update()
    {
        shootcooldown += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && shootcooldown > 0.25f)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            shootcooldown = 0;
        }

        /*if(Input.GetKeyDown(KeyCode.R) && shootcooldown > 0.25f)
        {
            shootcooldown = 0;
            bulletsLeft = 6;
            BulletText.text = "Bullets: " + bulletsLeft;
            BulletText.color = Color.white;
        }*/

        /*if (bulletsLeft == 0)
        {
            BulletText.color = Color.red;
        }*/


    }
}
