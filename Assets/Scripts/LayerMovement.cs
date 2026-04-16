using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LayerMovement : MonoBehaviour
{
    //Identificar el action map
    public InputActionAsset inputActions;

//Elegimos nuestra acción
    private InputAction _jumpAction;
    
    private bool _isJumpPress;
    private Rigidbody _rb;
    public float force = 50f;


private void OnEnable()
    {
       inputActions.FindActionMap("Player").Enable();
       
    }
    
private void OnDisable()
    {
       inputActions.FindActionMap("Player").Disable();


    }

    private void Awake()
    {
        _jumpAction = inputActions.FindActionMap("Player").FindAction("Jump");
        _rb = GetComponent<Rigidbody>();
       
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
       if (_jumpAction.WasPressedThisFrame())
       {
         
          
           _rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            
       }
       
    }
}
