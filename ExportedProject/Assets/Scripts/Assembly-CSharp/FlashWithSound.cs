using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002FE")]
public class FlashWithSound : MonoBehaviour
{
	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PlayAISound _aiSound;

	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _repeatDelay;

	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Light _flashingLight;

	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _flashingBillboard;

	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve _flashingLightAnimationCurve;

	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _flashingLightMinIntensity;

	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _flashingLightMaxIntensity;

	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _flashingBillboardMinScale;

	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _flashingBillboardMaxScale;

	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _startAtMaxIntensity;

	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x54")]
	private float _startTime;

	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x58")]
	private float _minMaxLightDifference;

	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x5C")]
	private float _minMaxBillboardDifference;

	[Token(Token = "0x6001248")]
	[Address(RVA = "0x958100", Offset = "0x958100", VA = "0x958100")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001249")]
	[Address(RVA = "0x95843C", Offset = "0x95843C", VA = "0x95843C")]
	private void Update()
	{
	}

	[Token(Token = "0x600124A")]
	[Address(RVA = "0x958268", Offset = "0x958268", VA = "0x958268")]
	private void SetVisual()
	{
	}

	[Token(Token = "0x600124B")]
	[Address(RVA = "0x958440", Offset = "0x958440", VA = "0x958440")]
	public FlashWithSound()
	{
	}
}
