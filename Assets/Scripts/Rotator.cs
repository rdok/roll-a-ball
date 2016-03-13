using UnityEngine;

namespace Assets.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public void Update()
        {
            var randomRotation = new Vector3(Random.Range(5.0F, 10.0F), Random.Range(15.0F, 30.0F),
                Random.Range(20.0F, 40.0F));

            transform.Rotate(randomRotation*Time.deltaTime);
        }
    }
}