using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 자식에 있는 오브젝트들을 미리 캐싱해뒀다가, 일정시간이 경과하면
/// 그 중에 하나를 랜덤으로 선택해서 복제하는 기능을 만든다
/// </summary>
public class ObjectManager : MonoBehaviour
{
    private List<Transform> _list_Original = new List<Transform>();

    //private WaitForSeconds _ws_Term = new WaitForSeconds(2f);

    private void Awake()
    {
        if (null == _list_Original)
            _list_Original = new List<Transform>();

        if (0 >= _list_Original.Count)
        {
            var arrTransform = GetComponentsInChildren<Transform>();

            for (int i = 0; i < arrTransform.Length; ++i)
            {
                _list_Original.Add(arrTransform[i]);
            }
            
            Debug.Log($"리스트에 있는 오리지널 트랜스폼 개수 : {_list_Original.Count}");
        }
    }

    //private void Start()
    //{
    //    StopAllCoroutines();

    //    StartCoroutine(nameof(OnCoroutine_Copy));
    //}

    //private IEnumerator OnCoroutine_Copy()
    //{
    //    while (true)
    //    {
    //        int iRandomIdx = Random.Range(0, _list_Original.Count);

    //        var newObj = Instantiate<Transform>(_list_Original[iRandomIdx]);
    //        newObj.position = new Vector3(Random.Range(-3, 3), Random.Range(-4, 4), Random.Range(-5, 5));
    //        newObj.SetParent(transform);

    //        yield return _ws_Term;
    //    }
    //}
}
