using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20007DD")]
[Attribute(Name = "GameUpdateOrderAttribute", RVA = "0x5963CC", Offset = "0x5963CC")]
public class ScopeVignette : GameMonoBehaviour
{
	[Token(Token = "0x4002BE2")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _speedYaw;

	[Token(Token = "0x4002BE3")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _speedPitch;

	[Token(Token = "0x4002BE4")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5BAF8C", Offset = "0x5BAF8C")]
	[SerializeField]
	private float _centeredYaw;

	[Token(Token = "0x4002BE5")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5BAFD4", Offset = "0x5BAFD4")]
	[SerializeField]
	private float _centeredPitch;

	[Token(Token = "0x4002BE6")]
	[FieldOffset(Offset = "0x58")]
	private Material _cachedMaterial;

	[Token(Token = "0x4002BE7")]
	[FieldOffset(Offset = "0x60")]
	private GameRealTimer _flashingTimer;

	[Token(Token = "0x6003387")]
	[Address(RVA = "0xBB36F4", Offset = "0xBB36F4", VA = "0xBB36F4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003388")]
	[Address(RVA = "0xBB3B98", Offset = "0xBB3B98", VA = "0xBB3B98")]
	public void StartFlashing(Color color, float duration)
	{
	}

	[Token(Token = "0x6003389")]
	[Address(RVA = "0xBB3CE4", Offset = "0xBB3CE4", VA = "0xBB3CE4", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x600338A")]
	[Address(RVA = "0xBB3F64", Offset = "0xBB3F64", VA = "0xBB3F64")]
	private float GetSignedDeltaAngle(float fromAngle, float toAngle)
	{
		return default(float);
	}

	[Token(Token = "0x600338B")]
	[Address(RVA = "0xBB3FB4", Offset = "0xBB3FB4", VA = "0xBB3FB4")]
	public ScopeVignette()
	{
	}
}
