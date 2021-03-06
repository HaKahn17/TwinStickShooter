﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private float masterVolume;
    private float musicVolume;
    private float effectsVolume;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        var volumes = gm.GetVolumes();
        masterVolume = volumes.x;
        musicVolume = volumes.y;
        effectsVolume = volumes.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterVolume(float val)
    {
        gm.SetMasterVolume(val);
        masterVolume = val;
    }

    public void SetEffectsVolume(float val)
    {
        gm.SetEffectsVolume(val);
        effectsVolume = val;
    }

    public void SetMusicLevel(float val)
    {
        gm.SetMusicLevel(val);
        musicVolume = val;
    }

    public void GoToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public Vector3 GetVolumes()
    {
        return new Vector3(masterVolume, musicVolume, effectsVolume);
    }
}

