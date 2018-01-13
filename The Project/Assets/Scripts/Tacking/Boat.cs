using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour 
{
    private Rigidbody rbody;
    public float turnSpeed = 1000f;
    public float accelerateSpeed = 1000f; 

	// Use this for initialization
	void Start () 
    {
        rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        float h = Input.GetAxis("Horizontal");	
        float v = Input.GetAxis("Vertical");



        rbody.AddTorque(0f,h*turnSpeed*Time.deltaTime,0f);
        rbody.AddForce(transform.forward*v*accelerateSpeed*Time.deltaTime);
	}
}
