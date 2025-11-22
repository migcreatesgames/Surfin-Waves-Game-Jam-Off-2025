using UnityEngine;
using SE = UnityEngine.SerializeField;
public class Dolphin : MonoBehaviour
{
    public float bobOffset = 0;
    public float bobSpeed = 2;
    public float amplitude = 0.5f;

    private float angle = 0;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        angle = bobOffset;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        angle += bobSpeed * Time.deltaTime;
        Vector3 newPosition = startPosition;
        newPosition.y += Mathf.Sin(angle) * amplitude;
        transform.position = newPosition;
    }
}
