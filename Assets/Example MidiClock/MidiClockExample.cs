using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidiTest : MonoBehaviour
{
    public GameObject cube;

    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MidiJack.MidiMaster.GetMidiClockCounter);

    }

  

}
