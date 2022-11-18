using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody bulletRb;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            bulletRb.AddForce(transform.forward * 2.0f);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }

    }
}
