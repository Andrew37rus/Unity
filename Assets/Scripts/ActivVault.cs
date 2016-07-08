using UnityEngine;
using System.Collections;

public class ActivVault : MonoBehaviour {
	public GameObject Vault;
	
	void OnTriggerEnter(Collider other){
		if(other.tag=="Emery"){
			Vault.GetComponent<BoxCollider>().enabled = false;
		}
	}
	void OnTriggerExit(Collider other){
		if(other.tag=="Emery"){
			Vault.GetComponent<BoxCollider>().enabled = true;
		}
	}
}
	

	