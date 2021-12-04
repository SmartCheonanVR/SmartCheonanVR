using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPlanet : MonoBehaviour
{
    const float ROTPLANETS = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * Time.deltaTime * ROTPLANETS);
    }
}
