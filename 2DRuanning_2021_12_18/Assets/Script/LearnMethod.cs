using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //��k�y�k
    //�׹���  �^�Ǹ������  ��k�W��  (�Ѽ�){�{�����e�A���z���A�t��k}
    //void �L�Ǧ^�A����Ƥ��|�^�Ǹ��


    //�I�s��k �W��();
    private void Start()
    {
        Test();
        Test();
        ShootIce();
        Shootfire();
        //���X�ӰѼơA�N�n�[�X�Ӥ޼�
        //���w�]�ȥi�H���μg �򴫭Ȫ������n������
        //���h�ӰѼƥi�ϥΫ��W���覡 �ѼƦW��:��
        //�o�g�q�y �t��100 ���Ĵ����� �z��
        Shoot("�q�y", 100, effect: "�z��");
        Shoot("���y", 150, "������");
        Shoot("�B�y", 70);
        Shoot("���y", 200);
        int Water3 = BuyWater(3);
        print("�R�T��" + Water3);
        float test= BMI (60,1.6f);
        print("test BMI" + test);
        float me = BMI(60, 1.68f);
        print("me BMI" + test);
    }


    //�ۭq��k:���|�۰ʰ���
    //�|�۰ʰ��檺�s�ƥ�
    private void Test()
    {
        print("����");

    }

    private void Shootfire()
    {
        print("�o�g���y");
        print("�o�g�t��100");
        print("�o�g����");


    }
    private void ShootIce()
    {
        print("�o�g�B�y");
        print("�o�g�t��50");
        print("�o�g����");


    }
    //���@�P�X�R��k
    //�Ѽƻy�k:�Ѽ�1���� �Ѽ�1�W��,�Ѽ�2���� �Ѽ�2�W��
    //�w�]�Ȼy�k:�Ѽ����� �ѼƦW��= �w�]��
    private void Shoot(string type, int speed, string sound = "������", string effect = "�z��")
    {
        print("<color=Red>�o�g" + type + "</color>");
        print("<color=0000FF>�o�g�t��" + speed + "</color>");
        print("<color=yellow>�o�g����" + sound + "</color>");
        print("<color=yellow>�o�g�S��" + effect + "</color>");
    }
    //�@���Ĥ�100
    private int BuyWater(int count)
    {
        int price = count * 100;
        return price;
    }

    private float BMI(float weight, float height)
    {
        float result = weight / (height * height);
        return result;
     
    }

   
}
