using UnityEngine;
using UnityEngine.Pool;

namespace LP
{
    /// <summary>
    /// 物件池基底
    /// </summary>
    public class ObjectPoolBase : MonoBehaviour
    {
        #region 資料
        [SerializeField,Header("物件")]
        private GameObject goTarget;
        [SerializeField,Header("物件池最大數量"), Range(0, 100)]
        private int countMax = 10;

        private int index;
        private ObjectPool<GameObject> objectPool;
        #endregion
        #region 方法
        /// <summary>
        /// 建立物件池的物件
        /// </summary>
        private GameObject CreatObject()
        {
            GameObject tempObject = Instantiate(goTarget);
            index++;
            tempObject.name = goTarget.name + index;
            return null;
        }
        /// <summary>
        /// 跟物件池拿東西時
        /// </summary>
        /// <param name="objectInpool"></param>
        private void GetObject(GameObject objectInpool)
        {
            objectInpool.SetActive(true);
        }
        /// <summary>
        /// 把物件還給物件池時
        /// </summary>
        /// <param name="objectInPool"></param>
        private void ReleaseObjecct(GameObject objectInPool)
        {
            objectInPool.SetActive(false);
        }
        /// <summary>
        /// 當數量超出物件池最大值時
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
        #region 事件

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
        #region 公開方法
        /// <summary>
        /// 跟物件池拿物件
        /// </summary>
        /// <returns>可以使用的物件</returns>
        public GameObject GetPoolObject()
        {
            return objectPool.Get();
        }
        /// <summary>
        /// 還東西給物件池
        /// </summary>
        /// <param name="objectToRelease"></param>
        public void ReleasePoolObject(GameObject objectToRelease)
        {
            objectPool.Release(objectToRelease);
        }
        #endregion
    }

}
