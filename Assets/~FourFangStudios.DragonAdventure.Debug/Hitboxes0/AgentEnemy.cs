using UnityEngine;
using FourFangStudios.DragonAdventure.Hitboxes;

namespace FourFangStudios.DragonAdventure.Debug.Hitboxes0
{
  /// <summary>
  /// Agent for debugging the HitboxSetController.
  /// </summary>
  public class AgentEnemy : MonoBehaviour
  {
    protected void Start()
    {
      // setup defensive hitboxes
      this.hitboxesOffensive.SetGroupCollidersEnabled("offense", true);
    }

    protected void Update()
    {
      this.hurtballRotate();
    }

    protected void hurtballRotate()
    {
      this.hurtball.transform.RotateAround(this.transform.position, Vector3.up, 60 * Time.deltaTime);
    }

    [SerializeField] private HitboxController hitboxesOffensive;

    [SerializeField] private GameObject hurtball;
  }
}