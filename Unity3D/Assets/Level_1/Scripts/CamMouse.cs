using UnityEngine;
using System.Collections;

public class CamMouse : MonoBehaviour {

	
	float rotX;
	float rotY;
	public float sensitivity = 7000.0f;
	
	public float moveSpeed = 10f;
    public float turnSpeed = 50f;
	
   void Start()
    {
      	rotY = transform.localEulerAngles.y;
        rotX = transform.localEulerAngles.x;
    }
 
    void Update()
    {
       	rotY += Input.GetAxis("Mouse X")*sensitivity*Time.deltaTime;
        rotX += Input.GetAxis("Mouse Y")*sensitivity*Time.deltaTime;
        
		Debug.Log("Camera angle  x:"+rotY+"y:"+rotX);
		
		transform.localEulerAngles = new Vector3(rotX%360,rotY%360,0);
		
	}
	
	
}
