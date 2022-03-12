using System;
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
    [Header("�Y��F��|�ɦ�D��W��")]
    private string propEatToAddHp = "�ɦ�";
    [Header("�Y��ɦ�D���_��q"), Range(0f, 50f)]
    public float valeFatToAddHp = 10;



    [Header("��������")]
    private string TagTrap = "����";
    [Header("�����e��")]
    public CanvasGroup groupFinal;
    [Header("�����e�����D")]
    public Text TextFinalTitle;
    [Header("��ܵ����e��")]
    public float ShowFinalInterval = 0.1f;

    [Header("���`�e���Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("�L���ϰ�W��")]
    public string namePass = "�L���ϰ�";





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
        TextScore.text = "����" + Score;
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
            TextFinalTitle.text = "�D�ԥ���";
            ani.SetTrigger(parameterDead);

            plaryer.enabled = false;

            groupFinal.interactable = true;



            InvokeRepeating("ShowFinal", 0, ShowFinalInterval);
        }
    }

    private void Win()
    {
        TextFinalTitle.text = "�D�Ԧ��\";
        groupFinal.interactable = true;



        InvokeRepeating("ShowFinal", 0, ShowFinalInterval);
    }







    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("�I�쪫��" + collision.name);

        if (collision.tag == TagPorp)
        {
            AddScoreAndUI(collision.GetComponent<Prop>().Score);
            if (collision.name.Contains("�_���G")) ChangeHpAndUpdate(10);
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
