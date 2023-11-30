using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    bool isMoving = false;
    Rigidbody rb;
    bool startX = false;
    bool startZ = false;
    public float speed;
    bool gameIsOver = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Diamond"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Death"))
        {
            gameIsOver = true;
        }
    }

    public bool ReturnGameOverStatus()
    {
        return gameIsOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isMoving == false)
            {
                isMoving = true;
                startX = true;
            }
            else if( startX == true)
            {
                startX = false;
                startZ = true;
            }
            else if(startZ == true)
            {
                startX = true;
                startZ = false;
            }

        }
        if(isMoving == true && startX == true)
        {
            rb.AddForce(Vector3.right * speed, ForceMode.Force);
        }
        if(isMoving == true && startZ == true)
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.Force);
        }



    }
}
