using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerParams : MonoBehaviour {

    public PersonController perCtrl;
    public Text health;
    public Text armor;

    void Update () {
        health.text = "Здоровье: " + perCtrl.healthPointsValue + " из " + perCtrl.healthPointsMax;
        armor.text = "Снижение урона на " + perCtrl.armor;

    }
}
