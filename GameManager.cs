using System.Runtime.InteropServices;
using UnityEngine;
using SE = UnityEngine.SerializeField;
using System;

public class GameManager : MonoBehaviour
{
    //[SE] private UIManager ui;
    [SE] private Rigidbody PlayerRb;
    [SE] private Animator PlayerAnimator;
    public static event Action OnGameOver;
    public void GameOver()
    {
        Debug.Log("Game Over!");
        OnGameOver?.Invoke();
        //ui.EnableGameOver();
        PlayerRb.linearVelocity = new Vector3(0f, 0f, 0f);
        PlayerAnimator.Play("PlayerDead");
        AudioManager.SoundClick("dead");
        Player.gameover = true;
    }
}
