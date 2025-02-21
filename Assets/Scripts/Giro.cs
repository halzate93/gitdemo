using UnityEngine;

public class Giro : MonoBehaviour
{
    [SerializeField] private float degrees;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.up, degrees * Time.deltaTime);
    }
}
