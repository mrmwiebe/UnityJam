using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Follows a target (eventually smoothly)
/// </summary>
public class Follow : MonoBehaviour {

	public Transform target;
    public float lerp = 1f;
    private Vector3 velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, lerp);
    }
}
