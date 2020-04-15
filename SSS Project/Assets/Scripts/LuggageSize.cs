using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class LuggageSize : LineRendererDistance
{
    [SerializeField] private Text text;

    private void Update()
    {
        float round = Mathf.Round((_position1.transform.position - _position2.transform.position).magnitude * 10f) / 10f;
        
        text.text = round.ToString(CultureInfo.InvariantCulture) + " CM";
    }
    
    public LuggageSize(GameObject position1, GameObject position2) : base(position1, position2)
    {
        
    }
}
