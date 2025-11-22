using UnityEngine;
using SE = UnityEngine.SerializeField;

public class AudioManager : MonoBehaviour
{
    public static AudioClip coin;
    public static AudioClip ouch1;
    public static AudioClip ouch2;
    static AudioSource audioSrc;

    void Start()
    {
        coin = Resources.Load<AudioClip>("coin");
        ouch1 = Resources.Load<AudioClip>("ouch1");
        ouch2 = Resources.Load<AudioClip>("ouch2");
        audioSrc = GetComponent<AudioSource>();
    }
    public static void SoundClick(string clip)
    {
        if (clip == "coin")
        {
            audioSrc.PlayOneShot(coin);
        }
        if (clip == "ouch1")
        {
            audioSrc.PlayOneShot(ouch1);
        }
        if (clip == "ouch2")
        {
            audioSrc.PlayOneShot(ouch2);
        }
    }
}
