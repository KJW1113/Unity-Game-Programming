﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeUI : MonoBehaviour
{
    
    public Text lifeText;

    // Update is called once per frame
    void Update()
    {
        
        lifeText.text = "Life : " +PlayerStats.Life.ToString();
    }
}