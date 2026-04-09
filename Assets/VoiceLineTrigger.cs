using UnityEngine;

public class VoiceLineTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public bool playOnce = true;
    private bool hasPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is the player
        if (other.CompareTag("Player"))
        {
            if (!hasPlayed)
            {
                audioSource.Play();
                if (playOnce) hasPlayed = true; // Prevents re-triggering
            }
        }
    }
}