using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    public float propellerSpeed = 1000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * propellerSpeed);
    }
}
