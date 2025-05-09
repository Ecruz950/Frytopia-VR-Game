using UnityEngine;

public class FriesCombiner : MonoBehaviour
{
    public GameObject fullCupPrefab; // Assign Fries Box_01 (1) here

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EmptyFriesCup"))
        {
            Vector3 spawnPos = transform.parent.position; // parent = fries root
            Destroy(other.gameObject);                   // destroy empty cup
            Destroy(transform.parent.gameObject);        // destroy fries parent

            Instantiate(fullCupPrefab, spawnPos, Quaternion.identity);
        }
    }

}
