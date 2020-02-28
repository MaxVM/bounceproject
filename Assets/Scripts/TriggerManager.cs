using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.Audio.AudioMixerGroup _audioMixer;
    [SerializeField]
    private AudioClip _audioClip;
    [SerializeField]
    private UnityEngine.Audio.AudioMixerGroup nul;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<AudioSource>())
        {
            other.GetComponent<AudioSource>().outputAudioMixerGroup = _audioMixer;
            other.GetComponent<AudioSource>().clip = _audioClip;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<AudioSource>())
        {
            other.GetComponent<AudioSource>().outputAudioMixerGroup = nul;
        }
    }
}
