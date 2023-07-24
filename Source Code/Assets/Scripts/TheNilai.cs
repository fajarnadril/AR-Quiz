using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TheNilai : MonoBehaviour
{
    public int myFinalScores;
    public string myName;
    public int myScoreQuiz;
    public int scoreBobot;
    public int exp;
    public TMP_InputField inputField;
    TextMeshProUGUI tmpScore;


    public void SubmitButton()
    {
        myName = inputField.text;
        Debug.Log(myName);
    }

    public void AddScoreQuiz ()
    {
        myScoreQuiz = myScoreQuiz + scoreBobot;
        exp = exp + 1;
    }

    public void AddScoreQuizSalah()
    {
        //myScoreQuiz = myScoreQuiz - 5;
        exp = exp + 1;
    }
    



}
