using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    private Vector3 aim;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        aim = cam.ScreenToWorldPoint(mousePos);
        if (Input.GetKey(KeyCode.Mouse0))
        {   bulletSpawnPoint.transform.LookAt(aim);
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.transform.LookAt(aim);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * -100;
        }
    }
}
