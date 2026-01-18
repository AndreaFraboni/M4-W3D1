using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    AudioManager _audioManager;

    private void Awake()
    {
        if (_audioManager == null) _audioManager = FindAnyObjectByType<AudioManager>();
    }

    private void Start()
    {
        _audioManager.PlayMusic("ThemeMenu");
    }

    public void PlayClickSound()
    {
        _audioManager.PlaySFX("MouseClickSound");
    }

    public void StartGame()
    {
        _audioManager.StopAllAudioSource();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SaveOptions()
    {
        Debug.Log("le opzioni sono state salvate !!!");
    }

    public void QuitGame()
    {
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
		     Application.Quit();
#endif
        }

    }





}
