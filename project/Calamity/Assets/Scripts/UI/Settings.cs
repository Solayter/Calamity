using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Settings : MonoBehaviour {


    public AudioMixerGroup sound;
    public AudioMixerGroup music;
    public Slider sliderSound;
    public Slider sliderMusic;
    public Toggle mute;
    public AudioListener player;

    public void Change()
    {
        sound.audioMixer.SetFloat("Sounds", sliderSound.value);
        music.audioMixer.SetFloat("Music", sliderMusic.value);
        player.enabled = !mute.isOn;
    }

}
