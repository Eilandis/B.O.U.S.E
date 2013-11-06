using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 1;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed ,Camera.main.transform);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed);
		
		if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed );
        
 /*       if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * );
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * );
            
  */
    }
}
