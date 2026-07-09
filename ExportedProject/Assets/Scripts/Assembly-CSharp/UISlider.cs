using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003E")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5910F8", Offset = "0x5910F8")]
public class UISlider : UIWidgetContainer
{
	[Token(Token = "0x200003F")]
	public enum Direction
	{
		[Token(Token = "0x400015A")]
		Horizontal = 0,
		[Token(Token = "0x400015B")]
		Vertical = 1
	}

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x0")]
	public static UISlider current;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x18")]
	public Transform foreground;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x20")]
	public Transform thumb;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x28")]
	public Direction direction;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x2C")]
	public int numberOfSteps;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x30")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[HideInInspector]
	private float rawValue;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	private string functionName;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x50")]
	private BoxCollider mCol;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x58")]
	private Transform mTrans;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x60")]
	private Transform mFGTrans;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x68")]
	private UIWidget mFGWidget;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x70")]
	private UISprite mFGFilled;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x78")]
	private bool mInitDone;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x7C")]
	private Vector2 mSize;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x84")]
	private Vector2 mCenter;

	[Token(Token = "0x17000038")]
	public float value
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x143134C", Offset = "0x143134C", VA = "0x143134C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1431418", Offset = "0x1431418", VA = "0x1431418")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DB18", Offset = "0x62DB18")]
	public float sliderValue
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x14318B4", Offset = "0x14318B4", VA = "0x14318B4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x14318B8", Offset = "0x14318B8", VA = "0x14318B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public Vector2 fullSize
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x14318C0", Offset = "0x14318C0", VA = "0x14318C0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x14318C8", Offset = "0x14318C8", VA = "0x14318C8")]
		set
		{
		}
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1431AD0", Offset = "0x1431AD0", VA = "0x1431AD0")]
	public void Init()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1431E80", Offset = "0x1431E80", VA = "0x1431E80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1431F30", Offset = "0x1431F30", VA = "0x1431F30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1432178", Offset = "0x1432178", VA = "0x1432178")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1432530", Offset = "0x1432530", VA = "0x1432530")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1432568", Offset = "0x1432568", VA = "0x1432568")]
	private void OnPressThumb(GameObject go, bool pressed)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x14325A8", Offset = "0x14325A8", VA = "0x14325A8")]
	private void OnDragThumb(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x14325E0", Offset = "0x14325E0", VA = "0x14325E0")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x143221C", Offset = "0x143221C", VA = "0x143221C")]
	private void UpdateDrag()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1431420", Offset = "0x1431420", VA = "0x1431420")]
	private void Set(float input, bool force)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1431AC4", Offset = "0x1431AC4", VA = "0x1431AC4")]
	public void ForceUpdate()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1432680", Offset = "0x1432680", VA = "0x1432680")]
	public UISlider()
	{
	}
}
