using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float turnSpeed = 1f;

	
	
    void Update ()
    {
		//Debug.Log ("coeff"+moveSpeed*Time.deltaTime, gameObject);
		
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(transform.forward * moveSpeed);
        
		if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-transform.forward * moveSpeed);
		
		if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(transform.right * moveSpeed);
			
		if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-transform.right * moveSpeed);
		
		if (Input.GetKey(KeyCode.Space))
        {
           // transform.Translate(0,0.2f,0);
			
			 GameObject.Find("bob").transform.Rotate(0, 0, 90);
			
        }
		
   /*     if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed);
    */
    }
	
	
	
}
