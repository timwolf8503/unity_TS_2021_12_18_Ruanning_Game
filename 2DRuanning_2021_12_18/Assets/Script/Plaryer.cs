using UnityEngine;
/// <summary>
/// ��V���b���a���]�ǹC���t��
/// </summary>
public class Plaryer : MonoBehaviour
{

    //�]�B�t�סA���D���סA�O�_�Ʀ�A�O�_���`
    //�ʵe�ѼƸ��D�A�Ʀ�P���`
    //Header����
    //Renge�d��,�u�i�H�μƭ�������Ʀp: float int

    [Header("�]�B�t��"),Range(0,500)]
    public float speed = 1.5f;
    [Header("���D����"),Range(0,5000)]
    public int Jump = 500;
    [Header("�O�_�Ʀ�")]
    public bool isSlide;
    [Header("�O�_�Ʀ�")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterisSlide = "�}���Ʀ�";
    public string parameterisDead = "Ĳ�o���`";


}
