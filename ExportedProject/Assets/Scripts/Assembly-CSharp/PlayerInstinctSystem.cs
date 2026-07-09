using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004D7")]
public class PlayerInstinctSystem : PlayerSystem
{
	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x50")]
	public Camera AimingCamera;

	[NonSerialized]
	[Token(Token = "0x40019DF")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Camera InstinctCamera;

	[Token(Token = "0x40019E0")]
	[FieldOffset(Offset = "0x60")]
	public LayerMask CullingMask;

	[Token(Token = "0x40019E1")]
	[FieldOffset(Offset = "0x68")]
	public Shader InstinctShader;

	[Token(Token = "0x40019E2")]
	[FieldOffset(Offset = "0x70")]
	public Color InstinctColor;

	[Token(Token = "0x40019E3")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B7324", Offset = "0x5B7324")]
	public float InstinctBaseIntensity;

	[Token(Token = "0x40019E4")]
	[FieldOffset(Offset = "0x88")]
	private Transform _aimingCameraTransform;

	[Token(Token = "0x40019E5")]
	[FieldOffset(Offset = "0x90")]
	private Transform _instinctCameraTransform;

	[Token(Token = "0x40019E6")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B733C", Offset = "0x5B733C")]
	private float _fadeSpeed;

	[Token(Token = "0x40019E7")]
	[FieldOffset(Offset = "0x0")]
	private static int INSTINCT_SHADER_PROPERTY;

	[Token(Token = "0x40019E8")]
	[FieldOffset(Offset = "0x4")]
	private static float _intensity;

	[Token(Token = "0x40019E9")]
	[FieldOffset(Offset = "0x8")]
	private static float _currentIntensity;

	[Token(Token = "0x40019EA")]
	[FieldOffset(Offset = "0xC")]
	private static bool _showInstinct;

	[Token(Token = "0x1700048B")]
	public static bool isInstinctEnabled
	{
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0xB8A8AC", Offset = "0xB8A8AC", VA = "0xB8A8AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0xB8A924", Offset = "0xB8A924", VA = "0xB8A924", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0xB8AD68", Offset = "0xB8AD68", VA = "0xB8AD68", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0xB8AEB4", Offset = "0xB8AEB4", VA = "0xB8AEB4", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0xB8ABC0", Offset = "0xB8ABC0", VA = "0xB8ABC0")]
	public static void SetInstinct(bool active)
	{
	}

	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0xB8AC40", Offset = "0xB8AC40", VA = "0xB8AC40")]
	public void HideInstinct()
	{
	}

	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0xB8B19C", Offset = "0xB8B19C", VA = "0xB8B19C")]
	public void ShowInstinct()
	{
	}

	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0xB8B234", Offset = "0xB8B234", VA = "0xB8B234")]
	public PlayerInstinctSystem()
	{
	}
}
