using UnityEngine;
/// <summary>
/// ��V���b���a���]�ŹC���t��
/// </summary>
public class Plaryer : MonoBehaviour
{
    #region ���


    //�]�B�t�סA���D���סA�O�_�Ʀ�A�O�_���`
    //�ʵe�ѼƸ��D�A�Ʀ�P���`
    //Header����
    //Renge�d��,�u�i�H�μƭ�������Ʀp: float int

    [Header("�]�B�t��"),Range(0,500)]
    public float speed = 1.5f;
    [Header("���D����"),Range(0,5000)]
    public int jump = 500;
    [Header("�O�_�Ʀ�")]
    public bool isSlide;
    [Header("�O�_�Ʀ�")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterisSlide = "�}���Ʀ�";
    public string parameterisDead = "Ĳ�o���`";


    [Header("���D����")]
    public  KeyCode KeyJump= KeyCode.Space;

    [Header("���D�q�Ƴ̤j��"),Range(0, 5)]
    public int countjumpMax = 2;
    public int countjump;

    //�s��Transform�Ĥ@�ؤ覡
    //public Transform traPlayer;


    //�ݩʭ��O...Debug�Ҧ��i�H�ݨ�p�H���
    private Rigidbody2D rig;
    

    #endregion





    #region �ƥ�
    private void Start()
    {

        // GetComponent<��������>();        �Ҧ�����
        rig = GetComponent<Rigidbody2D>();
       
    }




    private void Update()
    {
        Run();
        Jump();
    }


    #endregion



    #region ��k
    /// <summary>
    /// �]�B
    /// </summary>
    private void Run()
    {


        //�s��Transform�Ĥ@�ؤ覡
        //Time.delatTime �@�V���ɶ�
        //traPlayer.Translate(speed*Time.deltaTime,0,0);         //���a�ܧ� �첾(X,Y,Z)


        //�s��Transform�ĤG�ؤ覡
        //transform.�W��;
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
       bool intJump= Input.GetKeyDown(KeyJump);
        //print("�O�_���D" + intJump);


        //�p�G���U����    �åB���D�q�Ƥj�� 0 ���W��
        if (intJump && countjump>0 )
        {
            // print("���D");
            //����K�[���O
            rig.AddForce(new Vector2(0, jump));
            countjump--;
        }
    }




    
    #endregion

}
