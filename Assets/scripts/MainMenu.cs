using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject[] mainmenu;
    [SerializeField] GameObject[] options;
    [SerializeField] Transform cam;
    [SerializeField] Transform settings_pos;
    void Start()
    {
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(true);
        }
        for(int i=0;i<options.Length;i++)
        {
            options[i].SetActive(false);
        }
    }
    public void  StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Settings()
    {
        //cam.position=settings_pos.position;
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(false);
        }
        for(int i=0;i<options.Length;i++)
        {
            options[i].SetActive(true);
        }
    }
    public  void BackToMainMenu()
    {
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(true);
        }
        for(int i=0;i<options.Length;i++)
        {
            options[i].SetActive(false);
        }
    }
}
