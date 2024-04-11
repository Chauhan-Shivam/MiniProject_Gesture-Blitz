using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] float speed=10f;
    [SerializeField] GameObject[] mainmenu;
    [SerializeField] GameObject[] options;
    [SerializeField] GameObject[] garage;
    [SerializeField] GameObject[] information;
    [SerializeField] Transform cam;
    [SerializeField] Transform options_pos;
    [SerializeField] Transform garage_pos;
    [SerializeField] Transform cam_og_pos;
    [SerializeField] TMP_Text controlText;
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
        for(int i=0;i<information.Length;i++)
        {
            information[i].SetActive(false);
        } 
    }
    public void  StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    void ChangePos(Transform finalPos)
    {
        while(gameObject.transform.position!=finalPos.position)
        gameObject.transform.position=Vector3.Lerp(transform.position,finalPos.position,Time.deltaTime * speed);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Options()
    {
        //changePos(options_pos);
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
        for(int i=0;i<information.Length;i++)
        {
            information[i].SetActive(false);
        } 
    }
    public  void BackToMainMenu()
    {
        //changePos(cam_og_pos);
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
        for(int i=0;i<information.Length;i++)
        {
            information[i].SetActive(false);
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
        for(int i=0;i<information.Length;i++)
        {
            information[i].SetActive(false);
        } 
    }
    public void ChangeControl()
    {
        if(controlText.text=="GESTURE")
            controlText.text="MANUAL";
        else
            controlText.text="GESTURE";
    }
    public void InfoButtonPressed()
    {
        for(int i=0;i<mainmenu.Length;i++)
        {
            mainmenu[i].SetActive(false);
        }
        for(int i=0;i<garage.Length;i++)
        {
            garage[i].SetActive(false);
        }
        for(int i=0;i<options.Length;i++)
        {
            options[i].SetActive(false);
        }
        for(int i=0;i<information.Length;i++)
        {
            information[i].SetActive(true);
        } 
    }
}
