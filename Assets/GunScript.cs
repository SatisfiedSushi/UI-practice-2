using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    public float coolDownTimer;

    private float coolDown = 10;

    public ParticleSystem muzzleFlash;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }




    }


    void Shoot()
    {
        RaycastHit hit;

        muzzleFlash.Emit(1);

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            

            Debug.Log(hit.transform.name);

            HitScript target = hit.transform.GetComponent<HitScript>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }

        }

        
    }  
}
