using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 4.0f);
    }
}
