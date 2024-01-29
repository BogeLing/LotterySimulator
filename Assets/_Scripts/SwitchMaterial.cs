using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMaterial : MonoBehaviour
{
    public Material Golden, Purple, Blue, White; // �����ĸ����ʱ����������ڼ����������ק��ֵ
    private MeshRenderer meshRenderer; // ����һ��MeshRenderer����
    private float switchInterval; // ����һ���л�����ı���
    private float timer; // ����һ����ʱ���ı���
    private bool isSwitching; // ����һ���л�״̬�ı���

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); // ��ȡ�����MeshRenderer���
        switchInterval = 0.05f; // ��ʼ���л����Ϊ0.1�룬��ÿ���л�10��
        timer = 0f; // ��ʼ����ʱ��Ϊ0
        isSwitching = false; // ��ʼ���л�״̬Ϊfalse
    }

    void Update()
    {
        if (isSwitching)
        {
            timer += Time.deltaTime; // �ۼӼ�ʱ��
            if (timer >= switchInterval) // �����ʱ�����ڵ����л����
            {
                // ʹ��һ���������ѡ��һ����ɫ�������������ĸ���
                float random = Random.value; // ����һ��0��1֮��������
                if (random < 0.025f) // ��������С��0.025
                {
                    meshRenderer.material = Golden; // ��������Ĳ���ΪGolden
                }
                else if (random < 0.15f) // ��������С��0.15
                {
                    meshRenderer.material = Purple; // ��������Ĳ���ΪPurple
                }
                else if (random < 0.4f) // ��������С��0.3
                {
                    meshRenderer.material = Blue; // ��������Ĳ���ΪBlue
                }
                else // ���������
                {
                    meshRenderer.material = White; // ��������Ĳ���ΪWhite
                }
                timer = 0f; // ���ü�ʱ��
            }
        }
 
    }

    void OnMouseDown()
    {
        isSwitching = !isSwitching; // �л��л�״̬��ֵ
    }
}


