﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownBubble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
