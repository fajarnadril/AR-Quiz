using System.Collections;
using System.Collections.Generic;
using UnityEngine;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheJawaban : MonoBehaviour
{
    public TheNilai theNilai;

    // Start is called before the first frame update
    void Awake()
    {
        theNilai = GetComponent<TheNilai>();
        //Debug.Log("Awake on, TheNilai=" + TheNilai.nilai);
    }

    public void Jawaban_Benar()
    {

    }

    public void Jawaban_Salah()
    {

    }
}
