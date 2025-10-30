using UnityEngine;

public class CarpetInteraction : MonoBehaviour
{
    private bool isCleaned = false;

    public void InteractWithCarpet()
    {
        if (!isCleaned)
        {
            // 执行清洗地毯的逻辑
            CleanCarpet();
            // 设置地毯已被清洗的标志
            isCleaned = true;
        }
    }

    private void CleanCarpet()
    {
        // 清洗地毯的具体操作
        Debug.Log("Carpet cleaned successfully!");
    }
}
