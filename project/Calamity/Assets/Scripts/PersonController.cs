using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PersonController : MonoBehaviour
{
    public FirstPersonController fpsCtrl;
    public GameObject hpBar;
    public Death dth;
    public float healthPointsMax = 100;
    public float healthPointsValue = 100;
    public float armor = 1;
    public int speedRun = 12;
    public int speedJump = 8;

    private void Update()
    {
        if (healthPointsValue < 0)
        {
            healthPointsValue = 0;
            Death();
        }
        if (healthPointsValue > 0)
            hpBar.transform.localScale = new Vector3(healthPointsValue / healthPointsMax * 0.76F, 1F, 1F);
        else if (healthPointsValue == 0)
            hpBar.transform.localScale = new Vector3(0F, 1F, 1F);

        
    }
    private void Death()
    {
        gameObject.tag = "Untagged";
        dth.End();
    }
}


