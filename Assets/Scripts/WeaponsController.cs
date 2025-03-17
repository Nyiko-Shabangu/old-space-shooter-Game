using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour {

    public GameObject shot;
    public Transform Shotspawn;
    public float fireRate;
    public float delay;

    private AudioSource audioSource;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
	}
	
	// Update is called once per frame
	void Fire ()
    {
        Instantiate(shot, Shotspawn.position, Shotspawn.rotation);
        audioSource.Play();
	}
}
