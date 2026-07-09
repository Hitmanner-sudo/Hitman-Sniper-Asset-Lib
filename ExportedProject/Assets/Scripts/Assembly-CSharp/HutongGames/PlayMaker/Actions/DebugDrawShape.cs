using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F6A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CEF8", Offset = "0x59CEF8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CEF8", Offset = "0x59CEF8")]
	public class DebugDrawShape : ComponentAction<Transform>
	{
		[Token(Token = "0x2000F6B")]
		public enum ShapeType
		{
			[Token(Token = "0x40048D2")]
			Sphere = 0,
			[Token(Token = "0x40048D3")]
			Cube = 1,
			[Token(Token = "0x40048D4")]
			WireSphere = 2,
			[Token(Token = "0x40048D5")]
			WireCube = 3
		}

		[Token(Token = "0x40048CC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0594", Offset = "0x5D0594")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40048CD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D05E0", Offset = "0x5D05E0")]
		public ShapeType shape;

		[Token(Token = "0x40048CE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0618", Offset = "0x5D0618")]
		public FsmColor color;

		[Token(Token = "0x40048CF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5D0650", Offset = "0x5D0650")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0650", Offset = "0x5D0650")]
		public FsmFloat radius;

		[Token(Token = "0x40048D0")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D06B0", Offset = "0x5D06B0")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5D06B0", Offset = "0x5D06B0")]
		public FsmVector3 size;

		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0xAE86BC", Offset = "0xAE86BC", VA = "0xAE86BC")]
		public bool HideRadius()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0xAE86D0", Offset = "0xAE86D0", VA = "0xAE86D0")]
		public bool HideSize()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E20")]
		[Address(RVA = "0xAE86E4", Offset = "0xAE86E4", VA = "0xAE86E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E21")]
		[Address(RVA = "0xAE87B0", Offset = "0xAE87B0", VA = "0xAE87B0", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6005E22")]
		[Address(RVA = "0xAE87B8", Offset = "0xAE87B8", VA = "0xAE87B8", Slot = "38")]
		public override void OnDrawActionGizmos()
		{
		}

		[Token(Token = "0x6005E23")]
		[Address(RVA = "0xAE89DC", Offset = "0xAE89DC", VA = "0xAE89DC")]
		public DebugDrawShape()
		{
		}
	}
}
