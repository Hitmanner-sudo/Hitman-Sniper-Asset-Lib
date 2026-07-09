using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20002C3")]
public class TutorialFindTheSurvivor : TutorialToLearnLogic
{
	[Token(Token = "0x4000F84")]
	[FieldOffset(Offset = "0x0")]
	public static bool endZombieMode;

	[Token(Token = "0x4000F85")]
	[FieldOffset(Offset = "0x28")]
	private List<DataModel> _registeredModels;

	[Token(Token = "0x60010E9")]
	[Address(RVA = "0xCA329C", Offset = "0xCA329C", VA = "0xCA329C")]
	public TutorialFindTheSurvivor(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x60010EA")]
	[Address(RVA = "0xCA32C8", Offset = "0xCA32C8", VA = "0xCA32C8", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60010EB")]
	[Address(RVA = "0xCA33A0", Offset = "0xCA33A0", VA = "0xCA33A0", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60010EC")]
	[Address(RVA = "0xCA34F8", Offset = "0xCA34F8", VA = "0xCA34F8", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x60010ED")]
	[Address(RVA = "0xCA35DC", Offset = "0xCA35DC", VA = "0xCA35DC")]
	private void ShowSurvivorTag()
	{
	}

	[Token(Token = "0x60010EE")]
	[Address(RVA = "0xCA39A0", Offset = "0xCA39A0", VA = "0xCA39A0")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60010EF")]
	[Address(RVA = "0xCA3AA0", Offset = "0xCA3AA0", VA = "0xCA3AA0")]
	private void ActivateZombieWave()
	{
	}

	[Token(Token = "0x60010F0")]
	[Address(RVA = "0xCA3BBC", Offset = "0xCA3BBC", VA = "0xCA3BBC", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x60010F1")]
	[Address(RVA = "0xCA3D2C", Offset = "0xCA3D2C", VA = "0xCA3D2C", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}

	[Token(Token = "0x60010F3")]
	[Address(RVA = "0xCA3DEC", Offset = "0xCA3DEC", VA = "0xCA3DEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x615C24", Offset = "0x615C24")]
	private void _003CDoStop_003Eb__9_0(DataModel m)
	{
	}
}
