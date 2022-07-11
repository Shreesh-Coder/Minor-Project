using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroStaticForce : MonoBehaviour
{
    public Rigidbody rbody;
    public float charge;
    public static List<ElectroStaticForce> electroStaticForces;
    const float K = 8.988e9f;
    private void FixedUpdate()
    {
        foreach (ElectroStaticForce electroStaticForce in electroStaticForces)
        {
            if(electroStaticForce != this)
                ForceCal(electroStaticForce);
        }
    }

    private void OnEnable()
    {
        if(electroStaticForces == null)
             electroStaticForces = new List<ElectroStaticForce>();

        electroStaticForces.Add(this);
    }

    private void OnDisable()
    {
        electroStaticForces.Remove(this);
    }

    void ForceCal(ElectroStaticForce obj)
    {
        Rigidbody objbody = obj.rbody; 
        Vector3 direction = rbody.position - objbody.position;
        float distance = direction.magnitude;
        //Debug.Log("distance: " + distance);
        if (distance == 0f)
            return;

        float forceMagnitued = K * (charge * obj.charge) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitued;
       // Debug.Log("direction: " + direction);
     //   Debug.Log("force: " + force);
        objbody.AddForce(force);
    }

}
