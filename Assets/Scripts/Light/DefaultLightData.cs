using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//I have no idea if I set this up the right way so please excuse the janky naming conventions
//also the wacky organization
public class DefaultLightData : MonoBehaviour
{
    public Lighting startLighting;
    public Light lights;
    // Start is called before the first frame update
    void Start()
    {
        lights.color = startLighting.lightColor;
    }

}
