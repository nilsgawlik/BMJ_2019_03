﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public string packageID;

    public string soundEffectID;

    private void OnMouseDown() {
        Package currentPackage = GameController.instance.currentPackage;
        if (currentPackage != null) {
            if(currentPackage.packageID == packageID && GameController.instance.tries < GameController.instance.maxTries) {
                GameController.instance.UseTry();
                // do interaction!
                GameController.instance.GetSoundEffect(soundEffectID).Play();
            }
        }
    }
}
