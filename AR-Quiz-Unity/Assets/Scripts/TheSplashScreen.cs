using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSplashScreen : MonoBehaviour
{
    public GameObject[] imgs;
    public float[] durationGanti;
    // Start is called before the first frame update
    void Start()
    {
        imgs[0].SetActive(true);
        imgs[1].SetActive(true);
        imgs[2].SetActive(false);
        Invoke("MethodPertama", durationGanti[0]);
    }

    void MethodPertama()
    {
        imgs[0].SetActive(true);
        imgs[1].SetActive(false);
        imgs[2].SetActive(true);
        Invoke("MethodKedua", durationGanti[1]);
    }

    void MethodKedua()
    {
        for (int i = 0; i < 3; i++)
        {
            Destroy(imgs[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
