
using UnityEngine;

public class DeathBringerSpellController : MonoBehaviour
{
    public static System.Action<int, Transform> spellSFX;

    [SerializeField] private Transform check;
    [SerializeField] private Vector2 boxSize;
    [SerializeField] private LayerMask whatisPlayer;
    public EnemyData enemyData;

    private void Awake()
    {
       
    }

    public void SetupSpell(EnemyData _stat) => enemyData = _stat;
    private void AnimationTrigger()
    {
        Collider2D[] colliders = Physics2D.OverlapBoxAll(check.position, boxSize ,whatisPlayer);
        spellSFX?.Invoke(23, null);


        foreach (var hit in colliders)
        {
            CharacterStats unitHP = hit.GetComponent<CharacterStats>();
            Player player = hit.GetComponent<Player>();


            if (player != null && unitHP != null)
            {
                // Log evasion check
                float roll = Random.Range(0, 100);


                if (roll > player.playerData.evasion)
                {
              
                    float magicDamage = Mathf.Max(0, enemyData.magicDamage - player.playerData.magicArmor);



                 
                    if (magicDamage > 0) unitHP.OnCurrentHPChange(-magicDamage);


                }
                else
                {
                    Debug.Log("Attack Missed!");
                }
            }
        }
    }

    private void OnDrawGizmos() =>Gizmos.DrawWireCube(check.position, boxSize);
    
    private void SelfDestroy() => Destroy(gameObject);
}
