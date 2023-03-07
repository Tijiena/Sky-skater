using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying : MonoBehaviour

{
    public float forwardSpeed=25f;
    private float activeForwardSpeed;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        activeForwardSpeed = Input.GetAxisRaw("Vertical");
    }
}
