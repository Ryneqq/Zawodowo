﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetText : MonoBehaviour {
    public Text t;
    public void Set(string _t)
    {
        t.text = _t;
    }
}
