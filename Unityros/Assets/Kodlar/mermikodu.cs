using UnityEngine;

public class mermikodu : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        if (collision.transform.tag == "Dusman")
        {
            Destroy(collision.gameObject);
        }
    }
}