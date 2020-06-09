using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerReference : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;

    private void Start()
    {
        audioMixer.SetFloat("test_float", 1.0f);
    }
}
