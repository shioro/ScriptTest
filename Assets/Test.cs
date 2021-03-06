using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic
{
    public int mp = 53;

    public void Attack()
    {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = {10, 120, 80, 40, 5};
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }
        
        Magic magic = new Magic();
        while(magic.mp > 0)
        {
            magic.Attack();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
