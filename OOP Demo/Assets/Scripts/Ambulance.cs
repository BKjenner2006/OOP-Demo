using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulance : Vehicle
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

    public void CallInEmergency()
    {
        isEmergency = true;
    }
}
