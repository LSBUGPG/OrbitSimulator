using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kepler : MonoBehaviour
{
    public Rigidbody Sun;
    public Rigidbody Earth;

    void Start()
    {
        // initial velocity of Earth in AU/year
        float speedAtPerihelion = 6.38966f;
        Vector3 start = Vector3.up * speedAtPerihelion * Earth.mass;
        Earth.AddForce(start, ForceMode.Impulse);
        Sun.AddForce(-start, ForceMode.Impulse);
    }


    float maximum = 0.0f;

    void FixedUpdate()
    {
        // G in AU^3 / (SolarMasses * year^2)
        float G = 39.478716f;
        float F = G * Sun.mass * Earth.mass / (Earth.position - Sun.position).sqrMagnitude;
        Sun.AddForce(F * (Earth.position - Sun.position).normalized);
        Earth.AddForce(F * (Sun.position - Earth.position).normalized);
    }
}
