using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoSingleton<CubeManager>
{

    public struct AddCubeMessage
    {
        public int iPlusCount;

        public AddCubeMessage(int iPlusCount)
        {
            this.iPlusCount = iPlusCount;
        }
    }

    public static Observer_Pattern<AddCubeMessage> OnAdd_Cube { get; private set; } = new Observer_Pattern<AddCubeMessage>();

    public GameObject cubePref;

    private void Awake()
    {
        if (null == _instance)
        {
            _instance = this;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        OnAdd_Cube.Subscribe += OnAdd_Cube_Func;
    }

    private void OnAdd_Cube_Func(AddCubeMessage pMessage)
    {
        for (int i = 0; i < pMessage.iPlusCount; ++i)
        {
            GameObject goCube = Instantiate(cubePref);
            goCube.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 7), Random.Range(-7, 5));
        }
    
    }
}
