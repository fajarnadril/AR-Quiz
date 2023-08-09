using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TheShowSoal : MonoBehaviour
{
    //public int awal;
    //public int akhir;
    //private bool wasShow;
    //int indexSoalAwal, indexSoalAkhir;

    [Header("ISI gamebject benar salah")]
    public GameObject obj;
    public GameObject objBenar;
    public GameObject objSalah;
    MeshRenderer objMeshRender;
    Collider objCollider;

    [Header("ISI range Nilai Acak dan Gameobject Script Manager")]
    public int soalA, soalB, soalC;
    public GameObject scriptManager;
    TheSoal theSoal;


    private void Start()
    {
        theSoal = scriptManager.GetComponent<TheSoal>();

        objBenar.SetActive(false);
        objSalah.SetActive(false);

        objMeshRender = obj.GetComponent<MeshRenderer>();
        objCollider = obj.GetComponent<Collider>();
    }

    private void OnMouseDown()
    {
        //Debug.Log("Mouse ke Klik");
        if (theSoal.isSoalShow == false)
        {
            //Debug.Log("kepanggi0");
            theSoal.panelBgSoal.SetActive(true);
            theSoal.AcakAndInstantiate(0, soalA, soalB, soalC);
            objMeshRender.enabled = false;
            objCollider.enabled = false;
        }

    }

    public void showObjBenar ()
    {
        //Debug.Log("showObjBenar");
        objBenar.SetActive(true);
        objSalah.SetActive(false);
        theSoal.isSoalShow = false;
        Destroy(this.gameObject);
    }

    public void showObjSalah()
    {
        //Debug.Log("showObjSalah");
        objBenar.SetActive(false);
        objSalah.SetActive(true);
        theSoal.isSoalShow = false;
        Destroy(this.gameObject);
    }

    //private void OnMouseDown()
    //{
    //    Debug.Log("onmousedown");
    //    if (!TheSoal._instance.isMunsulSoal && !wasShow)
    //    {
    //        TheSoal._instance.showSoal(awal, akhir);
    //        wasShow = true;
    //    }

    //}

}
