using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystemsp;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour, IPointerDownHandler, IPointerDownHandler
{
    [SerializeField] private Image img;
    [SerializeField] private Sprite up, pressed;
    // [SerializeField] private AudioClip compressClip, uncompressClip;
    // [SerializeField] private AudioSource audioSource;

    public void OnPointerDown(PointerEventData eventData) {
        img.Sprite = pressed;
        // audioSource.PlayOneShot(compressClip);
    }

    public void OnPointerUp(PointerEventData eventData){
        img.Sprite=up;
        // audioSource.PlayOneShot(uncompressClip);
    }
}
