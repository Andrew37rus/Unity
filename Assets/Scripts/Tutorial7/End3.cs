using UnityEngine;
using System.Collections;

public class End3 : MonoBehaviour {
	public Transform EndPoint;
	public float speed;
	void Update () {
		transform.position = Vector3.Lerp (transform.position,EndPoint.transform.position, speed);
	
	}
}
