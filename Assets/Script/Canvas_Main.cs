using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Main : CanvasBase, IHas_UIButton<Canvas_Main.EButton>
{
    
    public enum EButton
    {
        Button_Add_Cube, 
    }

    public void IHas_UIButton_OnClickButton(UIButtonMessage<EButton> sButtonMsg)
    {
        switch (sButtonMsg.eButtonName)
        {
            case EButton.Button_Add_Cube:
                Debug.Log("Press Button [Add Cube]");
                break;

            default:
                break;
        }
    }

}
