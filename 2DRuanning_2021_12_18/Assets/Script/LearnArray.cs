using TMPro;
using UnityEngine;


/// <summary>
/// �ǲ߰}�C
/// </summary>
public class LearnArray : MonoBehaviour
{

    //�}�C�y�k
    //�������[]
    //�x�s�h���ۦP���������



    //���y�k
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;

    //�}�C�y�k
    public int[] atk;

    //���w��l��
    //�u���w�C�}��Ƽƶq�����w��
    public float[] speeds = new float[5];

    //�u���w�C�}��ƭ�{}
    public bool[] complete = { true, false, true };
    public string[] props = { "�^����", "�^�]��" };
    public Vector3[] position = { new Vector3(0, 2, 1), new Vector3(0, 0, 0) };
    

    private void Start()
    {
        //1.�s���C�}���
        //�W��[�s��]=��;
        //�����O�Ĥ@�ӧ�70
        atk[0] = 70;

        //�s�����i�W�X�d��
        //atk[3]=70;    (�|�X�{���~)
        //IndexOutOfRange--=�W�X�d��


        //2.���o�}�C���
        print("�ĤG���D����" + props[1]);
        print("�Ĥ@���y�и��" + position[0]);

        //3.���o�C�}��ƼƶqLenght
        print("���L�ȸ�Ƽƶq" + complete.Length);




    }

 


}
