using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class TheShowResults : MonoBehaviour
{
    //gameObject Dont Destroy On Load
    GameObject nameScoreWaktuGO;
    TheNilai theNilai;
    TheWaktu theWaktu;

    //text Score Nilai
    public GameObject textMyScoreGO;
    TextMeshProUGUI textMyScore;

    public GameObject bgThankYou;

    //text Name
    public GameObject textMyNameGO;
    TextMeshProUGUI textMyName;
    
    [Header("GoogleForm")]
    public string urlForm;
  

    //url untuk post
    // string urlForm = "https://docs.google.com/forms/d/e/1FAIpQLSdqMDKBV3Lq4ngqrpLC-UtPDqxvwqbo8biXkDqDI1rxJ_zNxQ/formResponse";

    //url asli
    //https://docs.google.com/forms/d/e/1FAIpQLSdqMDKBV3Lq4ngqrpLC-UtPDqxvwqbo8biXkDqDI1rxJ_zNxQ/viewform?usp=sf_link
    void Start()
    {
        // Ambil DontDestroyOnload
        nameScoreWaktuGO = GameObject.Find("NameScoreWaktu");

        //Perintah start ambil script Nilai
        theNilai = nameScoreWaktuGO.GetComponent<TheNilai>();

        //Perintah start ambil script  Waktu
        theWaktu = nameScoreWaktuGO.GetComponent<TheWaktu>();

        textMyScore = textMyScoreGO.GetComponent<TextMeshProUGUI>();
        textMyName = textMyNameGO.GetComponent<TextMeshProUGUI>();

        bgThankYou.SetActive(false);

        showResult();

    }

    void showResult()
    {
        textMyScore.text = theNilai.myScoreQuiz.ToString();
        textMyName.text = theNilai.myName;
    }
    public void SendData()
    {
        StartCoroutine(sendingData());
        bgThankYou.SetActive(true);
    }

    IEnumerator sendingData()
    {
        WWWForm form = new WWWForm();
        // form.AddField("entry.2108232226", theNilai.myName);
        // form.AddField("entry.1323319854", theNilai.myScoreQuiz);
        // form.AddField("entry.264216654", theWaktu.waktuBerjalan.ToString());

        form.AddField("entry.1694465092", theNilai.myName);
        form.AddField("entry.774721870", theNilai.myScoreQuiz);
        form.AddField("entry.905207679", theWaktu.waktuBerjalan.ToString());
     
        UnityWebRequest www = UnityWebRequest.Post(urlForm, form);

        yield return www.SendWebRequest();


    }
}

