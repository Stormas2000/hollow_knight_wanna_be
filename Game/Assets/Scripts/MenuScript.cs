using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public void Menu(int a)
    {
        if (a == 1){

        }else if (a == 2){

        }else if (a == 3){
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
