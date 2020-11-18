using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//==================================================
//Bossクラス
//==================================================
public class Boss
{
  private int hp = 100;       //体力
  private int power = 25;     //攻撃力
  private int mp = 53;        //MP

  //攻撃用の関数
  public void Attack()
  {
    Debug.Log(this.power + "のダメージを与えた");
  }

  //防御用の関数
  public void Degence(int damage)
  {
    Debug.Log(damage + "のダメージを受けた");
    //残りHPを減らす
    this.hp -= damage;
  }

  //魔法攻撃の関数
  public void Magic()
  {
    //mpが残り5以上の時
    if (mp >= 5)
    {
      mp -= 5;
      Debug.Log("魔法攻撃をした。残りMPは" + mp);
    }
    //mpが残り5未満の時
    else
    {
      Debug.Log("MPが足りないため魔法が使えない。");
    }
  }
}

//==================================================
//Testクラス
//==================================================
public class Test : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    //------------------------------------------------
    //配列課題
    //------------------------------------------------
    //配列の宣言
    int[] tmpArray = { 1, 3, 5, 7, 9 };

    //配列の各要素の値を順番に表示
    for (int i = 0; i < tmpArray.Length; i++)
    {
      Debug.Log(tmpArray[i]);
    }

    //配列の各要素の値を逆順に表示
    for (int i = tmpArray.Length - 1; i >= 0; i--)
    {
      Debug.Log(tmpArray[i]);
    }

    //------------------------------------------------
    //クラス課題
    //------------------------------------------------
    //Bossクラスの変数を宣言してインスタンスを代入
    Boss lastBoss = new Boss();

    //攻撃用の関数を呼び出す
    lastBoss.Attack();

    //防御用の関数を呼び出す
    lastBoss.Degence(3);

    //魔法攻撃関数を呼び出す
    for (int n = 0; n <= 10; n++)
    {
      lastBoss.Magic();
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}



