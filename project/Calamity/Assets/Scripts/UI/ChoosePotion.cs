using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePotion : MonoBehaviour
{
    public PotionController potionCtrl;
    public GameObject frame;
    public Item choosenPotion;
    public int choosenNum;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            choosenPotion = potionCtrl.potionBelt[0];
            frame.transform.localPosition = new Vector3(-198, -0.5F, 0);
            choosenNum = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            choosenPotion = potionCtrl.potionBelt[1];
            frame.transform.localPosition = new Vector3(-123, -0.5F, 0);
            choosenNum = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            choosenPotion = potionCtrl.potionBelt[2];
            frame.transform.localPosition = new Vector3(-46, -0.5F, 0);
            choosenNum = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            choosenPotion = potionCtrl.potionBelt[3];
            frame.transform.localPosition = new Vector3(30, -0.5F, 0);
            choosenNum = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            choosenPotion = potionCtrl.potionBelt[4];
            frame.transform.localPosition = new Vector3(107, -0.5F, 0);
            choosenNum = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            choosenPotion = potionCtrl.potionBelt[5];
            frame.transform.localPosition = new Vector3(183, -0.5F, 0);
            choosenNum = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            choosenPotion = potionCtrl.potionBelt[6];
            frame.transform.localPosition = new Vector3(258, -0.5F, 0);
            choosenNum = 6;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            choosenPotion = potionCtrl.potionBelt[7];
            frame.transform.localPosition = new Vector3(335, -0.5F, 0);
            choosenNum = 7;
        }
    }
    public void Refresh()
    {
        potionCtrl.Refresh();
    }
}
    
        
