using UnityEngine;

public class CubeCollector : MonoBehaviour
{
    private bool _isUsed;
    private void OnCollisionEnter(Collision collision)
    {
        if (!_isUsed)
        {
            collision.gameObject.GetComponent<Collector>().AddCube();
            _isUsed = true;
            Destroy(gameObject);
        }
    }
}