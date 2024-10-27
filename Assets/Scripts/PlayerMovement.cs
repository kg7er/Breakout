using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float maxX = 7.5f;

    float HorizMovement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizMovement = Input.GetAxis("Horizontal");
        if ((HorizMovement > 0 && transform.position.x < maxX) || (HorizMovement < 0 && transform.position.x > -maxX))
            {
                transform.position += Vector3.right * HorizMovement * speed * Time.deltaTime;
            }
        
    }
}
