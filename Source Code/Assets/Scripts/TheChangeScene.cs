using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TheChangeScene : MonoBehaviour
{
    public void GantiScene (string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }

    public void appQuit()
    {
        Application.Quit();
    }

}
