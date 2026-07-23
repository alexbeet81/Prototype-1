using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -16);

    public bool roateWithPlayer = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (roateWithPlayer)
        {
            transform.position = player.transform.position + (player.transform.rotation * offset);
            transform.rotation = player.transform.rotation;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
