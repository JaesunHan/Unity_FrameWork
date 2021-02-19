using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePoolTest : MonoBehaviour
{
    PoolingManager_Component<CubeObject> _pCubeObjectPool = new PoolingManager_Component<CubeObject>();
    public CubeObject _pOriginal_CubeObj = null;
    // Start is called before the first frame update
    void Start()
    {
        _pCubeObjectPool.DoInit_Pool(_pOriginal_CubeObj);

        StartCoroutine(nameof(OnCoroutine_CreateCUbe));
    }

    private IEnumerator OnCoroutine_CreateCUbe()
    {
        while (true)
        {
            var pNewObj = _pCubeObjectPool.DoPop();

            pNewObj.transform.SetParent(transform);
            pNewObj.transform.localPosition = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));

            yield return new WaitForSeconds(2f);
        }
    }
}
