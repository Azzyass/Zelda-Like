﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EMD_Sentences : MonoBehaviour
{
    public string PNJType;
    public string PNJName;

    [TextArea(3, 10)]
    public string[] sentences;
}
