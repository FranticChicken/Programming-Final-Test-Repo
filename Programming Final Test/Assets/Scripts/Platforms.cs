using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FallingPlatforms());
        }

    }

    IEnumerator FallingPlatforms()
    {
        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);

    }
    //oncollision exit wait 5 seconds and drop platform

    // Update is called once per frame
    void Update()
    {
        
    }
}
