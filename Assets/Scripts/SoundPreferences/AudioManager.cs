using UnityEngine;
using System;

namespace SoundPreferences
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;
        
        public Sound[] MusicSounds, SfxSounds;
        public AudioSource MusicSource, SfxSource;

        private void PlayMusic(string name)
        {
            Sound s = Array.Find(MusicSounds, x => x.name == name);
            MusicSource.clip = s.clip;
            MusicSource.Play();
        }
        
        public void PlaySfx(string name)
        {
            Sound s = Array.Find(SfxSounds, x => x.name == name);
            SfxSource.PlayOneShot(s.clip);
        }
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            PlayMusic("Theme");
        }

        public void MusicVolume(float volume)
        {
            MusicSource.volume = volume;
        }
        
        public void SfxVolume(float volume)
        {
            SfxSource.volume = volume;
        }
    }
}
