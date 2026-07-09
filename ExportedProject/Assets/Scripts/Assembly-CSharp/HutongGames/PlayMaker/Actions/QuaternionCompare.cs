using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A411C", Offset = "0x5A411C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A411C", Offset = "0x5A411C")]
	public class QuaternionCompare : QuaternionBaseAction
	{
		[Token(Token = "0x4004F62")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB798", Offset = "0x5EB798")]
		public FsmQuaternion Quaternion1;

		[Token(Token = "0x4004F63")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB7E4", Offset = "0x5EB7E4")]
		public FsmQuaternion Quaternion2;

		[Token(Token = "0x4004F64")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB830", Offset = "0x5EB830")]
		public FsmBool equal;

		[Token(Token = "0x4004F65")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB868", Offset = "0x5EB868")]
		public FsmEvent equalEvent;

		[Token(Token = "0x4004F66")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB8A0", Offset = "0x5EB8A0")]
		public FsmEvent notEqualEvent;

		[Token(Token = "0x600642A")]
		[Address(RVA = "0xB3D01C", Offset = "0xB3D01C", VA = "0xB3D01C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600642B")]
		[Address(RVA = "0xB3D0B8", Offset = "0xB3D0B8", VA = "0xB3D0B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600642C")]
		[Address(RVA = "0xB3D17C", Offset = "0xB3D17C", VA = "0xB3D17C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600642D")]
		[Address(RVA = "0xB3D18C", Offset = "0xB3D18C", VA = "0xB3D18C", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600642E")]
		[Address(RVA = "0xB3D1A0", Offset = "0xB3D1A0", VA = "0xB3D1A0", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600642F")]
		[Address(RVA = "0xB3D0F4", Offset = "0xB3D0F4", VA = "0xB3D0F4")]
		private void DoQuatCompare()
		{
		}

		[Token(Token = "0x6006430")]
		[Address(RVA = "0xB3D1B4", Offset = "0xB3D1B4", VA = "0xB3D1B4")]
		public QuaternionCompare()
		{
		}
	}
}
