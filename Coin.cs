using UnityEngine;
using SE = UnityEngine.SerializeField;
public class Coin : MonoBehaviour
{
    private UIManager ui;

    private void Awake()
    {
        ui = GameObject.FindFirstObjectByType<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(BaseString.Player))
        {
            ui.CoinPickup();
            Destroy(gameObject);
            AudioManager.SoundClick("coin");
        }
    }
}
