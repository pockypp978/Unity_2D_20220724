using UnityEngine;

public class LearnDelegateReceive : MonoBehaviour
{
    public void ReceiveData(int getNumberData)
    {
        getNumberData++;
        print("�����쪺���+1:" + getNumberData);
    }

    //2. �w�q�e���Gñ����k�����@��
    //�d�ҡG�L�Ǧ^�L�Ѽ�
    public delegate void delegateOne();
    public delegate void delegateTwo(int number);
    //3. �ϥΩe��
    //3-1. �ѼƩw�q
    public void ReceiveMethod(delegateOne one)
    {
        //3-3. �ϥΩe��
        one();
    }
    public void ReceiveMethodTwo(delegateTwo two)
    {
        int weaponA = 10;
        two(weaponA);
    }
    
}
