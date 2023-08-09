using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonListener : MonoBehaviour
{
    //GameObject[] objSalah = new GameObject[6];
    //[SerializeField] Scores sc;
    //bool isUpdate0 = true;
    //bool isUpdate1 = true;
    //bool isUpdate2 = true;

    [Header("ISI Button ini")]
    public GameObject buttonBenar;
    public GameObject[] buttonsSalah = new GameObject[2];

    [Header("ISI Button ini")]
    public GameObject imgBenar;
    public GameObject imgSalah;

    [Header("ini udah pake FIND")]
    [SerializeField] EventSystem eventSystem;
    [SerializeField] GameObject eventSystemGO;

    [SerializeField] GameObject parentSoal;

    GameObject scriptManager;
    [SerializeField] TheSoal theSoal;

    //gameObject Dont Destroy On Load
    GameObject nameScoreWaktuGO;
    TheNilai theNilai;

    [Header("isi OBJ ini ")]
    public int noImageTarget;
    GameObject[] imageTarget = new GameObject[6];
    GameObject[] obj = new GameObject[6];
    TheShowSoal[] theShowSoal = new TheShowSoal[6];

    void Start()
    {
        // Ambil DontDestroyOnload dan ambil Script The Nilai
        nameScoreWaktuGO = GameObject.Find("NameScoreWaktu");
        theNilai = nameScoreWaktuGO.GetComponent<TheNilai>();

        //Perintah ambil Event System pada Gameobject Dont DestroyOnLoad
        eventSystemGO = GameObject.Find("EventSystem");
        eventSystem = eventSystemGO.GetComponent<EventSystem>();

        //Perintah ambil script TheSoal pada Gameobject Script Manager
        scriptManager = GameObject.Find("ScriptManager");
        theSoal = scriptManager.GetComponent<TheSoal>();


        //Perintah mematikan jawaban benar salah
        imgBenar.SetActive(false);
        imgSalah.SetActive(false);

       //Perintah ambil parent untuk destroy anak (soal setelah jawab)
       parentSoal = GameObject.Find("ParentSoal");


        GetImageTarget();


        //scriptManager = TheSoal._instance;
        //sc = scriptManager.GetComponent<Scores>();

    }

    void GetImageTarget()
    {
        for (int i = 0; i < 6; i++)
        {
            imageTarget[i] = GameObject.Find("ImageTarget" + i);
            obj[i] = imageTarget[i].transform.GetChild(0).gameObject;
            theShowSoal[i] = obj[i].GetComponent<TheShowSoal>();
        }
    }

    void disableButtons ()
    {
        buttonBenar.GetComponent<Button>().interactable = false;
        buttonsSalah[0].GetComponent<Button>().interactable = false;
        buttonsSalah[1].GetComponent<Button>().interactable = false;
        
    }

    void DestroySoal()
    {
        Destroy(parentSoal.transform.GetChild(0).gameObject);
        theSoal.panelBgSoal.SetActive(false);
    }

    bool isUpdateDone;
    void Update()
    {

        if (eventSystem.currentSelectedGameObject == buttonBenar && !isUpdateDone)
        {
            //Debug.Log("benar");
            imgBenar.SetActive(true);
            theNilai.AddScoreQuiz();
            theShowSoal[noImageTarget].showObjBenar();

            Invoke("DestroySoal", 3);
            isUpdateDone = true;
            
            //sc.Add_Score();
            //scriptManager.soalFinish(true);
            // disableButtons();
            //isUpdate0 = false;
            //scriptManager.isSoalShow = false;
        }

        else if (eventSystem.currentSelectedGameObject == buttonsSalah[0] && !isUpdateDone)
        {
            //Debug.Log("salah");
            imgSalah.SetActive(true);
            theNilai.AddScoreQuizSalah();
            theShowSoal[noImageTarget].showObjSalah();

            Invoke("DestroySoal", 3);
            isUpdateDone = true;
       


            //scriptManager.soalFinish(false);
            //disableButtons();
            //isUpdate1 = false;
            //scriptManager.isSoalShow = false;
        }
        else if (eventSystem.currentSelectedGameObject == buttonsSalah[1] && !isUpdateDone)
        {
            //Debug.Log("salah");
            disableButtons();
            imgSalah.SetActive(true);
            theNilai.AddScoreQuizSalah();
            theShowSoal[noImageTarget].showObjSalah();

            Invoke("DestroySoal", 3);
            isUpdateDone = true;
    


            //scriptManager.soalFinish(false);
            //isUpdate2 = false;
            //scriptManager.isSoalShow = false;
        }

    }
}
