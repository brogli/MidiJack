using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidiclockExample : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        float clock = MidiJack.MidiMaster.GetMidiClockCounter();
        transform.localScale = new Vector3(clock* 0.5f, clock * 0.5f, 1);

    }
}
