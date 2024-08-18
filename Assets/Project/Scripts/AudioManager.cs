using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
