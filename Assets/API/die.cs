using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject end;
    public GameObject player;
    private AudioSource aud;
    // Start is called before the first frame update
    public AudioClip sounddie;
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        end.SetActive(true);
        Destroy(player, 1);
        aud.PlayOneShot(sounddie);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
