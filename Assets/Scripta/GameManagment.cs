using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagment : MonoBehaviour
{
    [SerializeField]
    private AudioSource nightcall;
    [SerializeField]
    private Button potlacenizvuku;
    [SerializeField]
    private Sprite muted;
    [SerializeField]
    private Sprite unmuted;
    [SerializeField]
    private GameObject win;
    [SerializeField]
    private GameObject loading;
    [SerializeField]
    private GameObject downloadbutton;
    [SerializeField]
    private GameObject playbutton;

    bool mute = false;

    void Start()
    {
        playbutton.SetActive(false);
        nightcall.Play();
        win.SetActive(false);
    }

    public void ChangeMute()
    {
        if (mute == true)
        {
            mute = false;
            nightcall.Play();
            potlacenizvuku.image.sprite = unmuted;
        }
        else
        {
            mute = true;
            nightcall.Pause();
            potlacenizvuku.image.sprite = muted;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void HideLoading()
    {
        loading.SetActive(false);
        playbutton.SetActive(true);
        downloadbutton.SetActive(false);
        win.SetActive(false);
    }

    public void ShowWin()
    {
        win.SetActive(true);
        downloadbutton.SetActive(true);
        playbutton.SetActive(false);
    }

    public void Hideplay()
    {
        playbutton.SetActive(false);
    }

    public void Showplay()
    {
        playbutton.SetActive(true);
    }
}
