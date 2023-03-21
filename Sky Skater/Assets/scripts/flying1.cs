 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flying1 : MonoBehaviour
{
    public float FlySpeed = 120;
    public float YawAmount = 120;
    private float Yaw;
    public Rigidbody rig;
    public Vector3 respawnPoint;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    private Vector3 aim;
    [SerializeField] private GameObject UI;
    
    void Start()
    {
        respawnPoint = transform.position;
        UI.SetActive(false);
    }

    void Update()
    {   transform.position += transform.forward * FlySpeed * Time.deltaTime;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Yaw += horizontalInput * YawAmount * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 20, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float roll = Mathf.Lerp(0, 30, Mathf.Abs(horizontalInput)) * -Mathf.Sign(horizontalInput);
        transform.localRotation = Quaternion.Euler(Vector3.up * Yaw + Vector3.right * pitch + Vector3.forward * roll);

        if (Input.GetKeyDown(KeyCode.Space))
        { FlySpeed = 240; }
        if (Input.GetKeyUp(KeyCode.Space))
        { FlySpeed = 120; }

        if (UI.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {   UI.SetActive(false);
                transform.position = respawnPoint;
                Yaw = 0;
                pitch = 0;
                roll = 0;
                //transform.localRotation = respawnRotation;


            }
        }
       // aim = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            var bullet = Instantiate(bulletPrefab,bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            //bullet.transform.LookAt(aim);
            bullet.GetComponent<Rigidbody>().velocity=bulletSpawnPoint.forward*10;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "building")
        {
            FlySpeed = 0;
            UI.SetActive(true);
           

        }

    }
}
