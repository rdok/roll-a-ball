using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed = 10;
        private Rigidbody _rigidbody;
        public static string PickUpTag = "Pick Up";

        public void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");

            var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * Speed);
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(PickUpTag))
            {
                other.gameObject.SetActive(false);
            }
        }

    }
}