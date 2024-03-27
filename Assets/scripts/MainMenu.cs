using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject[] mainmenu;
    [SerializeField] GameObject[] options;
    [SerializeField] GameObject[] garage;
    [SerializeField] Transform cam;
    [SerializeField] Transform options_pos;
    [SerializeField] Transform garage_pos;
    [SerializeField] Transform cam_og_pos;
    void Start()
    {
        cam.position=cam_og_pos.position;
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(true);
        }
        for(int i=0;i<options.Length;i++)
        {
            options[i].SetActive(false);
        }
        for(int i=0;i<garage.Length;i++)
        {
            garage[i].SetActive(false);
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
        cam.position=options_pos.position;
        //while(cam.position!=options_pos.position)
        //cam.position=Vector3.Lerp(cam.position,options_pos.position,Time.deltaTime * 10);
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(false);
        }
        for(int i=0;i<options.Length;i++)
        {
            options[i].SetActive(true);
        }
        for(int i=0;i<garage.Length;i++)
        {
            garage[i].SetActive(false);
        }
    }
    public  void BackToMainMenu()
    {
        cam.position=cam_og_pos.position;
        //while(cam.position!=cam_og_pos.position)
        //cam.position=Vector3.Lerp(cam.position,cam_og_pos.position,Time.deltaTime * 10);
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(true);
        }
        for(int i=0;i<options.Length;i++)
        {
            options[i].SetActive(false);
        }
        for(int i=0;i<garage.Length;i++)
        {
            garage[i].SetActive(false);
        }
    }
    public void GarageButtonPressed()
    {
        cam.position=garage_pos.position;
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(false);
        }
        for(int i=0;i<garage.Length;i++)
        {
            garage[i].SetActive(true);
        }
    }
}
