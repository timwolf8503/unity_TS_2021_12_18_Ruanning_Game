using UnityEngine;
/// <summary>
/// �ǲ��ݩ�    Property
/// </summary>
public class LearnProprety : MonoBehaviour
#region �ݩ�

//�ݩʻy�k
//�׹���  ��ƺ��� �ݩʦW��{�s���l}
//�ֳt����  prop    +TAb*2
//get���o
//set�s��
{

    public int l1 { get; set; }
    public int test1 {get; set; }

    //�߿W�ݩʧ�set�R�� �L�k���w
    //�߿W�ݩʵ��P�Ȫ���k: {  get +   =>��;}

    public string passwordProprety { get => "123456789"; }
    public int password1{ get    =>8888; }
  

    //����ݩ�(��Ӧs��)
    public string passwordField;

    private void Start()
    {
        //�s���ݩ�set
    
        l1 = 100;
        test1 = 200;
        //���oget
        print("����" + l1);
        print("����"+test1);

        passwordField = "123456";
        print("���o���K�X" + passwordField);

        //passwordProprety="123456";
        print("���o�ݩʱK�X" + passwordProprety);
        print(password1);

#endregion

    }

}
