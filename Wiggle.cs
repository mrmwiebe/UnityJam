using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Wiggles a sprite side to side like a stop motion animation.
/// </summary>
public class Wiggle : MonoBehaviour {

    public float rotAmnt = 2;
    public float frequency = 0.5f;
    public float randomAmnt = 0.2f;

    private float finalFreq;
    private float originalZ;
    private float countdown;

	// Update is called once per frame
	void Start () {
        originalZ = transform.localEulerAngles.z;
        finalFreq = frequency + Random.Range(-randomAmnt, randomAmnt);
        StartOver();
	}

    void Update()
    {
        if(countdown > 0)
            countdown -= Time.deltaTime;

        else
            StartOver();
    }

    void StartOver()
    {
        rotAmnt *= -1;

        var rot = transform.localEulerAngles;
        rot.z = originalZ + rotAmnt;
        transform.localEulerAngles = rot;

        countdown = finalFreq;
    }
}
