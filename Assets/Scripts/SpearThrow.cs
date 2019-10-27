using UnityEngine.UI;
using UnityEngine;

public class SpearThrow : MonoBehaviour
{

    public GameObject spear;
    public float throwspeed = 50.0f;
    public float damage = 5f;
    public float range = 10;
    public Camera fpsCam;
    public Text KillCount;
    public int k_count;

    public GameObject bloodsplatter;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUpdate();

        if (Input.GetMouseButtonDown(0))
        {
            ThrowSpear();
        }

        KillCount.text = "Sharks repelled: " + k_count;
    }

    public void ThrowSpear()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (target.tag == "shark")
            {
            GameObject bloodymess = Instantiate(bloodsplatter, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(bloodymess, 1f);
                k_count++;
            }

        }

    }

    public void ScoreUpdate()
    {
        KillCount.text = "Sharks repelled: " + k_count;
    }
}

