using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EDB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A340", Offset = "0x59A340")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A340", Offset = "0x59A340")]
	public class GetAnimatorFloat : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004659")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5A70", Offset = "0x5C5A70")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C5A70", Offset = "0x5C5A70")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400465A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5B04", Offset = "0x5C5B04")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5B04", Offset = "0x5C5B04")]
		[RequiredField]
		public FsmString parameter;

		[Token(Token = "0x400465B")]
		[FieldOffset(Offset = "0x88")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5B64", Offset = "0x5C5B64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5B64", Offset = "0x5C5B64")]
		public FsmFloat result;

		[Token(Token = "0x400465C")]
		[FieldOffset(Offset = "0x90")]
		private string cachedParameter;

		[Token(Token = "0x400465D")]
		[FieldOffset(Offset = "0x98")]
		private int paramID;

		[Token(Token = "0x17000C0F")]
		private Animator animator
		{
			[Token(Token = "0x6005BA0")]
			[Address(RVA = "0xDA3580", Offset = "0xDA3580", VA = "0xDA3580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0xDA3588", Offset = "0xDA3588", VA = "0xDA3588", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0xDA35B4", Offset = "0xDA35B4", VA = "0xDA35B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0xDA36F0", Offset = "0xDA36F0", VA = "0xDA36F0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0xDA35F0", Offset = "0xDA35F0", VA = "0xDA35F0")]
		private void GetParameter()
		{
		}

		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0xDA36F4", Offset = "0xDA36F4", VA = "0xDA36F4")]
		public GetAnimatorFloat()
		{
		}
	}
}
