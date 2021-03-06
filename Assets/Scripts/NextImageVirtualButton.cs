﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class NextImageVirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

    private VirtualButtonBehaviour vButtonObject;
    ImageGallery image;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        image.next();
        Debug.Log("Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    // Use this for initialization
    void Start () {
        vButtonObject = GetComponent<VirtualButtonBehaviour>();
        vButtonObject.RegisterEventHandler(this);
        image = FindObjectOfType<ImageGallery>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
