using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Root : MonoBehaviour
{
    public Text _pText_Count;

    public int _iCount = 0;

    private void Awake()
    {
        _iCount = 0;
    }

    private void Start()
    {
        CubeManager.OnAdd_Cube.Subscribe += OnAdd_Cube_Func;
    }

    public void DoPress_Button(int iPlusCount)
    {
        DebugLogManager.Log($"큐브 추가 메시지 발생! 추가할 큐브 개수 : {iPlusCount}");
        CubeManager.OnAdd_Cube.DoNotify(new CubeManager.AddCubeMessage(iPlusCount));
    }

    private void OnAdd_Cube_Func(CubeManager.AddCubeMessage pMessage)
    {
        if (null != _pText_Count)
        {
            _iCount += pMessage.iPlusCount;
            _pText_Count.text = $"{_iCount} 개";
        }
    }
}
