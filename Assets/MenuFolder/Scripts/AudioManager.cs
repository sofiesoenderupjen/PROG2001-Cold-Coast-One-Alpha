using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source-----")]
    [SerializeField] AudioSource musicSource;
    
    [Header("-----Audio Clip-----")]
    public AudioClip background;
    public List<string> scenesWithMusic;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        if (scenesWithMusic.Contains(SceneManager.GetActiveScene().name))
        {
            // If yes, play the music
            musicSource.clip = background;
            musicSource.Play();
        }
    }
    // Function to play music based on scene change
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the loaded scene is in the list of scenes where music should play
        if (!scenesWithMusic.Contains(scene.name))
        {
            // If yes, play the music
            musicSource.Stop();
        }
        
    }
}
