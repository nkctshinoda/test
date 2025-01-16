using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SSShooter
{
    public class E16 : EnemyMovementBase
    {
        [SerializeField] private float oscillationAmplitude = 20f;
        [SerializeField] private float oscillationFrequency = 2f;
        private Vector3 initialPosition;

        public override void Move()
        {
            Vector3 moveDire = direction;
            transform.position += moveDire * speed * Time.deltaTime;

            float oscillation = Mathf.Sin(Time.time * oscillationFrequency) * oscillationAmplitude;
            transform.position = new Vector3(transform.position.x, initialPosition.y + oscillation, transform.position.z);
        }
        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();
            initialPosition = transform.position;
            Initialize(1f,Vector2.left);
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }
    }
}
