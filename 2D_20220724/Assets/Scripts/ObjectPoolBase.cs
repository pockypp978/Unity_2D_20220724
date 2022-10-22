using UnityEngine;
using UnityEngine.Pool;

namespace LP
{
    /// <summary>
    /// �������
    /// </summary>
    public class ObjectPoolBase : MonoBehaviour
    {
        #region ���
        [SerializeField,Header("����")]
        private GameObject goTarget;
        [SerializeField,Header("������̤j�ƶq"), Range(0, 100)]
        private int countMax = 10;

        private int index;
        private ObjectPool<GameObject> objectPool;
        #endregion
        #region ��k
        /// <summary>
        /// �إߪ����������
        /// </summary>
        private GameObject CreatObject()
        {
            GameObject tempObject = Instantiate(goTarget);
            index++;
            tempObject.name = goTarget.name + index;
            return null;
        }
        /// <summary>
        /// �򪫥�����F���
        /// </summary>
        /// <param name="objectInpool"></param>
        private void GetObject(GameObject objectInpool)
        {
            objectInpool.SetActive(true);
        }
        /// <summary>
        /// �⪫���ٵ��������
        /// </summary>
        /// <param name="objectInPool"></param>
        private void ReleaseObjecct(GameObject objectInPool)
        {
            objectInPool.SetActive(false);
        }
        /// <summary>
        /// ��ƶq�W�X������̤j�Ȯ�
        /// </summary>
        /// <param name="objectInPool"></param>
        private void DestoryObject(GameObject objectInPool)
        {
            Destroy(objectInPool);
        }
        private void Test()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GetPoolObject();
            }
        }
        #endregion
        #region �ƥ�

        private void Awake()
        {
            objectPool = new ObjectPool<GameObject>(CreatObject, GetObject, ReleaseObjecct,
                DestoryObject, maxSize: countMax);
        }
        private void Update()
        {
            Test();
        }
        #endregion
        #region ���}��k
        /// <summary>
        /// �򪫥��������
        /// </summary>
        /// <returns>�i�H�ϥΪ�����</returns>
        public GameObject GetPoolObject()
        {
            return objectPool.Get();
        }
        /// <summary>
        /// �٪F�赹�����
        /// </summary>
        /// <param name="objectToRelease"></param>
        public void ReleasePoolObject(GameObject objectToRelease)
        {
            objectPool.Release(objectToRelease);
        }
        #endregion
    }

}
