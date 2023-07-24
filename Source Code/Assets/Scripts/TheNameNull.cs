using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TheNameNull : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject startButtonGO;
    public bool isEmpty;
    public bool isUpdate;
    void Start()
    {
        isEmpty = false;
    }
   

    public void cekIsi()
    {
        startButtonGO.GetComponent<Button>().interactable = (inputField.text != string.Empty);
    }
}
