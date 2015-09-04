using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 游戏角色行为
/// </summary>
public class MonoActor : MonoBehaviour
{
    public Slider HP;
    public Transform launcher;
    public Text actorName;
    public ActorData actorData;
    private Image icon;
    private Vector3 BPUP = new Vector3(391f, 297f, 0f), BPDOWN = new Vector3(-391f, -297f, 0);
    /// <summary>
    /// 出生点位置，上方为true,下方为false
    /// </summary>
    public bool IsPos = true;
    // 初始化调用
    public virtual void Awake()
    {
        
    }
    public void Start()
    {
    }
    void Update()
    {

    }
    public virtual void Init()
    {
        icon = GetComponent<Image>();
        icon.sprite = SpriteManager.GetInstance().Load(actorData.icon);
        icon.SetNativeSize();
        RefData();
        if(IsPos)
        {
            transform.localPosition = BPUP;
        }else
        {
            transform.localPosition = BPDOWN;
        }
        //开场进入战场
        MoveTo(new Vector3(0, 0, 0), (float)actorData.moveSpeed);
    }
    /// <summary>
    /// 刷新数据
    /// </summary>
    public virtual void RefData()
    {
        HP.value = (float)actorData.HP / (float)actorData.maxHP;
        actorName.text = actorData.name;
    }
    public virtual void DestroySelf()
    {
        GameObject.Destroy(gameObject);
    }
    public virtual void MoveTo(Vector3 target,float duration)
    {
        TweenPosition.Begin(gameObject, duration, target);
    }
}

