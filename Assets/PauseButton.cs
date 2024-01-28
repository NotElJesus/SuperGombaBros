using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    // [SerializeField] private AudioClip compressClip, uncompressClip;
    // [SerializeField] private AudioSource audioSource;

    public void SwitchScene(string sceneName){
        Time.timeScale=1f;
        SceneManager.LoadScene(sceneName);
    }

    public void PauseGame(){
        pauseMenu.SetActive(true);
        Time.timeScale=0f;
    }
    public void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
    }
}
