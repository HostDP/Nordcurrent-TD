using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseWindow : MonoBehaviour
{
    [SerializeField]
    GameObject hudVisual;

    public void Pause()
    {
        hudVisual.SetActive(false);
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        Time.timeScale = 1;
        hudVisual.SetActive(true);
    }
}
