using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bombScript : MonoBehaviour
{
    public float fieldofImpact;
    public float force;
    public LayerMask LayerToHit;
    public GameObject ExplosionEffect;
    
    public int timeStart = 10;
    public Text textBox;
    public bool bool_time = false;
    
    public GameObject man1;
    
    public GameObject level_complete_panel;
    public GameObject level_not_complete_panel;

    void Update()
    {
        if(bool_time==true && timeStart>0)
        {
        	StartCoroutine(TimerTake());
        }
        
        if(timeStart==0)
        {
        	if(man1==null)
        	{
        		level_complete_panel.SetActive(true);
        	}
        	else
        	{
        		level_not_complete_panel.SetActive(true);
        	}
        	bool_time = false;
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            explode();
        }
    }
    
    IEnumerator TimerTake()
    {
    	bool_time = false;
    	yield return new WaitForSeconds(1);
    	timeStart -= 1;
    	textBox.text = "00:" + timeStart.ToString();
    	bool_time = true;
    }

    void explode()
    {
    	bool_time = true;
        textBox.text = "00:" + timeStart.ToString();
        
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position,fieldofImpact,LayerToHit);

        foreach(Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;

            obj.GetComponent<Rigidbody2D>().AddForce(direction*force);
        }

        GameObject ExplosionEffectIns = Instantiate(ExplosionEffect,transform.position,Quaternion.identity);
        Destroy(ExplosionEffectIns,10);
        gameObject.GetComponent<Renderer>().enabled = false;
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,fieldofImpact);
    }
}
