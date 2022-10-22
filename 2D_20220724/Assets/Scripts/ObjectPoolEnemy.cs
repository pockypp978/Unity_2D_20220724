using UnityEngine;

namespace LP
{
    /// <summary>
    /// ¼Ä¤Hª«¥ó¦À
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
