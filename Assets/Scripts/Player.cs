using UnityEngine;


namespace Labirint2
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed = 3.0f;
        private Rigidbody _rigidbody;

        public Player(float speed)
        {
            _speed = speed;
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float MoveHorizontal = Input.GetAxis("Horizontal");
            float MoveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);

            _rigidbody.AddForce(movement * _speed);
        }
    }

}