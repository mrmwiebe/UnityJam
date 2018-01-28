using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour {

	public float spinSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = transform.eulerAngles;
		rotation.z += spinSpeed;
		transform.eulerAngles = rotation;
	}
}
