using UnityEngine;

public class Intantiate : MonoBehaviour
{
   [SerializeField]
   private GameObject objectToInstantiate;

   public void Instantiate(Transform target)
   {
    Instantiate(objectToInstantiate,target.position,Quaternion.identity);
   }
}
