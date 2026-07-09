using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001043")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1480", Offset = "0x5A1480")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1480", Offset = "0x5A1480")]
	public class SetRandomMaterial : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C64")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEA1C", Offset = "0x5DEA1C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DEA1C", Offset = "0x5DEA1C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C65")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEAB0", Offset = "0x5DEAB0")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C66")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEAE8", Offset = "0x5DEAE8")]
		public FsmMaterial[] materials;

		[Token(Token = "0x600616C")]
		[Address(RVA = "0x1043894", Offset = "0x1043894", VA = "0x1043894", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600616D")]
		[Address(RVA = "0x10438FC", Offset = "0x10438FC", VA = "0x10438FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600616E")]
		[Address(RVA = "0x1043924", Offset = "0x1043924", VA = "0x1043924")]
		private void DoSetRandomMaterial()
		{
		}

		[Token(Token = "0x600616F")]
		[Address(RVA = "0x1043BF8", Offset = "0x1043BF8", VA = "0x1043BF8")]
		public SetRandomMaterial()
		{
		}
	}
}
