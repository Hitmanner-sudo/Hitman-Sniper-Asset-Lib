using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003E5")]
public class AssignmentHandler : MonoBehaviour
{
	[Token(Token = "0x40015AE")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B51A0", Offset = "0x5B51A0")]
	private AssignmentData _003CAssignment_003Ek__BackingField;

	[Token(Token = "0x170003DA")]
	public AssignmentData Assignment
	{
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0xC01B84", Offset = "0xC01B84", VA = "0xC01B84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617524", Offset = "0x617524")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001800")]
		[Address(RVA = "0xC01B8C", Offset = "0xC01B8C", VA = "0xC01B8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617534", Offset = "0x617534")]
		set
		{
		}
	}

	[Token(Token = "0x1400005B")]
	public event EventHandler OnSuccess
	{
		[Token(Token = "0x6001801")]
		[Address(RVA = "0xC01B94", Offset = "0xC01B94", VA = "0xC01B94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617544", Offset = "0x617544")]
		add
		{
		}
		[Token(Token = "0x6001802")]
		[Address(RVA = "0xC01C34", Offset = "0xC01C34", VA = "0xC01C34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617554", Offset = "0x617554")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005C")]
	public event EventHandler OnFail
	{
		[Token(Token = "0x6001803")]
		[Address(RVA = "0xC01CD4", Offset = "0xC01CD4", VA = "0xC01CD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617564", Offset = "0x617564")]
		add
		{
		}
		[Token(Token = "0x6001804")]
		[Address(RVA = "0xC01D74", Offset = "0xC01D74", VA = "0xC01D74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617574", Offset = "0x617574")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005D")]
	public event EventHandler OnProgress
	{
		[Token(Token = "0x6001805")]
		[Address(RVA = "0xC01E14", Offset = "0xC01E14", VA = "0xC01E14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617584", Offset = "0x617584")]
		add
		{
		}
		[Token(Token = "0x6001806")]
		[Address(RVA = "0xC01EB4", Offset = "0xC01EB4", VA = "0xC01EB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617594", Offset = "0x617594")]
		remove
		{
		}
	}

	[Token(Token = "0x6001807")]
	[Address(RVA = "0xC0152C", Offset = "0xC0152C", VA = "0xC0152C")]
	public void Completed()
	{
	}

	[Token(Token = "0x6001808")]
	[Address(RVA = "0xC0153C", Offset = "0xC0153C", VA = "0xC0153C")]
	public void Fail()
	{
	}

	[Token(Token = "0x6001809")]
	[Address(RVA = "0xC01F54", Offset = "0xC01F54", VA = "0xC01F54")]
	public void Progress(float progress)
	{
	}

	[Token(Token = "0x600180A")]
	[Address(RVA = "0xC01F64", Offset = "0xC01F64", VA = "0xC01F64")]
	public AssignmentHandler()
	{
	}
}
