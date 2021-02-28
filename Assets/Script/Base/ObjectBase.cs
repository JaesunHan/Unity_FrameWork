using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour
{
    public bool bIsAlready_Awake { get; private set; } = false;

    private void Awake()
    {
        if (bIsAlready_Awake)
            return;

        bIsAlready_Awake = true;

        OnAwake();
    }

    protected virtual void OnAwake()
    {
        if (false == Application.isPlaying)
            return;
    }

    /// <summary>
    /// 오브젝트의 active 를 설정합니다.
    /// </summary>
    /// <param name="bIsActive"></param>
    public virtual void SetActive(bool bIsActive)
    {
        gameObject.SetActive(bIsActive);
    }

    /// <summary>
    /// 오브젝트를 활성화 하려고 한다면 이 함수를 호출하세요
    /// </summary>
    public void DoAwake()
    {
        Awake();
    }
}
