using UnityEngine;

public class LeaenDelegateSend : MonoBehaviour
{
    private int number = 911;
    private LearnDelegateReceive receive;

    private void Awake()
    {
        receive = FindObjectOfType<LearnDelegateReceive>();
        receive.ReceiveData(number);
        //3. 使用委派
        //3-2. 參數傳遞
        receive.ReceiveMethod(MethodOne);
        receive.ReceiveMethodTwo(MethodTwo);
    }
    //1. 定義方法
    // 範例：無傳回參數
    private void MethodOne()
    {
        print("我是方法1");
    }

    public void MethodTwo(int attack)
    {
        attack *= 100;
        print("武器爆擊傷害" + attack);
    }

}
