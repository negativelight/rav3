using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instance = FMODUnity.RuntimeManager.CreateInstance("event:/Character/Jump");
            instance.start();
        }
    }
}
