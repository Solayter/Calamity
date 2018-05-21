using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGame : MonoBehaviour {

    public Animator animBook;
    public Animator animUI;
    public void StartGame()
    {
        animUI.SetTrigger("GameNow");
        Cursor.visible = false;
    }
    private void Update()
    {
        if (animUI.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Final"))
        {
            animBook.SetTrigger("Open");
            if (animBook.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.End"))
            {
                animUI.SetTrigger("Dark");
            }
        }
        if (animUI.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.State"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
