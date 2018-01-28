using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class DestroyOnParticleEnd : MonoBehaviour {

    private ParticleSystem ps;
    private float waitTime = 0.1f;

	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        waitTime -= Time.deltaTime;
        if (ps.particleCount <= 0 && waitTime <= 0)
            Destroy(gameObject);
	}
}
