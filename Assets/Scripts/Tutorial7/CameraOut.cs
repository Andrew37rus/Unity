using UnityEngine;
using System.Collections;

public class CameraOut : MonoBehaviour {
	public GameObject Camera;
	
	void Start(){
		Camera.GetComponent<End3>().enabled = true;
		Camera.GetComponent<End>().enabled = false;
	}
	void Update(){
		if(Input.GetKey(KeyCode.V)){
			Camera.GetComponent<End>().enabled = true;
			Camera.GetComponent<End3>().enabled = false;
		}
		if(Input.GetKey(KeyCode.B)){
			Camera.GetComponent<End3>().enabled = true;
			Camera.GetComponent<End>().enabled = false;
		}
	}
	}

