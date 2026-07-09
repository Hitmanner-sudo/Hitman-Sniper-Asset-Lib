using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000033")]
[Attribute(Name = "AddComponentMenu", RVA = "0x590F6C", Offset = "0x590F6C")]
[ExecuteInEditMode]
public class UIPlayAnimation : MonoBehaviour
{
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x18")]
	public Animation target;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x20")]
	public string clipName;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x28")]
	public Trigger trigger;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x2C")]
	public Direction playDirection;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x30")]
	public bool resetOnPlay;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x31")]
	public bool clearSelection;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x34")]
	public EnableCondition ifDisabledOnPlay;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x38")]
	public DisableCondition disableWhenFinished;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x40")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private string callWhenFinished;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x58")]
	private bool mStarted;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x59")]
	private bool mHighlighted;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x5C")]
	private int mActive;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1428E34", Offset = "0x1428E34", VA = "0x1428E34")]
	private void Awake()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1428EF8", Offset = "0x1428EF8", VA = "0x1428EF8")]
	private void Start()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1428F98", Offset = "0x1428F98", VA = "0x1428F98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1429038", Offset = "0x1429038", VA = "0x1429038")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1429348", Offset = "0x1429348", VA = "0x1429348")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x14293B4", Offset = "0x14293B4", VA = "0x14293B4")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x14293F8", Offset = "0x14293F8", VA = "0x14293F8")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1429440", Offset = "0x1429440", VA = "0x1429440")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x14294AC", Offset = "0x14294AC", VA = "0x14294AC")]
	private void OnActivate(bool isActive)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x14290A4", Offset = "0x14290A4", VA = "0x14290A4")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1429518", Offset = "0x1429518", VA = "0x1429518")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1429608", Offset = "0x1429608", VA = "0x1429608")]
	public UIPlayAnimation()
	{
	}
}
