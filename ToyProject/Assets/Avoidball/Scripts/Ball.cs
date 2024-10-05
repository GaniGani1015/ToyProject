using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Ball : MonoBehaviour
    {

        public float size;

        public enum color { RED, Black, Blue }

        public float speed;


        private void OnCollisionEnter(Collision collision) // �浹���� ��
        {
            
            if (collision.collider.CompareTag("Player"))
            {
                collision.gameObject.SetActive(false);
            }

            if (collision.collider.CompareTag("NonDisable"))
            {
                Destroy(gameObject);
            }

            
        }

        private void OnCollisionExit(Collision collision) // �浹�� ������ ��
        {

        }

        private void OnCollisionStay(Collision collision) // �浹���� ��

        {

        }
    }
}
