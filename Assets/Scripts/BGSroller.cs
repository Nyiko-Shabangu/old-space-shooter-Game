using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSroller : MonoBehaviour {

    public float Scrollspeed;
    public float tilesizeZ;

    private Vector3 Startposition;

	// Use this for initialization
	void Start ()
    {
        Startposition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float newPostion = Mathf.Repeat(Time.time * Scrollspeed,tilesizeZ);
        transform.position = Startposition + Vector3.forward * newPostion;
	}
}
