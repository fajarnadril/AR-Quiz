using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update

    int[] exp = new int[5];
    int nilaiAcak;

    public int hasilBanding;
    bool isKetemu;
    bool isDonePeriksa;
    int ulang;
    void Start()
    {
        
        createData();

        //do
        //{
        //    PeriksaRandom(1, 7);
        //} while (ulang == 1);
        PeriksaRandom(1, 7);
        int nilaiAcakAhir = nilaiAcak;
        print("nilaiAcakAkhir" + nilaiAcakAhir);
    }

    public void PeriksaRandom(int a, int b)
    {
        nilaiAcak = Random.RandomRange(a, b);
       // Debug.Log("Hasil Random... nilaiAcak=" + nilaiAcak);
        isDonePeriksa = false;
        periksa(nilaiAcak);
       
    }
    public void periksa(int nilaiPembanding)
    {
        for (int i=0; i<exp.Length; i++)
        {
            hasilBanding = exp[i].CompareTo(nilaiPembanding);
            //Debug.Log("searching..." + exp[i] + "hasilBanding=" +hasilBanding);
            if (hasilBanding == 0)
            {
                int ulang = 1;
                PeriksaRandom(1, 7);
            }

        }

    }

    void createData()
    {
        for (int i = 0; i < 5; i++)
        {
            exp[i] = i;
        }
    }



    // Update is called once per frame

}
