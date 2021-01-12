using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa : MonoBehaviour
{
    [SerializeField] GameObject prefab;
	[SerializeField] Animator ani;

    public void OnPick()
    {
       
        
       ani.SetBool("IsFloating", true);
        
            
    }
    public void DetachFromHands()
    {
      
        
            ani.SetBool("IsFloating", false);
       
        
    }




}
