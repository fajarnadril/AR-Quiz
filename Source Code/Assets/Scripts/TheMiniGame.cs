using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TheMiniGame : MonoBehaviour
{
    int miniNilai;
    public int bobotNilai;

    public GameObject txtMiniNilaiGO;
    public GameObject imgGantiScene;
    public GameObject parentMiniGame;
    int miniExp;
    GameObject nameScoreWaktuGO;
    TheNilai theNilai;
    TextMeshProUGUI txtMiniNilai;
    TheChangeScene theChangeScene;
     void Start()
    {

        // Ambil DontDestroyOnload
        nameScoreWaktuGO = GameObject.Find("NameScoreWaktu");

        //Perintah start ambil script Nilai
        theNilai = nameScoreWaktuGO.GetComponent<TheNilai>();


        imgGantiScene.SetActive(false);
        txtMiniNilai = txtMiniNilaiGO.GetComponent<TextMeshProUGUI>();
        theChangeScene = this.gameObject.GetComponent<TheChangeScene>();

        miniNilai = miniNilai + theNilai.myScoreQuiz;
        txtMiniNilai.text = miniNilai.ToString();

    }

    public void AddMiniNilai()
    {
        
        miniNilai = miniNilai + bobotNilai;
        txtMiniNilai.text = miniNilai.ToString();
        miniExp++;

    }
    public void MinusMiniNilai()
    {

        miniNilai = miniNilai - (bobotNilai/2);
        if (miniNilai < 0) miniNilai = 0;
        txtMiniNilai.text = miniNilai.ToString();
        
    }

    IEnumerator ShowUIGantiScene()
    {
        Destroy(parentMiniGame);
        imgGantiScene.SetActive(true);
        yield return new WaitForSeconds(3);
        theChangeScene.GantiScene("3Result");
    }

    bool isUpdate;
    void Update()
    {
        if (miniExp > 5 && !isUpdate)
        {
            StartCoroutine("ShowUIGantiScene");
            theNilai.myScoreQuiz = miniNilai;
            isUpdate = true;
        }
    }
}
