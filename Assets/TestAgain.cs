using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;

    private int mp = 53;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた！");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた！");
        this.hp -= damage;
    }

    //L4発展課題
    //魔法攻撃の関数
    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}
public class TestAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastBoss = new Boss();
        lastBoss.Attack();
        lastBoss.Defence(3);

        //L4課題
        int[] array = { 10, 120, 80, 40, 5 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }

        //L4発展課題
        for(int i = 1; i < 12; i++)
        {
            Debug.Log(i + "回目の魔法攻撃！");
            lastBoss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
