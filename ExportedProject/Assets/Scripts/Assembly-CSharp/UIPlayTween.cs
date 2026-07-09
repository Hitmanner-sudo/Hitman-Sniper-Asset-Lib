using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000036")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x590FF0", Offset = "0x590FF0")]
public class UIPlayTween : MonoBehaviour
{
	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x18")]
	public GameObject tweenTarget;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x20")]
	public int tweenGroup;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x24")]
	public Trigger trigger;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x28")]
	public Direction playDirection;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x2C")]
	public bool resetOnPlay;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x2D")]
	public bool resetIfDisabled;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x30")]
	public EnableCondition ifDisabledOnPlay;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x34")]
	public DisableCondition disableWhenFinished;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x38")]
	public bool includeChildren;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x40")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private string callWhenFinished;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x58")]
	private UITweener[] mTweens;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x60")]
	private bool mStarted;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x61")]
	private bool mHighlighted;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x64")]
	private int mActive;

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x14298C4", Offset = "0x14298C4", VA = "0x14298C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1429988", Offset = "0x1429988", VA = "0x1429988")]
	private void Start()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1429A14", Offset = "0x1429A14", VA = "0x1429A14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1429AB4", Offset = "0x1429AB4", VA = "0x1429AB4")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1429ED8", Offset = "0x1429ED8", VA = "0x1429ED8")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1429F44", Offset = "0x1429F44", VA = "0x1429F44")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1429F88", Offset = "0x1429F88", VA = "0x1429F88")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1429FD0", Offset = "0x1429FD0", VA = "0x1429FD0")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x142A03C", Offset = "0x142A03C", VA = "0x142A03C")]
	private void OnActivate(bool isActive)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x142A0A8", Offset = "0x142A0A8", VA = "0x142A0A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1429B20", Offset = "0x1429B20", VA = "0x1429B20")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x142A1CC", Offset = "0x142A1CC", VA = "0x142A1CC")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x142A2BC", Offset = "0x142A2BC", VA = "0x142A2BC")]
	public UIPlayTween()
	{
	}
}
