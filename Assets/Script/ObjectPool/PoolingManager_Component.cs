﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager_Component<CLASS_POOL_TARGER> : MonoSingleton<PoolingManager_Component<CLASS_POOL_TARGER>> 
    where CLASS_POOL_TARGER : Component
{
    const int const_iPool_Default_Count = 30;

    private Queue<GameObject> _qPool = new Queue<GameObject>();

    private GameObject _objRoot = null;

    public void DoInit_Pool(CLASS_POOL_TARGER pOriginalObjectTarget)
    {
        _objRoot = new GameObject();
        
        Prepare_Objec_Pool(pOriginalObjectTarget);

        _objRoot.name = $"{pOriginalObjectTarget.name} 풀 생성";
    }

    public Component DoPop()
    {
        var pDequeueObj = _qPool.Dequeue();
        pDequeueObj.hideFlags = HideFlags.None;
        

        return pDequeueObj.GetComponent<CLASS_POOL_TARGER>();
    }

    public void DoPush(Component pObject)
    {
        _qPool.Enqueue(pObject.gameObject);
        pObject.hideFlags = HideFlags.HideInHierarchy;
        pObject.transform.SetParent(_objRoot.transform);
    }

    /// <summary>
    /// 오브젝트 풀 준비
    /// </summary>
    private void Prepare_Objec_Pool(CLASS_POOL_TARGER pObjectOriginal)
    {
        for (int i = 0; i < const_iPool_Default_Count; ++i)
        {
            var pObj = Instantiate(pObjectOriginal.gameObject);
            pObj.hideFlags = HideFlags.HideInHierarchy;
            pObj.transform.SetParent(_objRoot.transform);

            _qPool.Enqueue(pObj);
        }
    }
}
