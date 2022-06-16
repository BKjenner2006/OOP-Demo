using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected float HorsePower { get; set; }
    private AudioSource HonkSound { get; set; }
    private Rigidbody vehicleRb;

    // Start is called before the first frame update
    void Start()
    {
        vehicleRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward()
    {
        vehicleRb.AddForce(Vector3.forward * HorsePower);
    }

    public void Honk()
    {
        HonkSound.Play();
    }
}
