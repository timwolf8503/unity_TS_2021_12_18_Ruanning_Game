using UnityEngine;



/// <summary>
/// �j��
/// 1.while *
/// 2.for   *
/// 3.do while
/// 4.foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    public int[] scores = new int [20];
    public float[] test = new float[10];


    private void Start()
    {


        //�j��P�C�}
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = 69+i;
        }

        for (int i = 0; i < test.Length; i++)
        {
            test[i] = 79.1f + i;
        }

        #region �j��while�Pfor

     
        //�B�z���Ʃʪ��{��

        //�@��y�k
        //������
        print("��");
        print("��");
        print("��");
        print("��");
        print("��");


        //while�y�k
        //�y�k�Pif�����ۦP
        //if(���L��){�{���ϰ�}
        //while(���L��){�{���ϰ�}

       
        //�����Ƥ@��
        if (true)
        {
            print("�P�_��");
        }

        //���������
        //�@������,�q���|��
        /*
        while (true)
        {
            print("�j��");
        }
        */

        //���wwhile����

        int count = 0;
        while (count<5)
        {
            print("��while");
            count++;
        }

        //for(��l��,���L��,�j�鵲������{��)

        for (int i = 0; i <5; i++)
        {
            print("��for");
        }

        //for��X�Ʀr1~100
        for (int i = 1; i < 101; i++)
        {
            print("��X�Ʀr"+i);
        }

        //��X�Ʀr100~200
        for (int d = 100; d < 201; d++)
        {
            print("��X�Ʀr" + d);
        }
#endregion




    }


}
