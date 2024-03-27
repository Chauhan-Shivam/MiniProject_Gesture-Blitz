using UnityEngine;
using UnityEngine.SceneManagement;

public class inGameUI : MonoBehaviour
{
    [SerializeField] GameObject[] inPlay;
    public void Pause()
    {
        Time.timeScale=0;
        inPlay[0].SetActive(false);
        for(int i=1;i<inPlay.Length;i++)
        {
            inPlay[i].SetActive(true);
        }
    }
    void Start()
    {
        Time.timeScale=1;
        inPlay[0].SetActive(true);
        for(int i=1;i<inPlay.Length;i++)
        {
            inPlay[i].SetActive(false);
        }
    }
    public void Resume()
    {
        Time.timeScale=1;
        inPlay[0].SetActive(true);
        for(int i=1;i<inPlay.Length;i++)
        {
            inPlay[i].SetActive(false);
        }
    }
    public void MainMenu()
    {
        Time.timeScale=1;
        SceneManager.LoadScene(0);
    }
}
