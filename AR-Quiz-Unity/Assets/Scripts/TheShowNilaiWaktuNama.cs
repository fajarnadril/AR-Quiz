using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TheShowNilaiWaktuNama : MonoBehaviour
{

    //gameObject Dont Destroy On Load
    GameObject nameScoreWaktuGO;
    TheNilai theNilai;
    TheWaktu theWaktu;

    //text Nama
    GameObject textMyNameGO;
    TextMeshProUGUI textMyName;

    //text Score Nilai
    GameObject textMyScoreGO;
    TextMeshProUGUI textMyScore;

    //text Score Nilai
    GameObject textWaktuGO;
    TextMeshProUGUI textWaktu;

    TheChangeScene theChangeScene;

    int menit, detik;

    public float waktuKuota;

    [Header("Isi UI ketika End")]
    public GameObject endBerhasil;
    public GameObject endWaktuHabis;
    public string NamaSceneEndBerhasil;
    public string NamaSceneWaktuHabis;

    void Start()
    {

        
            endBerhasil.SetActive(false);
            endWaktuHabis.SetActive(false);
            
            // Ambil DontDestroyOnload
            nameScoreWaktuGO = GameObject.Find("NameScoreWaktu");

            //Perintah start ambil script Nilai
            theNilai = nameScoreWaktuGO.GetComponent<TheNilai>();


            //Perintah start ambil script  Waktu
            theWaktu = nameScoreWaktuGO.GetComponent<TheWaktu>();
            theWaktu.ResetWaktu(waktuKuota);


            //perintah start ambil Gameobject UI Waktu
            textWaktuGO = GameObject.Find("txtWaktu");
            textWaktu = textWaktuGO.GetComponent<TextMeshProUGUI>();


            //perintah start ambil Gameobject UI Nilai
            textMyScoreGO = GameObject.Find("txtScore");
            textMyScore = textMyScoreGO.GetComponent<TextMeshProUGUI>();

            //perintah ambil The Change Script
            theChangeScene = this.GetComponent<TheChangeScene>();


        
    }


    void ShowWaktu()
    {
        theWaktu.FungsiWaktu();
        menit = Mathf.FloorToInt(theWaktu.waktuBerjalan / 60);
        detik = Mathf.FloorToInt(theWaktu.waktuBerjalan % 60);
        textWaktu.text = string.Format("{0:00}:{1:00}", menit, detik);
    }

    void ShowNilai()
    {
        textMyScore.text = theNilai.myScoreQuiz.ToString(); 
    }

    IEnumerator GantiSceneAfterSeconds(int detik, string namaScene)
    {
        yield return new WaitForSeconds(detik);
        theChangeScene.GantiScene(namaScene);
    }




    bool isUpdated;
     void Update()
    {
        ShowWaktu();
        ShowNilai();

        //end waktu habis
        if (theWaktu.waktuBerjalan < 1 && !isUpdated)
        {
            endWaktuHabis.gameObject.SetActive(true);
            StartCoroutine(GantiSceneAfterSeconds(3, NamaSceneWaktuHabis));
            isUpdated = true;
        }

        //end berhasil ketemu semua
        if (theNilai.exp ==6 && !isUpdated)
        {
          
            endBerhasil.gameObject.SetActive(true);
            StartCoroutine(GantiSceneAfterSeconds(3, NamaSceneEndBerhasil));
            isUpdated = true;
        }
        

    }



}
