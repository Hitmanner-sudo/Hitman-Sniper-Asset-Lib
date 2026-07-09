using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FFA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FC28", Offset = "0x59FC28")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FC28", Offset = "0x59FC28")]
	public class GetKeyUp : FsmStateAction
	{
		[Token(Token = "0x4004B01")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8BCC", Offset = "0x5D8BCC")]
		[RequiredField]
		public KeyCode key;

		[Token(Token = "0x4004B02")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8C18", Offset = "0x5D8C18")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004B03")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8C50", Offset = "0x5D8C50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8C50", Offset = "0x5D8C50")]
		public FsmBool storeResult;

		[Token(Token = "0x6006021")]
		[Address(RVA = "0x1063AF4", Offset = "0x1063AF4", VA = "0x1063AF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006022")]
		[Address(RVA = "0x1063B04", Offset = "0x1063B04", VA = "0x1063B04", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006023")]
		[Address(RVA = "0x1063B60", Offset = "0x1063B60", VA = "0x1063B60")]
		public GetKeyUp()
		{
		}
	}
}
