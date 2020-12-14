using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public GameObject pOriginal_Obj = null;

    private PoolingManager _pPool_Sphere = PoolingManager.instance;

    private List<GameObject> _listGameObject = new List<GameObject>();

    private void Start()
    {
        _pPool_Sphere.DoPrepare_Pool(pOriginal_Obj, 30);

        StartCoroutine(nameof(OnCoroutine_CreateSphere));
    }


    private IEnumerator OnCoroutine_CreateSphere()
    {
        while (true)
        {
            var pSphere =  _pPool_Sphere.DoPop();
            pSphere.transform.SetParent(transform);
            pSphere.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(0, -14));
            pSphere.transform.localScale = Vector3.one * Random.Range(0.7f, 2.2f);

            _listGameObject.Add(pSphere);

            yield return new WaitForSeconds(1f);
        }
    }
}
