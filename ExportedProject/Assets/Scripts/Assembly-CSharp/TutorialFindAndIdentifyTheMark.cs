using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20002C1")]
public class TutorialFindAndIdentifyTheMark : TutorialToLearnLogic
{
	[Token(Token = "0x4000F81")]
	private const float TIME_BEFORE_ID_MARK = 2f;

	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x28")]
	private GameTimer _idTimer;

	[Token(Token = "0x4000F83")]
	[FieldOffset(Offset = "0x30")]
	private List<DataModel> _registeredModels;

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0xCA1E34", Offset = "0xCA1E34", VA = "0xCA1E34")]
	public TutorialFindAndIdentifyTheMark(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x60010D9")]
	[Address(RVA = "0xCA1E60", Offset = "0xCA1E60", VA = "0xCA1E60", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60010DA")]
	[Address(RVA = "0xCA1F80", Offset = "0xCA1F80", VA = "0xCA1F80", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60010DB")]
	[Address(RVA = "0xCA2024", Offset = "0xCA2024", VA = "0xCA2024", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x60010DC")]
	[Address(RVA = "0xCA2140", Offset = "0xCA2140", VA = "0xCA2140", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x60010DD")]
	[Address(RVA = "0xCA268C", Offset = "0xCA268C", VA = "0xCA268C")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60010DE")]
	[Address(RVA = "0xCA278C", Offset = "0xCA278C", VA = "0xCA278C", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x60010DF")]
	[Address(RVA = "0xCA28FC", Offset = "0xCA28FC", VA = "0xCA28FC", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x60010E0")]
	[Address(RVA = "0xCA29B0", Offset = "0xCA29B0", VA = "0xCA29B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x615C14", Offset = "0x615C14")]
	private void _003CDoStop_003Eb__9_0(DataModel m)
	{
	}
}
