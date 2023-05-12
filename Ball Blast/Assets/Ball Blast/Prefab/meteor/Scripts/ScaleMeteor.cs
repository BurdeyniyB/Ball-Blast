using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMeteor
{
    private float coeficient;
    private float newScale;

    public void ChangeScale(float minScale, float maxScale ,int minMeteorValue, int maxMeteorValue, int meteorValue, Transform newMeteor)
    {
        coeficient = (maxScale - minScale) / (maxMeteorValue - minMeteorValue);
        newScale = minScale + (meteorValue - minMeteorValue) * coeficient;
        newMeteor.localScale = new Vector2 (newScale, newScale);        
    }
}
