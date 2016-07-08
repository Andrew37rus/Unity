using UnityEngine;
using System.Collections;

public class WeaponCamera : MonoBehaviour {
	public GameObject Gan;
	public GameObject Player;
	public GameObject WeaponPlayer;
	public GameObject Pistol;
	
	
	void Start(){
		Gan.SetActive (false);
		Pistol.SetActive (false);
		
	}
	
	void Update(){
		if(Input.GetKey(KeyCode.V)){
			Gan.SetActive (true);
			Player.GetComponent<PlayerShot>(). enabled = false;
			WeaponPlayer.SetActive (false);
			Pistol.SetActive (true);
			
		}
		if(Input.GetKey(KeyCode.B)){
			Gan.SetActive (false);
			Player.GetComponent<PlayerShot>(). enabled = true;
			WeaponPlayer.SetActive (true);
			Pistol.SetActive (false);
			
		}
	}
}

