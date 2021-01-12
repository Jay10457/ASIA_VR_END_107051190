using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa : MonoBehaviour
{
    [SerializeField] GameObject prefab;
	[SerializeField] Animator ani;

    public void OnPick()
    {
        if (prefab.transform.position.y > 10f)
        {
            ani.SetBool("IsFloating", true);
        }
            
    }
    public void DetachFromHands()
    {
      
        
            ani.SetBool("IsFloating", false);
       
        
    }




}
