using UnityEngine;

namespace Assets.Scripts
{
    public class CameraController : MonoBehaviour
    {
        public GameObject Player;
        private Vector3 _offest;

        public void Start ()
        {
            _offest = transform.position - Player.transform.position;
        }
	
        public void LateUpdate ()
        {
            transform.position = Player.transform.position + _offest;
        }
    }
}
