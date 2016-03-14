using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed = 10;

        public Text ScoreText;
        public Text WinText;
        public static string PickUpTag = "Pick Up";

        private Rigidbody _rigidbody;
        private int _pickUpCount;

        public void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();

            _pickUpCount = 0;

            UpdateScoreText();
            UpdateWinText("");
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
            if (!other.gameObject.CompareTag(PickUpTag)) return;

            other.gameObject.SetActive(false);

            _pickUpCount++;

            UpdateScoreText();
        }

        private void UpdateScoreText()
        {
            ScoreText.text = "Score: " + _pickUpCount;

            if(_pickUpCount > 22) UpdateWinText("You win!");
        }

        private void UpdateWinText(string message)
        {
            WinText.text = message;
        }
    }
}