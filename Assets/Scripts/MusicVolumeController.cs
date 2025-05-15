using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeController : MonoBehaviour
{
    public Slider volumeSlider;
    private AudioSource musicSource;

    void Start()
    {
        musicSource = FindObjectOfType<music>().GetComponent<AudioSource>();

        if (volumeSlider != null && musicSource != null)
        {
            volumeSlider.value = musicSource.volume;
            volumeSlider.onValueChanged.AddListener(ChangeVolume);
        }
    }

    public void ChangeVolume(float value)
    {
        if (musicSource != null)
        {
            musicSource.volume = value;
        }
    }
}
