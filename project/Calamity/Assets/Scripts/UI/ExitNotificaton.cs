using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitNotificaton : MonoBehaviour
{

    public GameObject notif;
    public void ExitGame()
    {
        notif.SetActive(true);
    }
}
