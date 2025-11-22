using UnityEngine;
using UnityEngine.SceneManagement;
using SE = UnityEngine.SerializeField;

public class IntroStart : MonoBehaviour
{
    void Update()
    {
        EnterKey();
    }

    public void EnterKey()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("main");
        }
    }
    public void BtnPress()
    {
        SceneManager.LoadScene("main");
    }

}
