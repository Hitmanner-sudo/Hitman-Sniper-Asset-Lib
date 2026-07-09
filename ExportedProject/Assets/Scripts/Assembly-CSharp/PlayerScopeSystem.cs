using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004DB")]
public class PlayerScopeSystem : PlayerSystem
{
	[Token(Token = "0x20004DC")]
	private enum Scope
	{
		[Token(Token = "0x4001A05")]
		Out = 0,
		[Token(Token = "0x4001A06")]
		ToIn = 1,
		[Token(Token = "0x4001A07")]
		In = 2,
		[Token(Token = "0x4001A08")]
		ToOut = 3
	}

	[Token(Token = "0x20004DD")]
	public class ZoomEvent : EventArgs
	{
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x10")]
		public float ZoomLevel;

		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x14")]
		public float MaxZoomLevel;

		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x18")]
		public float MinZoomLevel;

		[Token(Token = "0x170004A1")]
		public bool IsAtMaxZoom
		{
			[Token(Token = "0x6001DE6")]
			[Address(RVA = "0x8D7244", Offset = "0x8D7244", VA = "0x8D7244")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170004A2")]
		public bool IsAtMinZoom
		{
			[Token(Token = "0x6001DE7")]
			[Address(RVA = "0x8D7250", Offset = "0x8D7250", VA = "0x8D7250")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x8D71E0", Offset = "0x8D71E0", VA = "0x8D71E0")]
		public ZoomEvent()
		{
		}
	}

	[Token(Token = "0x20004DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E18", Offset = "0x594E18")]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x10")]
		public PlayerScopeSystem _003C_003E4__this;

		[Token(Token = "0x4001A0D")]
		[FieldOffset(Offset = "0x18")]
		public float zoomLevel;

		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x8D7148", Offset = "0x8D7148", VA = "0x8D7148")]
		public _003C_003Ec__DisplayClass72_0()
		{
		}

		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x8D7150", Offset = "0x8D7150", VA = "0x8D7150")]
		internal ZoomEvent _003CZoom_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x40019F5")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B739C", Offset = "0x5B739C")]
	private float _003CLastZoomLevel_003Ek__BackingField;

	[Token(Token = "0x40019F6")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B73AC", Offset = "0x5B73AC")]
	private float _003CTotalAccumulatedZoom_003Ek__BackingField;

	[Token(Token = "0x40019F7")]
	[FieldOffset(Offset = "0x58")]
	private Scope _state;

	[Token(Token = "0x40019F8")]
	[FieldOffset(Offset = "0x5C")]
	private Scope _desireState;

	[Token(Token = "0x40019FB")]
	[FieldOffset(Offset = "0x60")]
	private float _outOfScopeDuration;

	[Token(Token = "0x40019FC")]
	[FieldOffset(Offset = "0x64")]
	private float _inScopeDuration;

	[Token(Token = "0x40019FD")]
	[FieldOffset(Offset = "0x68")]
	private PlayerTimer _transitionTimer;

	[Token(Token = "0x40019FE")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 _startZoomTargetDirection;

	[Token(Token = "0x40019FF")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 _endZoomTargetDirection;

	[Token(Token = "0x4001A00")]
	[FieldOffset(Offset = "0x88")]
	private Transform _endZoomTarget;

	[Token(Token = "0x4001A01")]
	[FieldOffset(Offset = "0x90")]
	private float _inScopeFOV;

	[Token(Token = "0x4001A03")]
	[FieldOffset(Offset = "0x94")]
	private float _lastZoomSoundPlayed;

	[Token(Token = "0x1700048E")]
	public float LastZoomLevel
	{
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0xAB68A0", Offset = "0xAB68A0", VA = "0xAB68A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618908", Offset = "0x618908")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0xAB68A8", Offset = "0xAB68A8", VA = "0xAB68A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618918", Offset = "0x618918")]
		private set
		{
		}
	}

	[Token(Token = "0x1700048F")]
	public float TotalAccumulatedZoom
	{
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0xAB68B0", Offset = "0xAB68B0", VA = "0xAB68B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618928", Offset = "0x618928")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0xAB68B8", Offset = "0xAB68B8", VA = "0xAB68B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618938", Offset = "0x618938")]
		private set
		{
		}
	}

	[Token(Token = "0x17000490")]
	public bool IsInScope
	{
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0xAB73F4", Offset = "0xAB73F4", VA = "0xAB73F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000491")]
	public bool IsOutOfScope
	{
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0xAB7418", Offset = "0xAB7418", VA = "0xAB7418")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000492")]
	public bool IsInTransition
	{
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0xAB7438", Offset = "0xAB7438", VA = "0xAB7438")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000493")]
	public bool IsInScopeTransition
	{
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0xAB744C", Offset = "0xAB744C", VA = "0xAB744C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000494")]
	public bool IsOutOfScopeTransition
	{
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0xAB7470", Offset = "0xAB7470", VA = "0xAB7470")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000495")]
	public float ScopeBlend
	{
		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0xAB7490", Offset = "0xAB7490", VA = "0xAB7490")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000496")]
	public float OutOfScopeFOV
	{
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0xAB754C", Offset = "0xAB754C", VA = "0xAB754C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000497")]
	public float InScopeFOV
	{
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0xAB75CC", Offset = "0xAB75CC", VA = "0xAB75CC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000498")]
	public bool IsMaxInScopeFOV
	{
		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0xAB75D4", Offset = "0xAB75D4", VA = "0xAB75D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000499")]
	public bool IsMinInScopeFOV
	{
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0xAB7648", Offset = "0xAB7648", VA = "0xAB7648")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700049A")]
	private float MaxFOV
	{
		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0xAB7608", Offset = "0xAB7608", VA = "0xAB7608")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700049B")]
	private float MinFOV
	{
		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0xAB767C", Offset = "0xAB767C", VA = "0xAB767C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700049C")]
	public float ZoomLevel
	{
		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0xAB569C", Offset = "0xAB569C", VA = "0xAB569C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700049D")]
	public float MinZoomLevel
	{
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0xAB561C", Offset = "0xAB561C", VA = "0xAB561C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700049E")]
	public float MaxZoomLevel
	{
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0xAB565C", Offset = "0xAB565C", VA = "0xAB565C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700049F")]
	public bool IsAtMaxZoomLevel
	{
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0xAB76BC", Offset = "0xAB76BC", VA = "0xAB76BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004A0")]
	public bool IsAtMinZoomLevel
	{
		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0xAB76FC", Offset = "0xAB76FC", VA = "0xAB76FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000074")]
	public static event EventHandler OnExitScope
	{
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0xAB70FC", Offset = "0xAB70FC", VA = "0xAB70FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618948", Offset = "0x618948")]
		add
		{
		}
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0xAB71B8", Offset = "0xAB71B8", VA = "0xAB71B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618958", Offset = "0x618958")]
		remove
		{
		}
	}

	[Token(Token = "0x14000075")]
	public static event EventHandler OnEnterScope
	{
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0xAB7274", Offset = "0xAB7274", VA = "0xAB7274")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618968", Offset = "0x618968")]
		add
		{
		}
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0xAB7334", Offset = "0xAB7334", VA = "0xAB7334")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618978", Offset = "0x618978")]
		remove
		{
		}
	}

	[Token(Token = "0x14000076")]
	public static event EventHandler<ZoomEvent> OnZoom
	{
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0xAB773C", Offset = "0xAB773C", VA = "0xAB773C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618988", Offset = "0x618988")]
		add
		{
		}
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0xAB77FC", Offset = "0xAB77FC", VA = "0xAB77FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618998", Offset = "0x618998")]
		remove
		{
		}
	}

	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0xAB68C0", Offset = "0xAB68C0", VA = "0xAB68C0")]
	public void OnWeaponAttached()
	{
	}

	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0xAB6958", Offset = "0xAB6958", VA = "0xAB6958")]
	public void GoInScope(float duration, Vector3 targetDir)
	{
	}

	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0xAB6B1C", Offset = "0xAB6B1C", VA = "0xAB6B1C")]
	public void GoInScope(float duration, Transform target)
	{
	}

	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0xAB6960", Offset = "0xAB6960", VA = "0xAB6960")]
	private void GoInScope(float duration, Transform target, Vector3 targetDir)
	{
	}

	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0xAB6B74", Offset = "0xAB6B74", VA = "0xAB6B74")]
	public void GoOutOfScope(float duration)
	{
	}

	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0xAB6CD4", Offset = "0xAB6CD4", VA = "0xAB6CD4", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0xAB6F14", Offset = "0xAB6F14", VA = "0xAB6F14")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0xAB6D1C", Offset = "0xAB6D1C", VA = "0xAB6D1C")]
	private void UpdateZoomToTarget()
	{
	}

	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0xAB6ED0", Offset = "0xAB6ED0", VA = "0xAB6ED0")]
	private void UpdateZoomOut()
	{
	}

	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0xAB78BC", Offset = "0xAB78BC", VA = "0xAB78BC")]
	public void Zoom(float value)
	{
	}

	[Token(Token = "0x6001DE4")]
	[Address(RVA = "0xAB7B08", Offset = "0xAB7B08", VA = "0xAB7B08")]
	private void PlayZoomSound(float zoomLevel)
	{
	}

	[Token(Token = "0x6001DE5")]
	[Address(RVA = "0xAB7D20", Offset = "0xAB7D20", VA = "0xAB7D20")]
	public PlayerScopeSystem()
	{
	}
}
