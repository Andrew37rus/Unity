using UnityEngine;
using System.Collections;

public class Vault_C : MonoBehaviour {
	public GameObject Zoom;
	public bool yes;
	
	void OnTriggerEnter(Collider other){
		if(other.tag=="Vault_C"){
			yes=true;
		}
	}
	
	void OnTriggerExit(Collider other){
		if(other.tag=="Vault_C"){
			Zoom.GetComponent<BoxCollider>().enabled = true;
			yes=false;
		}
	}


	void Update () {
	if(yes==true){
			if(Input.GetKey(KeyCode.C)){
			Zoom.GetComponent<BoxCollider>().enabled = false;
		}
	}
	
		if(Input.GetKeyUp(KeyCode.C)){
			Zoom.GetComponent<BoxCollider>().enabled = true;
		}
	}
}

	

