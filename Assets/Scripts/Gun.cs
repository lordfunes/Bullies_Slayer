using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 1000f;
    public float range = 10000f;

    public Camera fpsCam;

    public ParticleSystem flash;
    public ParticleSystem bullet;


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
        flash.Play();
        bullet.Play();

        RaycastHit hit;
        
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDammage(damage);
            }
        }
    }
}
