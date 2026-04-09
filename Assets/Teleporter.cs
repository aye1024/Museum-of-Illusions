using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform destination; // Drag your 'Empty GameObject' destination here in Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Update position and rotation
            other.transform.position = destination.position;
            other.transform.rotation = destination.rotation;

            // Forces physics to update immediately to prevent position snapping errors
            Physics.SyncTransforms(); 
        }
    }
}