﻿using UnityEngine;
using System.Collections;

public class Lock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            Events.RoomCompleted.Invoke();
        }
    }
}
