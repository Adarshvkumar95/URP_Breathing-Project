using UnityEngine;

public class AnimationAudioController : MonoBehaviour
{
    public Animator characterAnimator;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;
    public AudioClip audioClip5;


    private AudioSource audioSource;

    void Start()
    {
        // Ensure you have assigned the character's Animator component in the Unity Editor
        if (characterAnimator == null)
        {
            characterAnimator = GetComponent<Animator>();
        }

        // Add an AudioSource component to the GameObject if not already present
        audioSource = gameObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // Called by animation events
    public void PlayAudioClip1()
    {
        audioSource.clip = audioClip1;
        audioSource.Play();
    }

    public void PlayAudioClip2()
    {
        audioSource.clip = audioClip2;
        audioSource.Play();
    }

    public void PlayAudioClip3()
    {
        audioSource.clip = audioClip3;
        audioSource.Play();
    }

    public void PlayAudioClip4()
    {
        audioSource.clip = audioClip4;
        audioSource.Play();
    }

    public void PlayAudioClip5()
    {
        audioSource.clip = audioClip5;
        audioSource.Play();
    }


}
