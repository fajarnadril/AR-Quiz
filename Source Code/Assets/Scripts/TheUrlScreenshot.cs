using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TheUrlScreenshot : MonoBehaviour
{
    public string url, nameSS;


    public void OpenTheURL()
    {
        //print(GetAndroidExternalStoragePath() + "/" + nameSS + ".jpg");
        //ScreenCapture.CaptureScreenshot(GetAndroidExternalStoragePath() + "/" + nameSS + ".jpg");
        Application.OpenURL(url);
    }


}
