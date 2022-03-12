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

    [Header("陷阱標籤")]
    private string TagTrap = "陷阱";

    private int Score;
    private float hpmax;

    private void Start()
    {
        hpmax = hp;
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

        imghp.fillAmount = hp / hpmax;


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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("碰到物件" + collision.name);

        if (collision.tag == TagPorp)
        {
            AddScoreAndUI(collision.GetComponent<Prop>().Score);

            Destroy(collision.gameObject);
        }
        if (collision.tag == TagTrap)

        {
            DamgeAndUpdatUI(collision.GetComponent<Trap>().damage);

        }

    }

  

}
