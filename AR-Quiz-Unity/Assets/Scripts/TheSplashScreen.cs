using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TheSplashScreen : MonoBehaviour
{
    public GameObject[] imgs;
    public GameObject bg;
    public AudioSource musicBg;
    private float delay = 0f;
    public float valuableDelay;
    
    void Start()
    {
        for (int i = 0; i < imgs.Length; i++)
        {
            TurnOff();
            StartCoroutine(TurnOn(i, delay));
            delay += valuableDelay;       
        }
        StartCoroutine(SplashEnd(Convert.ToInt32(valuableDelay) * imgs.Length));
    }
    void TurnOff()
    {
        for (int j = 0; j < imgs.Length; j++)
        {
            imgs[j].SetActive(false); 
        }
    }

    IEnumerator SplashEnd(int duration)
    {
      yield return new WaitForSeconds(duration);
      bg.SetActive(false);
      musicBg.Play();
      TurnOff();
    }

    IEnumerator TurnOn(int imgID, float duration)
    {
        yield return new WaitForSeconds(duration);
        if (imgID >= 0 && imgID < imgs.Length)
        {
           imgs[imgID].SetActive(true);
        }
    }
}
