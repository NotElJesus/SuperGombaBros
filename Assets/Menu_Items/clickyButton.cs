using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class clickyButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private Image img;
    [SerializeField] private Sprite up, pressed;
    [SerializeField] private TextMeshProUGUI playText;
    [SerializeField] private Vector3 moveOffset;
    [SerializeField] private AudioClip compressClip; // don't need uncompress clip to play sound
    [SerializeField] private AudioSource audioSource;


    public void OnPointerDown(PointerEventData eventData) {
        img.sprite = pressed;
        audioSource.PlayOneShot(compressClip);
        if (playText != null) {
            playText.rectTransform.localPosition += moveOffset;
        }
    }

    public void OnPointerUp(PointerEventData eventData){
        img.sprite=up;
        // audioSource.PlayOneShot(uncompressClip);
        if (playText != null)
        {
            playText.rectTransform.localPosition -= moveOffset;
        }
    }

    public void SwitchScene(string sceneName){
        Time.timeScale=1f;
        SceneManager.LoadScene(sceneName);
    }
    public void LeaveTheGame(){
        Application.Quit();
    }

}
