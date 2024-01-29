using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMaterial : MonoBehaviour
{
    public Material Golden, Purple, Blue, White; // 定义四个材质变量，可以在检视面板中拖拽赋值
    private MeshRenderer meshRenderer; // 定义一个MeshRenderer变量
    private float switchInterval; // 定义一个切换间隔的变量
    private float timer; // 定义一个计时器的变量
    private bool isSwitching; // 定义一个切换状态的变量

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); // 获取物体的MeshRenderer组件
        switchInterval = 0.05f; // 初始化切换间隔为0.1秒，即每秒切换10次
        timer = 0f; // 初始化计时器为0
        isSwitching = false; // 初始化切换状态为false
    }

    void Update()
    {
        if (isSwitching)
        {
            timer += Time.deltaTime; // 累加计时器
            if (timer >= switchInterval) // 如果计时器大于等于切换间隔
            {
                // 使用一个随机数来选择一个颜色，按照您给定的概率
                float random = Random.value; // 生成一个0到1之间的随机数
                if (random < 0.025f) // 如果随机数小于0.025
                {
                    meshRenderer.material = Golden; // 更换物体的材质为Golden
                }
                else if (random < 0.15f) // 如果随机数小于0.15
                {
                    meshRenderer.material = Purple; // 更换物体的材质为Purple
                }
                else if (random < 0.4f) // 如果随机数小于0.3
                {
                    meshRenderer.material = Blue; // 更换物体的材质为Blue
                }
                else // 其他情况下
                {
                    meshRenderer.material = White; // 更换物体的材质为White
                }
                timer = 0f; // 重置计时器
            }
        }
 
    }

    void OnMouseDown()
    {
        isSwitching = !isSwitching; // 切换切换状态的值
    }
}


