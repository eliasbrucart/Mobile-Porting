using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public List<WheelCollider> throttleWheels = new List<WheelCollider>();
    public List<WheelCollider> steeringWheels = new List<WheelCollider>();
    public float throttleCoefficient;
    public float maxTurn;
    float giro = 0.0f;
    float acel = 0.2f;

    // Use this for initialization
    void Start () {
		
	}

	
	// Update is called once per frame
	void FixedUpdate () {
        foreach (var wheel in throttleWheels) {
            wheel.motorTorque = throttleCoefficient * Time.deltaTime * acel;
        }
        foreach (var wheel in steeringWheels) {
            wheel.steerAngle = maxTurn * giro;
        }
        giro = 0f;
    }

    public void SetGiro(float giro) {
        this.giro = giro;
    }
    public void SetAcel(float val) {
        acel = val;
    }
}
