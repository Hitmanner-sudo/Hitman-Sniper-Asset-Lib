using System;
using Il2CppDummyDll;

[Token(Token = "0x2000755")]
public class SplashScreenNewView : MainMenuPageView
{
	[Serializable]
	[Token(Token = "0x2000756")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F58", Offset = "0x595F58")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400296D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400296E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<UILabel, bool> _003C_003E9__5_0;

		[Token(Token = "0x60030DD")]
		[Address(RVA = "0xA52594", Offset = "0xA52594", VA = "0xA52594")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60030DE")]
		[Address(RVA = "0xA5259C", Offset = "0xA5259C", VA = "0xA5259C")]
		internal bool _003COnDownloadCompleted_003Eb__5_0(UILabel l)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400296A")]
	[FieldOffset(Offset = "0x98")]
	public ProgressionIcon LoadingIcon;

	[Token(Token = "0x400296B")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel[] DownloadLabels;

	[Token(Token = "0x400296C")]
	[FieldOffset(Offset = "0xA8")]
	public string[] DownloadLabelsKeys;

	[Token(Token = "0x60030D6")]
	[Address(RVA = "0xA74FE4", Offset = "0xA74FE4", VA = "0xA74FE4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60030D7")]
	[Address(RVA = "0xA75A70", Offset = "0xA75A70", VA = "0xA75A70", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60030D8")]
	[Address(RVA = "0xA754F4", Offset = "0xA754F4", VA = "0xA754F4")]
	private void OnDownloadCompleted(bool value)
	{
	}

	[Token(Token = "0x60030D9")]
	[Address(RVA = "0xA75214", Offset = "0xA75214", VA = "0xA75214")]
	private void OnCompletedObjectsChanged(int value)
	{
	}

	[Token(Token = "0x60030DA")]
	[Address(RVA = "0xA75388", Offset = "0xA75388", VA = "0xA75388")]
	private void OnObjectsToDownloadChanged(int value)
	{
	}

	[Token(Token = "0x60030DB")]
	[Address(RVA = "0xA75CA4", Offset = "0xA75CA4", VA = "0xA75CA4")]
	public SplashScreenNewView()
	{
	}
}
