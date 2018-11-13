using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float maxTurnAngle = 10;
    public float maxTorque = 10;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public WheelCollider wheelBL;
    public WheelCollider wheelBR;

    // FixedUpdate is called once per physics frame
    void FixedUpdate()
    {
        //front wheel steering
        wheelFL.steerAngle = Input.GetAxis("Horizontal") * maxTurnAngle;
        wheelFR.steerAngle = Input.GetAxis("Horizontal") * maxTurnAngle;
        //rear wheel drive
        wheelBL.motorTorque = Input.GetAxis("Vertical") * maxTorque;
        wheelBR.motorTorque = Input.GetAxis("Vertical") * maxTorque;
    }

}
