using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    public void PlayMusic(string name)
    {
        foreach (Sound _sound in musicSounds)
        {
            if (_sound.name == name)
            {
                if (musicSource.isPlaying) musicSource.Stop();
                musicSource.clip = _sound.clip;
                musicSource.Play();
                return;
            }
        }
    }

    public void PlaySFX(string name)
    {
        foreach (Sound _sound in sfxSounds)
        {
            if (_sound.name == name)
            {
                if (sfxSource.isPlaying) sfxSource.Stop();
                sfxSource.PlayOneShot(_sound.clip);
                return;
            }
        }
    }

    public void StopAllAudioSource()
    {
        if (musicSource.isPlaying) musicSource.Stop();
        if (sfxSource.isPlaying) sfxSource.Stop();
    }

}
