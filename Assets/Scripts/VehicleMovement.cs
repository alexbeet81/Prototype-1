using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 10f;
    public string despawnerTag = "Despawner";
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(despawnerTag))
        {
            Destroy(gameObject);
        }
    }
}
