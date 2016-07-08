using UnityEngine;
using System.Collections;

public class Vault_R : MonoBehaviour {
	public GameObject Zoom;
	
	void OnTriggerEnter(Collider other){
		if(other.tag=="Vault_R"){
			Zoom.GetComponent<BoxCollider>().enabled = false;
		}
	}
	void OnTriggerExit(Collider other){
		if(other.tag=="Vault_R"){
			Zoom.GetComponent<BoxCollider>().enabled = true;
		}
	}
}

