using System;
using SoundPreferences;
using UnityEngine;
using UnityEngine.UI;

namespace UserInterface
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private Slider _musicSlider, _sfxSlider;
        
        private const string MusicVolumeKey = "MusicVolume";
        private const string SfxVolumeKey = "SfxVolume";
        private const string FirstTimeKey = "FirstTime";

        public void Start()
        {
            LoadSoundsPreferences();
            _musicSlider.onValueChanged.AddListener(MusicVolume);
            _sfxSlider.onValueChanged.AddListener(SfxVolume);
        }
        
        private void LoadSoundsPreferences()
        {
            if (!PlayerPrefs.HasKey(FirstTimeKey))
            {
                PlayerPrefs.SetFloat(MusicVolumeKey, 1f);
                PlayerPrefs.SetFloat(SfxVolumeKey, 1f);
                PlayerPrefs.SetInt(FirstTimeKey, 1);
            }

            _musicSlider.value = PlayerPrefs.GetFloat(MusicVolumeKey);
            _sfxSlider.value = PlayerPrefs.GetFloat(SfxVolumeKey);
        }
        
        private void MusicVolume(float musicVolume)
        {
            AudioManager.Instance.MusicVolume(musicVolume);
            PlayerPrefs.SetFloat(MusicVolumeKey, musicVolume);
        }
        
        private void SfxVolume(float sfxVolume)
        {
            AudioManager.Instance.SfxVolume(sfxVolume);
            PlayerPrefs.SetFloat(SfxVolumeKey, sfxVolume);
        }
    }
}