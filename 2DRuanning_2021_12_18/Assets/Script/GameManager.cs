using System;
using UnityEngine;
using UnityEngine.UI;




/// <summary>
/// 遊戲玩家管理器
/// </summary>

public class GameManager : MonoBehaviour
{
    [Header("血條")]
    public Image imghp;
    [Header("時間")]
    public Text texttime;
    [Header("分數")]
    public Text TextScore;
    [Header("玩家血量"), Range(0, 5000)]
    public float hp = 100;

    [Header("道具標籤")]
    private string TagPorp = "道具";
    [Header("吃到東西會補血道具名稱")]
    private string propEatToAddHp = "補血";
    [Header("吃到補血道具恢復血量"), Range(0f, 50f)]
    public float valeFatToAddHp = 10;



    [Header("陷阱標籤")]
    private string TagTrap = "陷阱";
    [Header("結束畫面")]
    public CanvasGroup groupFinal;
    [Header("結束畫面標題")]
    public Text TextFinalTitle;
    [Header("顯示結束畫面")]
    public float ShowFinalInterval = 0.1f;

    [Header("死亡畫面參數")]
    public string parameterDead = "觸發死亡";
    [Header("過關區域名稱")]
    public string namePass = "過關區域";





    private int Score;
    private float hpmax;
    private Animator ani;
    private Plaryer plaryer;

    private void Start()
    {
        hpmax = hp;
        ani = GetComponent<Animator>();
        plaryer= GetComponent<Plaryer>();
    }


    private void Update()
    {
        UpdateUI();
        UpdateHP();
    }





    /// <summary>
    /// 更新遊戲時間
    /// </summary>
    private void UpdateUI()
    {
        //print("遊戲時間" + Time.timeSinceLevelLoad);

        texttime.text = "時間" + Time.timeSinceLevelLoad.ToString("F0");


    }

    private void UpdateHP()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpmax);
        imghp.fillAmount = hp / hpmax;
        Lose();

    }


    private void ShowFinal()
    {
        groupFinal.alpha += 0.2f;
    }




    private void AddScoreAndUI(int add)
    {
        Score += add;
        TextScore.text = "分數" + Score;
    }

    private void DamgeAndUpdatUI(float damage)
    {
        hp -= damage;
        imghp.fillAmount = hp / hpmax;
    }


    private void ChangeHpAndUpdate(float    vale)
    {
        hp += vale;
        hp = Mathf.Clamp(hp, 0, hpmax);
        imghp.fillAmount = hp / hpmax;
        Lose();


    }



    private void Lose()
    {
        if (hp == 0   &&    groupFinal.alpha==0)
        {
            TextFinalTitle.text = "挑戰失敗";
            ani.SetTrigger(parameterDead);

            plaryer.enabled = false;

            groupFinal.interactable = true;



            InvokeRepeating("ShowFinal", 0, ShowFinalInterval);
        }
    }

    private void Win()
    {
        TextFinalTitle.text = "挑戰成功";
        groupFinal.interactable = true;



        InvokeRepeating("ShowFinal", 0, ShowFinalInterval);
    }







    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("碰到物件" + collision.name);

        if (collision.tag == TagPorp)
        {
            AddScoreAndUI(collision.GetComponent<Prop>().Score);
            if (collision.name.Contains("奇異果")) ChangeHpAndUpdate(10);
            Destroy(collision.gameObject);
        }
        if (collision.tag == TagTrap)

        {
            DamgeAndUpdatUI(collision.GetComponent<Trap>().damage);

        }


        if (collision.name== namePass)
        {
            Win();
        }

    }

  

}
