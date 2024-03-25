using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform startPoint;
    public float fireSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(fireBullet);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void fireBullet(ActivateEventArgs args)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = startPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = startPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);
    }
}
