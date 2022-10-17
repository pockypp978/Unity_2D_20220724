using UnityEngine;

public class LearnDelegateReceive : MonoBehaviour
{
    public void ReceiveData(int getNumberData)
    {
        getNumberData++;
        print("接收到的資料+1:" + getNumberData);
    }

    //2. 定義委派：簽章方法必須一樣
    //範例：無傳回無參數
    public delegate void delegateOne();
    public delegate void delegateTwo(int number);
    //3. 使用委派
    //3-1. 參數定義
    public void ReceiveMethod(delegateOne one)
    {
        //3-3. 使用委派
        one();
    }
    public void ReceiveMethodTwo(delegateTwo two)
    {
        int weaponA = 10;
        two(weaponA);
    }
    
}
