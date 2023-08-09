using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TheUrl : MonoBehaviour
{

    public void OpenTheURL(string url)
    {
        Application.OpenURL(url);
    }


}
