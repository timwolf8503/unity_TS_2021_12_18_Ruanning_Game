using UnityEngine;
using UnityEngine.UI;




/// <summary>
/// �C�����a�޲z��
/// </summary>

public class GameManager : MonoBehaviour
{
    [Header("���")]
    public Image imghp;
    [Header("�ɶ�")]
    public Text texttime;
    [Header("����")]
    public Text TextScore;
    [Header("���a��q"), Range(0, 5000)]
    public float hp = 100;

    [Header("�D�����")]
    private string TagPorp = "�D��";

    [Header("��������")]
    private string TagTrap = "����";

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
    /// ��s�C���ɶ�
    /// </summary>
    private void UpdateUI()
    {
        //print("�C���ɶ�" + Time.timeSinceLevelLoad);

        texttime.text = "�ɶ�" + Time.timeSinceLevelLoad.ToString("F0");


    }

    private void UpdateHP()
    {
        hp -= Time.deltaTime;

        imghp.fillAmount = hp / hpmax;


    }




    private void AddScoreAndUI(int add)
    {
        Score += add;
        TextScore.text = "����" + Score;
    }

    private void DamgeAndUpdatUI(float damage)
    {
        hp -= damage;
        imghp.fillAmount = hp / hpmax;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("�I�쪫��" + collision.name);

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
