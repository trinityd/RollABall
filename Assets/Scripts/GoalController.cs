using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {

    public float xRotationSpeed;
    public float yRotationSpeed;
    public float zRotationSpeed;

    private Vector3 spin;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        spin = new Vector3(xRotationSpeed, yRotationSpeed, zRotationSpeed);
        transform.Rotate(spin * Time.deltaTime);
	}
}
