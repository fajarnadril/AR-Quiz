using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public Button buttonOn;
    public Button buttonOff;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GameObject.Find("NameScoreWaktu").GetComponent<AudioSource>();
        buttonOn.onClick.AddListener(TurnOnMusic);
        buttonOff.onClick.AddListener(TurnOffMusic);

        buttonOn.gameObject.SetActive(false);
    }

    private void TurnOnMusic()
    {
        audioSource.Play();
        buttonOn.gameObject.SetActive(false);
        buttonOff.gameObject.SetActive(true);
    }

    private void TurnOffMusic()
    {
        audioSource.Stop();
        buttonOff.gameObject.SetActive(false);
        buttonOn.gameObject.SetActive(true);
    }
}