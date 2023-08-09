using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TheWaktu : MonoBehaviour
{
 
    public float waktuBerjalan;
    float menit;
    float detik;
    // Start is called before the first frame update
    public void ResetWaktu(float waktuKuota)
    {
        waktuBerjalan = waktuKuota;
    }

    public void FungsiWaktu()
    {
        waktuBerjalan = waktuBerjalan - Time.deltaTime;
    }



    
}
