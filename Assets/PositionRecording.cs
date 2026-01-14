using UnityEngine;

public class PositionRecording : MonoBehaviour
{
    private void Update()
    {
        Vector3 worldPos = transform.position;

        Vector3 localPos = transform.localPosition;

        Debug.Log($"World Position: {worldPos}");

        Debug.Log($"Local Position: {localPos}");
    }
}
