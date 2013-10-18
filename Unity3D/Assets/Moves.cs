using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int speed = 5;
		
		if(Input.GetKey("up")){
		Debug.Log ("Hello");
		transform.Translate(Vector3.up*speed, Camera.main.transform);
		}
		
	}
}
