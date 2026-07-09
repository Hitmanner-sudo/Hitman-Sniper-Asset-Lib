using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000218")]
public class BehaviourObjectiveTag : ObjectiveTagNPCBase
{
	[Token(Token = "0x2000219")]
	public enum BehaviourType
	{
		[Token(Token = "0x4000BF5")]
		Investigate = 0,
		[Token(Token = "0x4000BF6")]
		FireworkAttraction = 1
	}

	[Token(Token = "0x200021A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592B0C", Offset = "0x592B0C")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x10")]
		public BehaviourObjectiveTag _003C_003E4__this;

		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x18")]
		public AIController.BehaviourEventArgs args;

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x925F78", Offset = "0x925F78", VA = "0x925F78")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x925F80", Offset = "0x925F80", VA = "0x925F80")]
		internal bool _003COnBehaviourChange_003Eb__0(KeyValuePair<BehaviourType, Type> r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<BehaviourType, Type> behaviourDict;

	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0x98")]
	public BehaviourType[] ActiveOnBehaviour;

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0xC0FED8", Offset = "0xC0FED8", VA = "0xC0FED8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0xC0FF74", Offset = "0xC0FF74", VA = "0xC0FF74", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0xC10010", Offset = "0xC10010", VA = "0xC10010")]
	private void OnBehaviourChange(object sender, AIController.BehaviourEventArgs args)
	{
	}

	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0xC10194", Offset = "0xC10194", VA = "0xC10194")]
	public BehaviourObjectiveTag()
	{
	}
}
