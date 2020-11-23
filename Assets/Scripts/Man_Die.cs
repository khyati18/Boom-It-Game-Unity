using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man_Die : MonoBehaviour
{
    public GameObject Man;
    public GameObject Pattern;
    
    private void DestroyMan()
    {
    	Destroy(Man);
    	Instantiate(Pattern, transform.position, Quaternion.identity);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
    	if(collision.collider.tag=="Ground")
    	{
    		SoundManager.PlaySound("death");
    		DestroyMan();
    	}
    }

}
