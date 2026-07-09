using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000679")]
public class IndicatorView : View
{
	[Token(Token = "0x200067A")]
	public class IndicatorInfo
	{
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x10")]
		public Transform LookAtTransform;

		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x18")]
		public bool Clickable;

		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x19")]
		public bool ShowIfOutOfScope;

		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x1A")]
		public bool OutOfScope;

		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 ScreenPos;

		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x28")]
		public float WorldVerticalOffset;

		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x30")]
		public TagIndicatorView TagIndicator;

		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 LastUpdatedPosition;

		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 CurrentLerpedPos;

		[Token(Token = "0x4002434")]
		[FieldOffset(Offset = "0x50")]
		public float LerpRatio;

		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x54")]
		public bool FirstDrawCalled;

		[Token(Token = "0x6002A61")]
		[Address(RVA = "0xB2575C", Offset = "0xB2575C", VA = "0xB2575C")]
		public IndicatorInfo()
		{
		}
	}

	[Token(Token = "0x200067B")]
	public class SetupIndicatorEventArgs : EventArgs
	{
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8E8C", Offset = "0x5B8E8C")]
		private TagIndicatorView _003CTagIndicator_003Ek__BackingField;

		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8E9C", Offset = "0x5B8E9C")]
		private IndicatorInfo _003CInfo_003Ek__BackingField;

		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8EAC", Offset = "0x5B8EAC")]
		private Trackable _003CTrackable_003Ek__BackingField;

		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0x28")]
		public PlayerTrackingSystem TrackingSystem;

		[Token(Token = "0x17000571")]
		public TagIndicatorView TagIndicator
		{
			[Token(Token = "0x6002A62")]
			[Address(RVA = "0xB258B4", Offset = "0xB258B4", VA = "0xB258B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E398", Offset = "0x61E398")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A63")]
			[Address(RVA = "0xB258BC", Offset = "0xB258BC", VA = "0xB258BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E3A8", Offset = "0x61E3A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000572")]
		public IndicatorInfo Info
		{
			[Token(Token = "0x6002A64")]
			[Address(RVA = "0xB258C4", Offset = "0xB258C4", VA = "0xB258C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E3B8", Offset = "0x61E3B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A65")]
			[Address(RVA = "0xB258CC", Offset = "0xB258CC", VA = "0xB258CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E3C8", Offset = "0x61E3C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000573")]
		public Trackable Trackable
		{
			[Token(Token = "0x6002A66")]
			[Address(RVA = "0xB258D4", Offset = "0xB258D4", VA = "0xB258D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E3D8", Offset = "0x61E3D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A67")]
			[Address(RVA = "0xB258DC", Offset = "0xB258DC", VA = "0xB258DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E3E8", Offset = "0x61E3E8")]
			set
			{
			}
		}

		[Token(Token = "0x6002A68")]
		[Address(RVA = "0xB258E4", Offset = "0xB258E4", VA = "0xB258E4")]
		public SetupIndicatorEventArgs()
		{
		}
	}

	[Token(Token = "0x200067C")]
	private class OverlappedIndicatorCollection
	{
		[Token(Token = "0x400243A")]
		[FieldOffset(Offset = "0x10")]
		public float MinScreenAngle2D;

		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0x14")]
		public float MaxScreenAngle2D;

		[Token(Token = "0x400243C")]
		[FieldOffset(Offset = "0x18")]
		public List<IndicatorInfo> Indicators;

		[Token(Token = "0x6002A69")]
		[Address(RVA = "0xB257A0", Offset = "0xB257A0", VA = "0xB257A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0xB258AC", Offset = "0xB258AC", VA = "0xB258AC")]
		public OverlappedIndicatorCollection()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200067D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595918", Offset = "0x595918")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400243D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400243E")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<OverlappedIndicatorCollection> _003C_003E9__26_0;

		[Token(Token = "0x400243F")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<OverlappedIndicatorCollection> _003C_003E9__26_1;

		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0xB256D4", Offset = "0xB256D4", VA = "0xB256D4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0xB256DC", Offset = "0xB256DC", VA = "0xB256DC")]
		internal int _003CDrawIndicatorsInScope_003Eb__26_0(OverlappedIndicatorCollection a, OverlappedIndicatorCollection b)
		{
			return default(int);
		}

		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0xB25704", Offset = "0xB25704", VA = "0xB25704")]
		internal bool _003CDrawIndicatorsInScope_003Eb__26_1(OverlappedIndicatorCollection o)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400241C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float COS45;

	[Token(Token = "0x400241D")]
	[FieldOffset(Offset = "0x4")]
	private static readonly float TWO_PI;

	[Token(Token = "0x400241E")]
	[FieldOffset(Offset = "0x60")]
	public TagIndicatorView TagIndicatorPrefab;

	[Token(Token = "0x400241F")]
	[FieldOffset(Offset = "0x68")]
	public float CircleRadius;

	[Token(Token = "0x4002420")]
	[FieldOffset(Offset = "0x70")]
	public HUDView HUDView;

	[Token(Token = "0x4002421")]
	[FieldOffset(Offset = "0x78")]
	public UIAnchor AnchorCenter;

	[Token(Token = "0x4002422")]
	[FieldOffset(Offset = "0x80")]
	private List<TagIndicatorView> _tagPoolUnused;

	[Token(Token = "0x4002423")]
	[FieldOffset(Offset = "0x88")]
	private List<TagIndicatorView> _tagPoolUsed;

	[Token(Token = "0x4002424")]
	[FieldOffset(Offset = "0x90")]
	private float _indicatorAngleRange;

	[Token(Token = "0x4002425")]
	[FieldOffset(Offset = "0x98")]
	private List<IndicatorInfo> _indicatorsToDraw;

	[Token(Token = "0x4002426")]
	[FieldOffset(Offset = "0xA0")]
	private Camera _gameCamera;

	[Token(Token = "0x4002427")]
	[FieldOffset(Offset = "0xA8")]
	private Camera _playerCamera;

	[Token(Token = "0x4002428")]
	[FieldOffset(Offset = "0xB0")]
	private UIRoot _root;

	[Token(Token = "0x4002429")]
	[FieldOffset(Offset = "0xB8")]
	private bool _initialisedTags;

	[Token(Token = "0x400242A")]
	[FieldOffset(Offset = "0xBC")]
	private float _cachedUpdateOutOfScsopeLerpIncrement;

	[Token(Token = "0x6002A52")]
	[Address(RVA = "0xB0B21C", Offset = "0xB0B21C", VA = "0xB0B21C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002A53")]
	[Address(RVA = "0xB0B334", Offset = "0xB0B334", VA = "0xB0B334", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A54")]
	[Address(RVA = "0xB0B33C", Offset = "0xB0B33C", VA = "0xB0B33C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002A55")]
	[Address(RVA = "0xB0B39C", Offset = "0xB0B39C", VA = "0xB0B39C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002A56")]
	[Address(RVA = "0xB0B5FC", Offset = "0xB0B5FC", VA = "0xB0B5FC", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x6002A57")]
	[Address(RVA = "0xB0BA64", Offset = "0xB0BA64", VA = "0xB0BA64")]
	private TagIndicatorView GetTagIndicator(TagIndicatorView existingIndicator)
	{
		return null;
	}

	[Token(Token = "0x6002A58")]
	[Address(RVA = "0xB0CD60", Offset = "0xB0CD60", VA = "0xB0CD60")]
	private void ReturnLastItemToPool(TagIndicatorView indicator)
	{
	}

	[Token(Token = "0x6002A59")]
	[Address(RVA = "0xB0C7D0", Offset = "0xB0C7D0", VA = "0xB0C7D0")]
	private void DrawIndicators()
	{
	}

	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0xB0BCF4", Offset = "0xB0BCF4", VA = "0xB0BCF4")]
	private void DrawIndicatorsInScope()
	{
	}

	[Token(Token = "0x6002A5B")]
	[Address(RVA = "0xB0CDC4", Offset = "0xB0CDC4", VA = "0xB0CDC4")]
	private void InitIndicator(IndicatorInfo indicator, Vector3 position, float radius, Vector2 screenCenter, List<OverlappedIndicatorCollection> overlappedIndicatorCollections)
	{
	}

	[Token(Token = "0x6002A5C")]
	[Address(RVA = "0xB0D0F8", Offset = "0xB0D0F8", VA = "0xB0D0F8")]
	private bool ResloveOverlappedIndicators(List<OverlappedIndicatorCollection> sortedCollections)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A5D")]
	[Address(RVA = "0xB0D8CC", Offset = "0xB0D8CC", VA = "0xB0D8CC")]
	private void adjustParent(Transform child, Transform parent)
	{
	}

	[Token(Token = "0x6002A5E")]
	[Address(RVA = "0xB0D41C", Offset = "0xB0D41C", VA = "0xB0D41C")]
	private void DrawResolvedIndicators()
	{
	}

	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0xB0D9F8", Offset = "0xB0D9F8", VA = "0xB0D9F8")]
	public IndicatorView()
	{
	}
}
