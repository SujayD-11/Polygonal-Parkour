using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWinSound : MonoBehaviour
{
    [SerializeField] private AudioSource playerWin;
    // Start is called before the first frame update
    void Start()
    {
        playerWin.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
