using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gound : MonoBehaviour
{
    public GameObject gound0;
    private Vector3 groundPostion1;
    private Vector3 groundPostion2;
    private Vector3 groundPostion3;
    private Vector3 groundPostion4;
    
    public bool A = false;
    private float yPosition = 2.5f;
    private float yGround = 0f;

    public GameObject block0;
    private Vector3 blockPostion1;
    private Vector3 blockPostion2;
    private float yBlock=0;
    private int blocknum=2;

    public GameObject dieLine;
    private Vector3 dieLinepos;

    public Text floor;
    private int floornum;

    // Start is called before the first frame update
    void Start()
    {
        A = false;
        dieLinepos.y=-5.8f;
        groundPostion3.y = 2.5f;
        groundPostion3.x = Random.Range(-1.8f, 1.8f);
        Instantiate(gound0, groundPostion3, Quaternion.identity);
        groundPostion4.y = 3.5f;
        groundPostion4.x = Random.Range(-1.8f, 1.8f);
        Instantiate(gound0, groundPostion4, Quaternion.identity);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        yPosition += 2.5f;
        transform.position = new Vector3(0, yPosition, 0);
        A = true;
        groundPostion1.y = 4.5f;
        groundPostion1.y += yGround;
        groundPostion1.x = Random.Range(-1.8f, 1.8f);
        Instantiate(gound0, groundPostion1, Quaternion.identity);
        groundPostion2.y = 5.5f;
        groundPostion2.y += yGround;
        groundPostion2.x = Random.Range(-1.8f, 1.8f);
        Instantiate(gound0, groundPostion2, Quaternion.identity);
        groundPostion1.y = 6.5f;
        groundPostion1.y += yGround;
        groundPostion1.x = Random.Range(-1.8f, 1.8f);
        Instantiate(gound0, groundPostion1, Quaternion.identity);
        
        yGround+=3;

        if (blocknum == 2)
        {
            blockPostion1.x = 2.55f;
            blockPostion1.y = 11.08f;
            blockPostion1.y += yBlock;
            Instantiate(block0, blockPostion1, Quaternion.identity);
            blockPostion2.x = -2.57f;
            blockPostion2.y = 11.08f;
            blockPostion2.y += yBlock;
            Instantiate(block0, blockPostion2, Quaternion.identity);
            blocknum = 0;
            yBlock+=7.67f;
        }
        blocknum++;

        dieLinepos.y += 2.5f;
        dieLine.transform.position = new Vector3(-2.28f,dieLinepos.y,0);
        floornum++;


    }



    // Update is called once per frame
    void Update()
    {
        floor.text = "最高" + floornum + "F";
    }
}
