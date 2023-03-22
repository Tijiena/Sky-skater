using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float force;
    public GameObject bulletPrefab;
    public GameObject gunEnd;
    private Vector3 aim;
    // Update is called once per frame
    void Update()
    {



        Vector3 mousePos = Input.mousePosition;
        aim = Camera.main.ScreenToWorldPoint(mousePos);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            gunEnd.transform.LookAt(aim);
            GameObject bullet = Instantiate(bulletPrefab, gunEnd.transform.position, Quaternion.identity);
            bullet.transform.LookAt(aim);
            Rigidbody b = bullet.GetComponent<Rigidbody>();
            b.AddRelativeForce(Vector3.forward * force);

        }
    }
}
