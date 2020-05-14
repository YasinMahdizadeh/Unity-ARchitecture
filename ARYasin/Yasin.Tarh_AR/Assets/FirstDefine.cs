using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDefine : MonoBehaviour
{
    // Start is called before the first frame update
    public int c = 0;
    public GameObject L0;
    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public GameObject L4;
    void Start()
    {
        L1 = GameObject.Find("ImageTarget/Block1_24.2104/Floor1");
        L2 = GameObject.Find("ImageTarget/Block1_24.2104/Floor2");
        L3 = GameObject.Find("ImageTarget/Block1_24.2104/Floor3");
        L4 = GameObject.Find("ImageTarget/Block1_24.2104/Floor4");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level_Up()
    {
        c = c + 1;
        c = c % 5;
        Debug.Log(c);
        Show_Level(c);
    }

    public void Level_Down()
    {
        c--;
        c = c % 5;
        if (c == -1)
            c = 4;
        Debug.Log(c);
        Show_Level(c);
    }

    public void Show_Level( int i)
    {
        switch (i)
        {
            case 0:
                {
                    //L0.SetActive(true);
                    L1.SetActive(false);
                    L2.SetActive(false);
                    L3.SetActive(false);
                    L4.SetActive(false);
                    break;
                }

            case 1:
                {
                    //L0.SetActive(true);
                    L1.SetActive(true);
                    L2.SetActive(false);
                    L3.SetActive(false);
                    L4.SetActive(false);
                    break;
                }

            case 2:
                {
                    //L0.SetActive(true);
                    L1.SetActive(true);
                    L2.SetActive(true);
                    L3.SetActive(false);
                    L4.SetActive(false);
                    break;
                }

            case 3:
                {
                    //L0.SetActive(true);
                    L1.SetActive(true);
                    L2.SetActive(true);
                    L3.SetActive(true);
                    L4.SetActive(false);
                    break;
                }

            case 4:
                {
                    //L0.SetActive(true);
                    L1.SetActive(true);
                    L2.SetActive(true);
                    L3.SetActive(true);
                    L4.SetActive(true);
                    break;
                }
        }
    }
}

