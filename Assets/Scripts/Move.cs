using UnityEngine;

public class Move : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
