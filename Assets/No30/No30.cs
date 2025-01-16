using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace NS30
{
    public class No30 : MonoBehaviour
    {
        public Rigidbody2D no30;
        Camera MC;
        public SpriteRenderer S;
        void Start()
        {
            MC = Camera.main;
            no30 = GetComponent<Rigidbody2D>();

            no30.velocity = new Vector2(2f, -2f);
        }

        void Update()
        {
            Vector2 sB = MC.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
            Vector2 tion = transform.position;

            if (tion.x < -sB.x || tion.x > sB.x)
            {
                no30.velocity = new Vector2(-no30.velocity.x, no30.velocity.y);
                tion.x = Mathf.Clamp(tion.x, -sB.x, sB.x);
                ChangeColor();
            }

            if (tion.y < -sB.y || tion.y > sB.y)
            {
                no30.velocity = new Vector2(no30.velocity.x, -no30.velocity.y);
                tion.y = Mathf.Clamp(tion.y, -sB.y, sB.y);
                ChangeColor();
            }

            transform.position = tion;
        }
        void ChangeColor()
        {
            if (S != null)
            {
                S.color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }
}