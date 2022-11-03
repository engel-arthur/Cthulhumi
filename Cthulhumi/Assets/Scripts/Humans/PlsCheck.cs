﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlsCheck : MonoBehaviour
{
    public bool isTrigger = false;

    void Start()
    {
        isTrigger = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Wall")) isTrigger = true;
        else if (col.gameObject.layer == LayerMask.NameToLayer("Humans"))
        {
            Human human = col.gameObject.GetComponent<Human>();
            if (human && human.isEnPls())
            {
                isTrigger = true;
            }
        }
    }
}
