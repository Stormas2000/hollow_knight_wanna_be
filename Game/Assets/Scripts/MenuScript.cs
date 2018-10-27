using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {

    public void Menu(int a)
    {
        if (a == 1){

        }else if (a == 2){
            SceneManager.LoadScene("SettingsMenu");
        }
        else if (a == 3){
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
