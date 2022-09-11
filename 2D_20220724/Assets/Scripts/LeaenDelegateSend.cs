using UnityEngine;

public class LeaenDelegateSend : MonoBehaviour
{
    private int number = 911;
    private LearnDelegateReceive receive;

    private void Awake()
    {
        receive = FindObjectOfType<LearnDelegateReceive>();
        receive.ReceiveData(number);
        //3. �ϥΩe��
        //3-2. �Ѽƶǻ�
        receive.ReceiveMethod(MethodOne);
        receive.ReceiveMethodTwo(MethodTwo);
    }
    //1. �w�q��k
    // �d�ҡG�L�Ǧ^�Ѽ�
    private void MethodOne()
    {
        print("�ڬO��k1");
    }

    public void MethodTwo(int attack)
    {
        attack *= 100;
        print("�Z���z���ˮ`" + attack);
    }

}
