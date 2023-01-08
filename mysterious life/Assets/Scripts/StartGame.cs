using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private AudioSource ButtonSoundEffect;

    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ButtonSoundEffect.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
        ButtonSoundEffect.Play();
    }
}