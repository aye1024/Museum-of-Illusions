using UnityEngine;

public class DistanceScaler : MonoBehaviour
{
    public Transform player; // Assign the player in the inspector
    public float minDistance = 5f; // Distance where scaling starts
    public float maxDistance = 20f; // Distance where max size is reached
    public Vector3 minScale = new Vector3(1, 1, 1);
    public Vector3 maxScale = new Vector3(5, 1, 5);

    void Update()
    {
        if (player == null) return;

        // 1. Calculate distance
        float distance = Vector3.Distance(player.position, transform.position);

        // 2. Normalize distance to a 0-1 range based on thresholds
        float t = Mathf.Clamp01((distance - minDistance) / (maxDistance - minDistance));

        // 3. Lerp scale based on distance
        transform.localScale = Vector3.Lerp(minScale, maxScale, t);
    }
}