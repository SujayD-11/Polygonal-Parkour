using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDieSound : MonoBehaviour
{
    [SerializeField] private AudioSource playerDie;
    // Start is called before the first frame update
    void Start()
    {
        playerDie.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
