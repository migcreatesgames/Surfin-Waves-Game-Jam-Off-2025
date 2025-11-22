using UnityEngine;

public class BeachBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(BaseString.Player))
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(BaseString.Player))
        {
            Destroy(gameObject);
        }
    }
}
