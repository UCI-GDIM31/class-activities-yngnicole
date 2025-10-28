using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.Rendering.DebugUI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

// The DeerW5 class will be used to make the deer walk towards a target GameObject in the game using the Navmesh.
// Its target object should be tunable by you in the Inspector.
// The DeerW5 class should :
// Don’t make this setting a Vector3! Make it a Transform.
// Be attached to the Deer GameObject as a Component.
// Have a setting tunable in the inspector which represents the Transform of the GameObject it will walk towards.
// Use GetComponent<> to get the NavMeshAgent Component on the Deer gameObject.
// When the game begins, use the NavMeshAgent Component to tell the deer where to walk.

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform target;

    private string _isWalkingName = "DeerIsWalking";

    NavMeshAgent myNavMeshAgent;
 private void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>(); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetDestinationToMousePosition();
        }
    }

    void SetDestinationToMousePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            myNavMeshAgent.SetDestination(hit.point);
        }
    }
}