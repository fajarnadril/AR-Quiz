using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSoal : MonoBehaviour
{
    //public KelompokSoal[] MeshSoal;
    //private bool[] showedSoal;
    //public GameObject panelPertanyaan;
    //public bool isMunsulSoal = false;
    //[SerializeField] int acak;


    //private void Awake()
    //{
    //    Debug.Log("a");
    //    _instance = this;
    //    showedSoal = new bool[soalPrefabs.Length];
    //    for(int i = 0; i < showedSoal.Length; i++)
    //    {
    //        showedSoal[i] = false;
    //    }
    //}
    //public void showSoal(int awal, int akhir)
    //{
    //    //Acak_Soal(awal, akhir);
    //    Debug.Log("b");
    //    if (acak == -1) Debug.Log("c"); return;

    //    tempObj = Instantiate(soalPrefabs[acak], panelPertanyaan.transform);
    //    Debug.Log("d");
    //    panelPertanyaan.SetActive(true);
    //    isMunsulSoal = true;
    // //   Instantiate_Soal(acak, 0, 1, 2, 0);
    //}

    //public void soalFinish(bool benar)
    //{
    //    Debug.Log("e");
    //    isMunsulSoal = false;
    //    if ( benar)
    //    {
    //        showedSoal[acak] = true;
    //    }
    //    panelPertanyaan.SetActive(false);
    //    Destroy(tempObj.gameObject);
    //}
    // Start is called before the first frame update

    //void Acak_Soal(int rangeAwal, int rangeAkhir)
    //{
    //    Debug.Log("f");
    //    int test = 0;
    //    do
    //    {
    //        Debug.Log("g");
    //        acak = Random.RandomRange(rangeAwal, rangeAkhir);
    //        test++;
    //        Debug.Log("h");
    //        if (test >= 100)
    //        {
    //            Debug.Log("i");
    //            acak = -1;
    //            return;
    //        }
    //    } while (showedSoal[acak] == true);
    //    Debug.Log("j");
    //}


    //[Header("3D Mesh")]
    //public GameObject[] theMeshRender;

    [Header("Prefab Soal")]
    public GameObject[] soalPrefabs;


    [Header("Panel Tempat Instantiate Soal")]
    public GameObject parentSoal;

    public static TheSoal _instance;
    private GameObject tempObj;

    [Header("nilai Acak")]
    [SerializeField] int nilaiAcak;

    [Header("ini Background putih belakang Soal")]
    public GameObject panelBgSoal;
    [Header("boolean kondisi Soal nyala?")]
    public bool isSoalShow;


    private void Start()
    {
        panelBgSoal.SetActive(false);
    }

    public void MyAcak (int rangeAwal, int rangeAkhir)
    {
        nilaiAcak = Random.RandomRange(rangeAwal, rangeAkhir+1);
    }

    public void MyInstantiateSoal(int nilaiLocalAcak, int soalA, int soalB, int soalC)
    {
        //Debug.Log("nilaiLocalAcak = " + nilaiLocalAcak);
        //Debug.Log("int SoalC = " + soalC);
        if (nilaiLocalAcak == soalA)
        {
            Instantiate(soalPrefabs[soalA], parentSoal.transform);
            isSoalShow = true;
        }
        else if (nilaiLocalAcak == soalB)
        {
            Instantiate(soalPrefabs[soalB], parentSoal.transform);
            isSoalShow = true;
        }
        else if (nilaiLocalAcak == soalC)
        {
            Instantiate(soalPrefabs[soalC], parentSoal.transform);
            isSoalShow = true;
        }
    }

    public void AcakAndInstantiate (int nilaiLocalAcak, int a, int b, int c)
    {
        MyAcak(a, c);
        nilaiLocalAcak = nilaiAcak;
       // Debug.Log("Nilai Local Acak" + nilaiLocalAcak);
        MyInstantiateSoal(nilaiLocalAcak, a, b, c);
  
    }


    void Update()
    {

        //if (theMeshRender[0].gameObject.GetComponent<MeshRenderer>().enabled == true)
        //{
        //    MyAcak(0, 3);
        //    MyInstantiateSoal(nilaiAcak, a0, a1, a2);
        //    isAcakSoal[0] = true;
        //}


    }





}
