using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TheChangeScene : MonoBehaviour
{


    public void GantiScene (string namaScene)
    {
        GameObject nameScoreWaktu = GameObject.Find("NameScoreWaktu");
        if (nameScoreWaktu != null && namaScene == "0Menu")
        {
            Destroy(nameScoreWaktu);
            
        }
        SceneManager.LoadScene(namaScene);
    }

    public void appQuit()
    {
        Application.Quit();
    }

}
