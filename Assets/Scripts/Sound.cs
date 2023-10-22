using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    public AudioSource die;
    private void Start()
    {
        die.Play();
    }
    
}
