using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
public float xMax, xMin, zMax, zMin;

}

public class PLayer_controller : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float tilt;
    public Boundary boundary;

    public GameObject shot;
    public Transform ShotSpawn;
    public float FireRate;

    private float nextFire;
    private AudioSource audiosource;
    

     void Start()
    {
        rb = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + FireRate;
            Instantiate(shot, ShotSpawn.position, ShotSpawn.rotation);
            audiosource.Play();
        }

    }

    void FixedUpdate ()
	{
        float moveHorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, movevertical);
        //rb.AddForce(movement*speed,ForceMode.Impulse);
        rb.velocity = movement*speed;

        rb.position = new Vector3
            (
            Mathf.Clamp(rb.position.x,boundary.xMin,boundary.xMax), 
            0.0f,
            Mathf.Clamp(rb.position.z,boundary.zMin, boundary.zMax)
            );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);

        
    }

}
