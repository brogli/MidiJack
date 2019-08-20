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
        int[] clock = MidiJack.MidiMaster.GetMidiClockCounters();
        transform.localScale = new Vector3(clock[0]* 0.5f, clock[1] * 0.5f, 1);

    }
}
