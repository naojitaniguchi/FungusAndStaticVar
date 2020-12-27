using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVar : MonoBehaviour
{
    public static int hp = 0;
    public static int mp = 0;
    public static bool pumpkin = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addHp()
    {
        hp++;

        Debug.Log(hp);
    }

    public void addMp()
    {
        mp++;
        Debug.Log(mp);
    }
}
