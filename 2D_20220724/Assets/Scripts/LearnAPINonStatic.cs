using UnityEngine;

namespace LP
{
    public class LearnAPINonStatic : MonoBehaviour
    {
        public GameObject GOKnight;
        public Camera maincamera;
        public SphereCollider sphere;
        public Transform capsuleSize;
        public Transform cubeRotate, sphereRotate;
        public Rigidbody capsuleRig;
        private void Start()
        {
            print($"騎士圖層 {GOKnight.layer}");
            GOKnight.layer = 5;
            GOKnight.SetActive(false);
            print($"攝影機深度{maincamera.depth}");
            print($"碰撞半徑{sphere.radius}");
            maincamera.backgroundColor = Random.ColorHSV();
            capsuleSize.localScale = new Vector3(3, 2, 1);
        }
        private void Update()
        {
            cubeRotate.RotateAround(sphereRotate.position, sphereRotate.up, 3);
            capsuleRig.AddForce(0,2,0);
        }
    }
}
