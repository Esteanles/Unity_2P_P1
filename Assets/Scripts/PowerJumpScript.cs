using UnityEngine;

public class PowerJumpScript : MonoBehaviour
{
    
    public float boostAmount = 10f;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
          
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
             
                rb.AddForce(Vector3.up * boostAmount, ForceMode.Impulse);
            }
        }
    }
}
