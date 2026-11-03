using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
public class DeerW5 : MonoBehaviour
{
    // Write your DeerW5 class in here :)
    // Hint: if you don't remember what a class is supposed to look like,
    //      maybe check out CatW5...
    // If you copied the class declaration from CatW5, you'd only need to change one thing...
    [SerializeField] private Transform Target;

    NavMeshAgent myNavMeshAgent;
    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        myNavMeshAgent.SetDestination(Target.position);
    }
}
