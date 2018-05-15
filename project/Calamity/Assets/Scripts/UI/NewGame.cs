using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
