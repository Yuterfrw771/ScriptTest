using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    private int mc = 1;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを与えた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数
    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log(this.mc + "回目の魔法攻撃をした。残りMPは" + this.mp);
            this.mc += 1;
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

        int[] array = new int[5];
        int sum = 10;

        //順番
        for(int i = 0; i < 5; i++)
        {
            array[i] = sum;
            sum += 10;

            Debug.Log(array[i]);
        }

        Debug.Log("ここから逆順です");

        //逆順
        for(int j = 4; j > -1; j--)
        {
            Debug.Log(array[j]);
        }

        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        Debug.Log("ここから魔法攻撃");
        for(int k = 0; k < 11; k++)
        {
            lastboss.Magic();
        }
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

