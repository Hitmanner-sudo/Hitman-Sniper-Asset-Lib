using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001070")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2170", Offset = "0x5A2170")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2170", Offset = "0x5A2170")]
	public class FindOverlaps : ComponentAction<Transform>
	{
		[Token(Token = "0x2001071")]
		public enum Shape
		{
			[Token(Token = "0x4004D4D")]
			Box = 0,
			[Token(Token = "0x4004D4E")]
			Sphere = 1,
			[Token(Token = "0x4004D4F")]
			Capsule = 2
		}

		[Token(Token = "0x4004D35")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1E20", Offset = "0x5E1E20")]
		public FsmOwnerDefault position;

		[Token(Token = "0x4004D36")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1E58", Offset = "0x5E1E58")]
		public FsmVector3 offset;

		[Token(Token = "0x4004D37")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1E90", Offset = "0x5E1E90")]
		public Shape shape;

		[Token(Token = "0x4004D38")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1EC8", Offset = "0x5E1EC8")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5E1EC8", Offset = "0x5E1EC8")]
		public FsmFloat radius;

		[Token(Token = "0x4004D39")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5E1F28", Offset = "0x5E1F28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1F28", Offset = "0x5E1F28")]
		public FsmVector3 box;

		[Token(Token = "0x4004D3A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5E1F88", Offset = "0x5E1F88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1F88", Offset = "0x5E1F88")]
		public FsmFloat height;

		[Token(Token = "0x4004D3B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1FE8", Offset = "0x5E1FE8")]
		public FsmInt maxOverlaps;

		[Token(Token = "0x4004D3C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ActionSection", RVA = "0x5E2020", Offset = "0x5E2020")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2020", Offset = "0x5E2020")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2020", Offset = "0x5E2020")]
		public FsmInt layerMask;

		[Token(Token = "0x4004D3D")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2094", Offset = "0x5E2094")]
		public FsmBool invertMask;

		[Token(Token = "0x4004D3E")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E20CC", Offset = "0x5E20CC")]
		public FsmBool includeSelf;

		[Token(Token = "0x4004D3F")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2104", Offset = "0x5E2104")]
		public FsmInt repeatInterval;

		[Token(Token = "0x4004D40")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E213C", Offset = "0x5E213C")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5E213C", Offset = "0x5E213C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E213C", Offset = "0x5E213C")]
		[Attribute(Name = "ActionSection", RVA = "0x5E213C", Offset = "0x5E213C")]
		public FsmArray storeOverlapping;

		[Token(Token = "0x4004D41")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E21E4", Offset = "0x5E21E4")]
		public FsmEvent foundOverlaps;

		[Token(Token = "0x4004D42")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E221C", Offset = "0x5E221C")]
		public FsmEvent noOverlaps;

		[Token(Token = "0x4004D43")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ActionSection", RVA = "0x5E2254", Offset = "0x5E2254")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2254", Offset = "0x5E2254")]
		public FsmColor debugColor;

		[Token(Token = "0x4004D44")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E22B4", Offset = "0x5E22B4")]
		public FsmBool debug;

		[Token(Token = "0x4004D45")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E22EC", Offset = "0x5E22EC")]
		private Vector3 _003Ccenter_003Ek__BackingField;

		[Token(Token = "0x4004D46")]
		[FieldOffset(Offset = "0xF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E22FC", Offset = "0x5E22FC")]
		private Quaternion _003Corientation_003Ek__BackingField;

		[Token(Token = "0x4004D47")]
		[FieldOffset(Offset = "0x104")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E230C", Offset = "0x5E230C")]
		private Vector3 _003CcapsulePoint1_003Ek__BackingField;

		[Token(Token = "0x4004D48")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E231C", Offset = "0x5E231C")]
		private Vector3 _003CcapsulePoint2_003Ek__BackingField;

		[Token(Token = "0x4004D49")]
		[FieldOffset(Offset = "0x11C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E232C", Offset = "0x5E232C")]
		private int _003CtargetMask_003Ek__BackingField;

		[Token(Token = "0x4004D4A")]
		[FieldOffset(Offset = "0x120")]
		private Collider[] colliders;

		[Token(Token = "0x4004D4B")]
		[FieldOffset(Offset = "0x128")]
		private int repeat;

		[Token(Token = "0x17000C3B")]
		public Vector3 center
		{
			[Token(Token = "0x600623E")]
			[Address(RVA = "0x9552FC", Offset = "0x9552FC", VA = "0x9552FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C0A0", Offset = "0x62C0A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600623F")]
			[Address(RVA = "0x955308", Offset = "0x955308", VA = "0x955308")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C0B0", Offset = "0x62C0B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C3C")]
		public Quaternion orientation
		{
			[Token(Token = "0x6006240")]
			[Address(RVA = "0x955314", Offset = "0x955314", VA = "0x955314")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C0C0", Offset = "0x62C0C0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6006241")]
			[Address(RVA = "0x955320", Offset = "0x955320", VA = "0x955320")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C0D0", Offset = "0x62C0D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C3D")]
		public Vector3 capsulePoint1
		{
			[Token(Token = "0x6006242")]
			[Address(RVA = "0x95532C", Offset = "0x95532C", VA = "0x95532C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C0E0", Offset = "0x62C0E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6006243")]
			[Address(RVA = "0x95533C", Offset = "0x95533C", VA = "0x95533C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C0F0", Offset = "0x62C0F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C3E")]
		public Vector3 capsulePoint2
		{
			[Token(Token = "0x6006244")]
			[Address(RVA = "0x95534C", Offset = "0x95534C", VA = "0x95534C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C100", Offset = "0x62C100")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6006245")]
			[Address(RVA = "0x95535C", Offset = "0x95535C", VA = "0x95535C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C110", Offset = "0x62C110")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C3F")]
		public int targetMask
		{
			[Token(Token = "0x6006246")]
			[Address(RVA = "0x95536C", Offset = "0x95536C", VA = "0x95536C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C120", Offset = "0x62C120")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6006247")]
			[Address(RVA = "0x955374", Offset = "0x955374", VA = "0x955374")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C130", Offset = "0x62C130")]
			private set
			{
			}
		}

		[Token(Token = "0x6006248")]
		[Address(RVA = "0x95537C", Offset = "0x95537C", VA = "0x95537C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006249")]
		[Address(RVA = "0x955500", Offset = "0x955500", VA = "0x955500", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600624A")]
		[Address(RVA = "0x955520", Offset = "0x955520", VA = "0x955520")]
		public bool HideBox()
		{
			return default(bool);
		}

		[Token(Token = "0x600624B")]
		[Address(RVA = "0x955530", Offset = "0x955530", VA = "0x955530")]
		public bool HideRadius()
		{
			return default(bool);
		}

		[Token(Token = "0x600624C")]
		[Address(RVA = "0x955544", Offset = "0x955544", VA = "0x955544")]
		public bool HideCapsule()
		{
			return default(bool);
		}

		[Token(Token = "0x600624D")]
		[Address(RVA = "0x955554", Offset = "0x955554", VA = "0x955554", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600624E")]
		[Address(RVA = "0x955A44", Offset = "0x955A44", VA = "0x955A44", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600624F")]
		[Address(RVA = "0x955600", Offset = "0x955600", VA = "0x955600")]
		private void DoGetOverlap()
		{
		}

		[Token(Token = "0x6006250")]
		[Address(RVA = "0x955A5C", Offset = "0x955A5C", VA = "0x955A5C")]
		public void InitShapeCenter()
		{
		}

		[Token(Token = "0x6006251")]
		[Address(RVA = "0x955BD8", Offset = "0x955BD8", VA = "0x955BD8")]
		public FindOverlaps()
		{
		}
	}
}
