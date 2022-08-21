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
            print($"�M�h�ϼh {GOKnight.layer}");
            GOKnight.layer = 5;
            GOKnight.SetActive(false);
            print($"��v���`��{maincamera.depth}");
            print($"�I���b�|{sphere.radius}");
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
