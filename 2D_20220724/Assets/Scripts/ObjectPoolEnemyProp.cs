using LP;
using UnityEngine;
namespace LP
{
    /// <summary>
    /// �ĤH�����D��
    /// </summary>
    public class ObjectPoolEnemyProp : ObjectPoolBase
    {
        /// <summary>
        /// �R�A�������
        /// </summary>
        public static ObjectPoolEnemyProp instance;

        private void Start()
        {
            //���w�������O
            instance = this;
        }
    }

}
