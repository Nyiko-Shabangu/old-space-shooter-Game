﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvasiveManeuver : MonoBehaviour {

    public float dodge;
    public float Smoothing;
    public float tilt;

    public Vector2 startwait;
    public Vector2 maneuverTime;
    public Vector2 maneuverwait;

    public Boundary boundary;

    private float currentSpeed;
    private float targetManeuver;
    private Rigidbody rb;


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = rb.velocity.z;
        StartCoroutine(Evade());
	}

    IEnumerator Evade()
    {
        yield return new WaitForSeconds(Random.Range(startwait.x, startwait.y));

        while (true)
        {
            targetManeuver = Random.Range(1, dodge) * -Mathf.Sign(transform.position.x);
            yield return new WaitForSeconds(Random.Range(maneuverTime.x, maneuverTime.y));
            targetManeuver = 0;
            yield return new WaitForSeconds(Random.Range(maneuverwait.x, maneuverwait.y));

        }
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float newManeuver = Mathf.MoveTowards(rb.velocity.x, targetManeuver, Time.deltaTime * Smoothing);
        rb.velocity = new Vector3(newManeuver, 0.0f, currentSpeed);
        rb.position = new Vector3
            (
            Mathf.Clamp(rb.position.x,boundary.xMin,boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z,boundary.zMin,boundary.zMax)
            );
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
	}
}
