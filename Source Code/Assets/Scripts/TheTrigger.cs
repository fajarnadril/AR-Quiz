using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheTrigger : MonoBehaviour
{
    string namaJawaban;
    public GameObject goJawaban;
    Collider2D theDragCollider;
    Draggable ds;
    TheMiniGame theMiniGame;
    [Header("Script Manager")]
    public GameObject theMiniGameGO;
    [HideInInspector]
    public bool benar;

    public GameObject txtBenar;
    public GameObject txtSalah;

    //public float posX, posY;
    void Start()
    {
        benar = false;
        theMiniGame = theMiniGameGO.GetComponent<TheMiniGame>();
        namaJawaban = goJawaban.name;
        theDragCollider = goJawaban.GetComponent<Collider2D>();
        ds = goJawaban.GetComponent<Draggable>();
        txtBenar.SetActive(false);
        txtSalah.SetActive(false);
    }
    
    IEnumerator ShowTxtBenar ()
    {
        txtBenar.SetActive(true);
        yield return new WaitForSeconds(3);
        txtBenar.SetActive(false);
    }

    IEnumerator ShowTxtSalah()
    {
        txtSalah.SetActive(true);
        yield return new WaitForSeconds(3);
        txtSalah.SetActive(false);
    }

    public void triggerSalah()
    {
        theMiniGame.MinusMiniNilai();

        StartCoroutine(ShowTxtSalah());
        //StartCoroutine("ShowTxtSalah");
    }
    public void triggerBenar()
    {
        //Debug.Log("kena");
        theMiniGame.AddMiniNilai();
        ds.isDragged = false;
        theDragCollider.enabled = false;
        StartCoroutine("ShowTxtBenar");

        Destroy(goJawaban);
        //goBentuk.transform.position = new Vector3(posX, posY, 100);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == namaJawaban)
        {
            benar = true;
        } 

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == namaJawaban)
        {
            benar = false;  
        }
    }
}
