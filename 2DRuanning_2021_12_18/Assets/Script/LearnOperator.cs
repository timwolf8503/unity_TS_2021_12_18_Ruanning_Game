using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float B = 5;
    public int C = 50;
    public int D = 10;
    private void Start()
    {

        #region �B��l:�ƾ�
        //�[ +
        print("�[�k :"+(a + B));
        print(a + B + B);
        //�� -
        print("��k :" + (a - B));
        //�� *
        print("���k :" + (a * B)); 
        print(B * B * B);
        //�� /
        print("���k :" + (a / B));
        //�l�� %
        print("�l�k :" + (a % B));
        #endregion
        #region �B��l:���
        //���G�����L��  true or false
        //�j�� >
        print("�j��" + (C > D));   //true
        print(a > B);
        //�p�� <
        print("�p��" + (C < D));  //false
        //�j�󵥩� >=
        print("�j�󵥩�" + (C >= D));  // true
        //�p�󵥩� <=
        print("�p�󵥩�" + (C <= D)); //false
        //���� ==
        print("����" + (C == D));   //false
        print(a == D);
        //������ !=
        print("������" + (C !> D));  //true

        #endregion
        #region �B��l:�޿�
        //���G�����L��  true or false
        // ���L�ȻP���L�Ȫ��B��
        // �åB && (shift+7(&))
        //�u�n�@�Ӧ�false���G�N�Ofalse
        print(true && true);       //true
        print(true && false);      //false
        print(false && true);     //false
        print(false && false);    //false
        // �Ϊ� || (shift+��)
        //�`�ڦ��@��true���G�N�Otrue
        print(true || true);    //true
        print(true || false);   //true
        print(false || true);   //true
        print(false || false);  //false
        //�A�� !
        //�N���L�Ȭۤ�
        print(!true);  //false
        print(!false); //true


        #endregion
    }

}
