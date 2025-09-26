using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData_", menuName = "UnitData/Monster")]
public class MonsterData : ScriptableObject
{
    [Header("General Stats")]
    [SerializeField]
    private string _name = "...";
    public string Name => _name;

    [SerializeField] 
    private MonsterType _monsterType = MonsterType.None;
    public MonsterType MonsterType => _monsterType;
    [SerializeField]
    [Range(0, 100)]
    private float _changeToDropItem = 20;
    public float ChangeToDropItem => _changeToDropItem;
    [SerializeField]
    [Tooltip("Radius size where monster will see the player")]
    private float _rangeOfAwareness =10;
    public float RangeOfAwareness => _rangeOfAwareness;

    [Header("Combat Stats")] 
    [SerializeField] 
    private int _damage = 1;
    public int Damage => _damage;
    [SerializeField] 
    private int _health = 1;
    public int Health => _health;
    [SerializeField] 
    private int _speed = 1;
    public int Speed => _speed;
    
    [Header("Dialogue")]
    [SerializeField]
    [Tooltip("Speaks dialogue when entering combat")]
    [TextArea()]
    private string _battleCry = "...";
    public string BattleCry => _battleCry;
}
