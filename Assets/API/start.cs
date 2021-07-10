using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public bool setUiOpen;
    public bool bestOpen;
    public GameObject setUI;
    public GameObject bestUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartGame()
    {

        SceneManager.LoadScene("SampleScene");

    }
    public void openUI()
    {
        setUiOpen = !setUiOpen;
        setUI.SetActive(setUiOpen);
        if (setUiOpen == true)
        {
            if (Time.timeScale == 1)
            {
                PauseGame();
            }
        }
        if (setUiOpen == false)
        {
            if (Time.timeScale == 0)
            {
                ResumeGame();
            }
        }
    }
    public void openBest()
    {
        bestOpen = !bestOpen;
        bestUI.SetActive(bestOpen);

    }

    void PauseGame()
    {
        Time.timeScale = 0;
        //AudioSource.Pause();
        //isPaused = true;
        //Canvas_HUD.enabled = false;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
