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
            Debug.Log("저의 이름은 깃발입니다. 도착지점에 대한 기능을 구현합니다.");

            transform.Rotate(new Vector3(0, 0, 0));
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}