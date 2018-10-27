using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingMenuScript : MonoBehaviour {

    Resolution[] res;

    public Dropdown resDropdown;

    void Start()
    {
        res = Screen.resolutions;
        resDropdown.ClearOptions();
        List<string> options = new List<string>();
        int ResolutionIndex = 0;
        for (int i = 0; i < res.Length; i++)
        {
            string option = res[i].width + "x" + res[i].height;
            options.Add(option);

            if ((res[i].width == Screen.currentResolution.width) && (res[i].height == Screen.currentResolution.height))
            {
                ResolutionIndex = i;
            }
        }

        resDropdown.AddOptions(options);
        resDropdown.value = ResolutionIndex;
        resDropdown.RefreshShownValue();
    }
    public void back(int a)
    {
        if (a == 1)
        {
            SceneManager.LoadScene("StartingMenu");
        }
    }

    public void SetResolution(int i)
    {
        Resolution resolution = res[i];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
       
    }

    public void SetQuality(int i)
    {
        QualitySettings.SetQualityLevel(i);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
