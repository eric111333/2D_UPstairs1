using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject end;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        end.SetActive(true);
        Destroy(player, 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
