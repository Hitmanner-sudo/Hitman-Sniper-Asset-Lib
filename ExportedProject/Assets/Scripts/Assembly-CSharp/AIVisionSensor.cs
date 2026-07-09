using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200013C")]
public class AIVisionSensor : AISensor
{
	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 VisionStart;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 VisionDirection;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Ellipse _focusVisionEllipse;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float PeripheralRange;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float ShortPeripheralRange;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float FocusRange;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float FocusWidth;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float PeripheralAngleCos;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float ShortPeripheralAngleCos;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public VisionZone VisionZone;

	[Token(Token = "0x40006DA")]
	public const bool DebugRaycasts = false;

	[Token(Token = "0x17000169")]
	public override Vector3 EarPosition
	{
		[Token(Token = "0x6000888")]
		[Address(RVA = "0xA9990C", Offset = "0xA9990C", VA = "0xA9990C", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000889")]
	[Address(RVA = "0xA99918", Offset = "0xA99918", VA = "0xA99918", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0xA999EC", Offset = "0xA999EC", VA = "0xA999EC", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0xA99C54", Offset = "0xA99C54", VA = "0xA99C54", Slot = "16")]
	protected virtual void UpdateVisionStart()
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0xA99CA4", Offset = "0xA99CA4", VA = "0xA99CA4")]
	public bool IsInFocusVision(Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0xA99D78", Offset = "0xA99D78", VA = "0xA99D78")]
	public bool IsInPeripheralVision(Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0xA99D8C", Offset = "0xA99D8C", VA = "0xA99D8C", Slot = "17")]
	public virtual bool IsInPeripheralVision(Vector3 position, float maxDistance)
	{
		return default(bool);
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0xA99F40", Offset = "0xA99F40", VA = "0xA99F40")]
	public Visibility GetVisibility(Vector3 lookAtPosition, float maxDistance, [Optional] Transform transformToIgnore)
	{
		return default(Visibility);
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0xA9A2B8", Offset = "0xA9A2B8", VA = "0xA9A2B8")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x612790", Offset = "0x612790")]
	public void ClearRays()
	{
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0xA9A02C", Offset = "0xA9A02C", VA = "0xA9A02C")]
	private bool IsHidden(Vector3 lookAtPosition, Transform transformToIgnore)
	{
		return default(bool);
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0xA97E48", Offset = "0xA97E48", VA = "0xA97E48")]
	public void TestVision(AIVisionEmitter emitter)
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0xA9A2BC", Offset = "0xA9A2BC", VA = "0xA9A2BC")]
	public bool HasFoulPlayDeaths(int max)
	{
		return default(bool);
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0xA9A418", Offset = "0xA9A418", VA = "0xA9A418")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0xA9A774", Offset = "0xA9A774", VA = "0xA9A774")]
	public AIVisionSensor()
	{
	}
}
