using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Sample : MonoBehaviour
{
    public int count = 0;
    [SerializeField]
    private float force = 5.5f;
    private Rigidbody _rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        /*Debug.Log("Start is called in object: " + gameObject.name);
        if (speed > 15f || speed < 0f)
        {
            Debug.Log("speed is too high");
        }
        else
        {
            Debug.Log("speed is ok");
        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Loop iteration: " + i + "en gameobject: " + gameObject.name + "");
        }*/
    }
    
    

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update is called");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision detected with: " + other.gameObject.name);
            _rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            Destroy(other.gameObject);
            
        }
        }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
