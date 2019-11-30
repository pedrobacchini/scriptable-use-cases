using UnityEngine;

[CreateAssetMenu(menuName = "Audio Events/Play Audio")]
public class PlayAudioEvent : AudioEvent
{

    public AudioClip Clip;
    public override void Play(AudioSource source)
    {
        source.clip = Clip;
        source.Play();
    }
}