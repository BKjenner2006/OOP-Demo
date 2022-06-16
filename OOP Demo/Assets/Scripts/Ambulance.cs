using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulance : Vehicle //Inheritence
{
    private AudioSource SirenSound { get; set; }
    private bool isEmergency = false;

    // Start is called before the first frame update
    void Start()
    {
        HorsePower = 12;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlaySiren()
    {
        SirenSound.Play();
    }

    public void CallInEmergency() //Abstraction, i guess
    {
        isEmergency = true;
        PlaySiren();
    }

    public override void MoveForward() //Polymorphism
    {
        if (isEmergency)
        {
            vehicleRb.AddForce(Vector3.forward * HorsePower * 2); //add the super boost!
        }
        else
        {
            base.MoveForward();
        }
    }
}
