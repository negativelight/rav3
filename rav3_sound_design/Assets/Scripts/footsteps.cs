using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            instance = FMODUnity.RuntimeManager.CreateInstance("event:/Character/Footsteps");
            instance.start();
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            _ = instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            _ = instance.release();
        }
    }
}
