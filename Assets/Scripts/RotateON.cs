using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateON : MonoBehaviour
{
    float speed = 50.0f;
    public bool lightON;
    bool rotateUp;
    bool rotateDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && transform.rotation.eulerAngles.x <= 272) rotateDown = true;
        if (Input.GetKeyDown("2") && transform.rotation.eulerAngles.x >= 357) rotateUp = true;
        
        if (rotateUp)
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
            if (transform.rotation.eulerAngles.x <= 272)
            {
                GetComponent<AudioSource>().Play();
                lightON = true;
                rotateUp = false;
            }
        }

        if (rotateDown)
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
            if (transform.rotation.eulerAngles.x >= 357) rotateDown = false;
        }

        if (transform.rotation.eulerAngles.x > 272)
        {
            lightON = false;
        }
    }
}