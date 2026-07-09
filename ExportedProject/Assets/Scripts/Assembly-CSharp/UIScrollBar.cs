using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003B")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5910C0", Offset = "0x5910C0")]
public class UIScrollBar : UIWidgetContainer
{
	[Token(Token = "0x200003C")]
	public enum Direction
	{
		[Token(Token = "0x4000146")]
		Horizontal = 0,
		[Token(Token = "0x4000147")]
		Vertical = 1
	}

	[Token(Token = "0x200003D")]
	public delegate void OnDragFinished();

	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x0")]
	public static UIScrollBar current;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x18")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x20")]
	public OnDragFinished onDragFinished;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private UISprite mBG;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private UISprite mFG;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[HideInInspector]
	private Direction mDir;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[HideInInspector]
	private bool mInverted;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private float mScroll;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[HideInInspector]
	private float mSize;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x48")]
	private Transform mTrans;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x50")]
	private bool mIsDirty;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x58")]
	private Camera mCam;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 mScreenPos;

	[Token(Token = "0x1700002E")]
	public Transform cachedTransform
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x142EAB8", Offset = "0x142EAB8", VA = "0x142EAB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	public Camera cachedCamera
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x142EB44", Offset = "0x142EB44", VA = "0x142EB44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	public UISprite background
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x142EC24", Offset = "0x142EC24", VA = "0x142EC24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x142EC2C", Offset = "0x142EC2C", VA = "0x142EC2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public UISprite foreground
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x142ECB8", Offset = "0x142ECB8", VA = "0x142ECB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x142ECC0", Offset = "0x142ECC0", VA = "0x142ECC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public Direction direction
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x142ED4C", Offset = "0x142ED4C", VA = "0x142ED4C")]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x142ED54", Offset = "0x142ED54", VA = "0x142ED54")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public bool inverted
	{
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x142F3C4", Offset = "0x142F3C4", VA = "0x142F3C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x142F3CC", Offset = "0x142F3CC", VA = "0x142F3CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public float value
	{
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x142F3F4", Offset = "0x142F3F4", VA = "0x142F3F4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x142F3FC", Offset = "0x142F3FC", VA = "0x142F3FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x62DAE0", Offset = "0x62DAE0")]
	public float scrollValue
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x142F4CC", Offset = "0x142F4CC", VA = "0x142F4CC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x142F4D4", Offset = "0x142F4D4", VA = "0x142F4D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public float barSize
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x142F4D8", Offset = "0x142F4D8", VA = "0x142F4D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x142F4E0", Offset = "0x142F4E0", VA = "0x142F4E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public float alpha
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x142F5B0", Offset = "0x142F5B0", VA = "0x142F5B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x142F688", Offset = "0x142F688", VA = "0x142F688")]
		set
		{
		}
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x142F8B0", Offset = "0x142F8B0", VA = "0x142F8B0")]
	private void CenterOnPos(Vector2 localPos)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x142FAAC", Offset = "0x142FAAC", VA = "0x142FAAC")]
	private void Reposition(Vector2 screenPos)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x142FC0C", Offset = "0x142FC0C", VA = "0x142FC0C")]
	private void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x142FCB4", Offset = "0x142FCB4", VA = "0x142FCB4")]
	private void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x142FD2C", Offset = "0x142FD2C", VA = "0x142FD2C")]
	private void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x142FE20", Offset = "0x142FE20", VA = "0x142FE20")]
	private void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x142FEB0", Offset = "0x142FEB0", VA = "0x142FEB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x143026C", Offset = "0x143026C", VA = "0x143026C")]
	private void Update()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x142EF7C", Offset = "0x142EF7C", VA = "0x142EF7C")]
	public void ForceUpdate()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x143027C", Offset = "0x143027C", VA = "0x143027C")]
	public UIScrollBar()
	{
	}
}
