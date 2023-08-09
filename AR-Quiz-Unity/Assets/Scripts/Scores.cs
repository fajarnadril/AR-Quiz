using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    [SerializeField] float score,exp;
    public GameObject txtScore;
    TextMeshProUGUI tmpScore;
    TheNilai theNilai;
    GameObject nameScoreChangeScene;
    void Start()
    {
        //nameScoreChangeScene = GameObject.Find("NameScore");
        //theNilai = nameScoreChangeScene.GetComponent<TheNilai>();
        score = 0;
        exp = 0;
        tmpScore = txtScore.GetComponent<TextMeshProUGUI>();
    }

    public void Add_Score()
    {
        score = score + 10;
    }

    public void Add_Exp()
    {
        exp = exp + 1;
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(tmpScore);
        tmpScore.text = score.ToString(); 
        if (exp > 2)
        {
            //pindah scene
        }

    }
}
