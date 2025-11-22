using UnityEngine;
using SE = UnityEngine.SerializeField;

public class BufferFish : MonoBehaviour
{
    [SE] private float speed;
    [SE] private Transform endPos;
    private bool isActive;
    private void Update()
    {
        if(isActive)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos.position, speed * Time.deltaTime);
        }    
    }
    public void Activate()
    {
        isActive = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(BaseString.Player))
        {
            Destroy(gameObject);
        }
    }
}
