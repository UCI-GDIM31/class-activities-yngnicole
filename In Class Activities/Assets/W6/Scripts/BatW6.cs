using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

// Write the BatW6 class here.
// The BatW6 class will make the bat chase the Cat object, when enabled.
// The BatW6 class should :
// Be attached to ALL of the Bat GameObjects as a Component.
// Have a speed value tunable in the Inspector.
// Have a method that the BatManager can call that
// will make the bat STOP chasing the player,
// and a different one that will make the bat START chasing the player.
// (Hint: make sure to put the keyword ‘public’ in front of these methods so that BatManager
// can use them- we’ll talk about what this keyword means next class.)

public class BatW6 : MonoBehaviour
{
    [SerializeField] public float _speed;
    private Transform _playerTransform;

    public void EnableChase(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }

    public void DisableChase()
    {
        enabled = false;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed * Time.deltaTime
            );



    }

}
