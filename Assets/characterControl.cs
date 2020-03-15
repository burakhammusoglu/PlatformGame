using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz;
    void Start()

    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * hiz*Time.deltaTime,0);
    }
}
