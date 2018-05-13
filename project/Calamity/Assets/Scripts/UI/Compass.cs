using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour {

    public Vector3 northDirection;
    public Transform player;
    public RectTransform northLayer;
    
    public void Update()
    {
        ChangeNorthDirection();
    }
    public void ChangeNorthDirection()
    {
        northDirection.z = player.eulerAngles.y;
        northLayer.localEulerAngles = northDirection;
    }
}
