using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float turnSpeed = 1f;

	
	void Start(){
		
		Physics.gravity = new Vector3(0, -100.0F, 0);
	}
	
	
    void Update ()
    {
		//Debug.Log ("coeff"+moveSpeed*Time.deltaTime, gameObject);
		
        if(Input.GetKey("z"))
            transform.Translate(transform.up * moveSpeed);
        
		if(Input.GetKey("s"))
            transform.Translate(-transform.up * moveSpeed);
		
		if(Input.GetKey("d"))
            transform.Translate(transform.right * moveSpeed);
			
		if(Input.GetKey("q"))
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
	
	void OnTriggerEnter(Collider collision) {
		
		Debug.Log("colision");
        if(collision.gameObject.name == "checkpoint"){
			 Debug.Log("checkpoint");
		}
        
        
    }
	
	
	
}
