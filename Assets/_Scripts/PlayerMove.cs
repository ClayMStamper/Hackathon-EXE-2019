using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  
    public float lookSpeed = 50;
    public float moveSpeed = 20;

    [SerializeField] 
    private Transform head, body;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {

        Move();
        RotateX();
        RotateY();
		
    }
    
    private void Move()
    {
		
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
		
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
		
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
		
    }
	
    private void RotateX()
    {
		
        float horizontal = Input.GetAxisRaw("Mouse X");
        transform.Rotate(new Vector3(0 ,horizontal,0) * Time.deltaTime * lookSpeed);

    }

    private void RotateY() {
        
        float vertical = Input.GetAxisRaw("Mouse Y");
        head.Rotate(new Vector3(-vertical ,0 ,0) * Time.deltaTime * lookSpeed);
        
    }
    
}
