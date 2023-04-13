using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Pathfinding;

public class Guard : MonoBehaviour
{
    public GameObject target;
    public GameObject GuardHanlder;
    public GameObject LastTarget;

    public int damage = 5;
    public int timeBetweenAttacks;

    void Update()
    {
        if (target == null)
        {
            getNextTarget();
            if (target != null) 
            {
                this.GetComponent<AIDestinationSetter>().target = target.transform;
            }
            
        }
    }

    public void getNextTarget() 
    {
        List<GameObject> targets = GuardHanlder.GetComponent<HandleGuard>().enemeyList;
        //get new target
        if (targets.Contains(LastTarget)) 
        {
            targets.Remove(LastTarget);
        }
        //clean targets of fallen enemies
        for (int i = 0; i < targets.Count; i++) 
        {
            if (targets[i] == null) 
            {
                targets.RemoveAt(i);
            }
        }

            float minDist = float.MaxValue;
        GameObject currTarget = null;
        for (int i = 0; i < targets.Count; i++)
        {
            if (Vector3.Distance(targets[i].transform.position, this.transform.position) < minDist) 
            {
                minDist = Vector3.Distance(targets[i].transform.position, this.transform.position);
                currTarget = targets[i];
            }
        }
        target = currTarget;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Peasant") ||
            collision.gameObject.CompareTag("Thief")||
            collision.gameObject.CompareTag("Trickster"))
        {
            DealDamage(collision);
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Peasant") ||
            collision.gameObject.CompareTag("Thief") ||
            collision.gameObject.CompareTag("Trickster"))
        {
            DealDamage(collision);
        }
    }
    public void DealDamage(Collider2D collision) 
    {
        string tag = collision.tag;
        Wait(timeBetweenAttacks);
        switch (tag) 
        {
            case "Peasant":
                collision.gameObject.GetComponent<Peasant>().TakeDamage(damage);
                break;
            case "Thief":
                collision.gameObject.GetComponent<Thief>().TakeDamage(damage);
                break;
            case "Trickster":
                collision.gameObject.GetComponent<Trickster>().TakeDamage(damage);
                break;
        }
        
    }

    public async void Wait(float durration)
    {
        await Task.Delay((int)(durration * 1000));
    }
}
