using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001083")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2734", Offset = "0x5A2734")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2734", Offset = "0x5A2734")]
	public class SetIsKinematic : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DB5")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4168", Offset = "0x5E4168")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4168", Offset = "0x5E4168")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DB6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E41FC", Offset = "0x5E41FC")]
		[RequiredField]
		public FsmBool isKinematic;

		[Token(Token = "0x60062A1")]
		[Address(RVA = "0x103E764", Offset = "0x103E764", VA = "0x103E764", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062A2")]
		[Address(RVA = "0x103E794", Offset = "0x103E794", VA = "0x103E794", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062A3")]
		[Address(RVA = "0x103E7BC", Offset = "0x103E7BC", VA = "0x103E7BC")]
		private void DoSetIsKinematic()
		{
		}

		[Token(Token = "0x60062A4")]
		[Address(RVA = "0x103E880", Offset = "0x103E880", VA = "0x103E880")]
		public SetIsKinematic()
		{
		}
	}
}
