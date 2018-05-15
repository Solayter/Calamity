using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PersonController : MonoBehaviour
{
    public FirstPersonController fpsCtrl;
    public GameObject hpBar;
    public float healthPointsMax = 100;
    public float healthPointsValue = 100;
    public int speedRun = 12;
    public int speedJump = 8;

    private void Update()
    {
        //hpBar.transform.lossyScale.Scale(new Vector3(, 1, 1));

        hpBar.transform.localScale = new Vector3(healthPointsValue / healthPointsMax * 0.76F, 1F, 1F);
        fpsCtrl.SetValues(speedRun, speedJump);
    }
}


