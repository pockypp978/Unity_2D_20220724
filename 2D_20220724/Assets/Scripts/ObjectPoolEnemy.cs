using UnityEngine;

namespace LP
{
    /// <summary>
    /// �ĤH�����
    /// </summary>
    public class ObjectPoolEnemy : ObjectPoolBase
    {
        public static ObjectPoolEnemy instance;
        private void Start()
        {
            instance = this;
        }
    }

}
