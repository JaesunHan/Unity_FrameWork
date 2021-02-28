using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 버튼을 눌렀을 때 이벤틀를 보내는 클래스 
/// </summary>
public static class ButtonHelper_Re
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pUIElementOwner"></param>
    public static void DoInit_HasUIElement(MonoBehaviour pUIElementOwner)
    {
        if (null == pUIElementOwner)
        {
            Debug.LogError("Error - pUIElementOwner == null");
            return;
        }

        System.Type[] arrInterfaceType = pUIElementOwner.GetType().GetInterfaces();
        if (null == arrInterfaceType || 0 == arrInterfaceType.Length)
            return;

        Init_HasButton(pUIElementOwner, arrInterfaceType);
    }

    private static void Init_HasButton(MonoBehaviour pOwner, System.Type[] arrInterfacesType)
    { 
        
    }
}
