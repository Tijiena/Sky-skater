using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot1 : MonoBehaviour
{
    
    public GameObject bulletPrefab; 
    public Transform bulletSpawn;
    public float bulletSpeed = 30.0f; 

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z =  10.0f;
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity); 
            Vector3 bulletDirection = (targetPosition - bulletSpawn.position).normalized; 
            bullet.GetComponent<Rigidbody>().velocity = bulletDirection * bulletSpeed; 
        }
    }
}
    
