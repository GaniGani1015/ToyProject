using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityLearn
{
    public class Flag : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("���� �̸��� ����Դϴ�. ���������� ���� ����� �����մϴ�.");

            transform.Rotate(new Vector3(0, 0, 0));
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}