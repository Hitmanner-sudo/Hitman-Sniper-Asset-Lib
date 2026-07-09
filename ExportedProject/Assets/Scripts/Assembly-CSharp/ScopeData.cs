using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038F")]
public class ScopeData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000390")]
	public class ScopeSetting
	{
		[NonSerialized]
		[Token(Token = "0x40013CE")]
		[FieldOffset(Offset = "0x10")]
		internal float _minZoomLevelModifier;

		[NonSerialized]
		[Token(Token = "0x40013CF")]
		[FieldOffset(Offset = "0x14")]
		internal float _maxZoomLevelModifier;

		[Token(Token = "0x40013D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal float _minZoomLevel;

		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal float _minZoomPhoneLevel;

		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal float _maxZoomLevel;

		[NonSerialized]
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x24")]
		internal float UpgradedMaxZoomLevel;

		[Token(Token = "0x17000345")]
		public float MinZoomLevel
		{
			[Token(Token = "0x60015A3")]
			[Address(RVA = "0x8B6914", Offset = "0x8B6914", VA = "0x8B6914")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000346")]
		public float MaxZoomLevel
		{
			[Token(Token = "0x60015A4")]
			[Address(RVA = "0x8B6954", Offset = "0x8B6954", VA = "0x8B6954")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000347")]
		public float MinFOV
		{
			[Token(Token = "0x60015A5")]
			[Address(RVA = "0x8B6974", Offset = "0x8B6974", VA = "0x8B6974")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000348")]
		public float MaxFOV
		{
			[Token(Token = "0x60015A6")]
			[Address(RVA = "0x8B69FC", Offset = "0x8B69FC", VA = "0x8B69FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x8B6A98", Offset = "0x8B6A98", VA = "0x8B6A98")]
		public ScopeSetting()
		{
		}
	}

	[Token(Token = "0x2000391")]
	public enum Range
	{
		[Token(Token = "0x40013D5")]
		Short = 0,
		[Token(Token = "0x40013D6")]
		Medium = 1,
		[Token(Token = "0x40013D7")]
		Long = 2,
		[Token(Token = "0x40013D8")]
		Count = 3
	}

	[Token(Token = "0x40013C2")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float REFERENCE_FOV;

	[Token(Token = "0x40013C3")]
	[FieldOffset(Offset = "0x18")]
	public LazyTexture2D ScopeTextureHighEnd;

	[Token(Token = "0x40013C4")]
	[FieldOffset(Offset = "0x20")]
	public LazyTexture2D ScopeTextureLowEnd;

	[Token(Token = "0x40013C5")]
	[FieldOffset(Offset = "0x28")]
	public Color ScopeTextureColor;

	[Token(Token = "0x40013C6")]
	[FieldOffset(Offset = "0x38")]
	public Color ScopeHUDColor;

	[Token(Token = "0x40013C7")]
	[FieldOffset(Offset = "0x48")]
	public ScopeSetting Settings;

	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x50")]
	public float InDuration;

	[Token(Token = "0x40013C9")]
	[FieldOffset(Offset = "0x54")]
	public float OutDuration;

	[Token(Token = "0x40013CA")]
	[FieldOffset(Offset = "0x58")]
	public float OutToReloadDuration;

	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0x5C")]
	public float InFromReloadDuration;

	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve InTranstition;

	[Token(Token = "0x40013CD")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve OutTranstition;

	[Token(Token = "0x600159D")]
	[Address(RVA = "0xBB2E78", Offset = "0xBB2E78", VA = "0xBB2E78")]
	public static float ZoomLevelFromFOV(float ReferenceFOV, float CurrentFOV)
	{
		return default(float);
	}

	[Token(Token = "0x600159E")]
	[Address(RVA = "0xBB2EE0", Offset = "0xBB2EE0", VA = "0xBB2EE0")]
	public static float FOVFromZoomLevel(float ReferenceFOV, float ZoomLevel)
	{
		return default(float);
	}

	[Token(Token = "0x600159F")]
	[Address(RVA = "0xBB2F3C", Offset = "0xBB2F3C", VA = "0xBB2F3C")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x60015A0")]
	[Address(RVA = "0xBB2F68", Offset = "0xBB2F68", VA = "0xBB2F68")]
	public void ApplyAttachment(Attachment attachment)
	{
	}

	[Token(Token = "0x60015A1")]
	[Address(RVA = "0xBB3008", Offset = "0xBB3008", VA = "0xBB3008")]
	public ScopeData()
	{
	}
}
