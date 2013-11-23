using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float turnSpeed = 0.1f;
	
	float rotY;
	
	void Start(){
		
		rigidbody.freezeRotation=true;
		Physics.gravity = new Vector3(0, -5.0F, 0);

	}
	
	
    void Update ()
    {
		//transform.Translate(-transform.forward * 2f);
		
		//Debug.Log ("coeff"+moveSpeed*Time.deltaTime, gameObject);
		
        if(Input.GetKey("z"))
            transform.position += transform.up*moveSpeed;
        
		if(Input.GetKey("s"))
           transform.position -= transform.up*moveSpeed;
		
		if(Input.GetKey("d"))
           transform.position += transform.forward*moveSpeed;
			
		if(Input.GetKey("q"))
            transform.position -= transform.forward*moveSpeed;
		
		if (Input.GetKey(KeyCode.Space))
        {
           // transform.Translate(0,0.2f,0);
			
			 GameObject.Find("bob").transform.Rotate(0, 0, 90);
			
        }
		
		
		
		
	
		
		rotY = Input.mousePosition.x - Screen.width/2;
		
		Debug.Log("y deplacement = "+rotY);
		
		if(rotY >= 100){
			transform.Rotate(Vector3.right, turnSpeed);
		}
		if(rotY <= -100){
			transform.Rotate(Vector3.right, -turnSpeed);			
		}
    }
	
	void OnTriggerEnter(Collider collision) {
		
		Debug.Log("colision");
        if(collision.gameObject.name == "checkpoint"){
			 Debug.Log("checkpoint");
		}
        if(collision.gameObject.name == "Cube"){
			 Debug.Log("stop falling");
			//transform.Translate(-transform.forward * 0);
		}
        
        
    }
	
	
	
}
