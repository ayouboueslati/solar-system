using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public GameObject sun;
    public GameObject earthOrbit;
    public GameObject moonOrbit;


    //speed for objects rotations
    public float sunRotationSpeed = 10f;
    public float earthRotationSpeed = 30f;
    public float moonRotationSpeed = 20f;
    public float earthOrbitSpeed = 10f;
    public float moonOrbitSpeed = 15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotation of the sun on its axis
        sun.transform.Rotate(Vector3.up * sunRotationSpeed * Time.deltaTime);

        //Rotation of the earth on its axis
        earthOrbit.transform.GetChild(0).transform.Rotate(Vector3.up * earthRotationSpeed * Time.deltaTime);

        // Rotate the Moon on its axis
        moonOrbit.transform.GetChild(0).transform.Rotate(Vector3.up * moonRotationSpeed * Time.deltaTime);

        // Earth orbits the Sun (rotates the entire EarthOrbit)
        earthOrbit.transform.RotateAround(sun.transform.position, Vector3.up, earthOrbitSpeed * Time.deltaTime);

        // Moon orbits the Earth (rotates the entire MoonOrbit)
        moonOrbit.transform.RotateAround(earthOrbit.transform.GetChild(0).transform.position, Vector3.up, moonOrbitSpeed * Time.deltaTime);

    }
}
