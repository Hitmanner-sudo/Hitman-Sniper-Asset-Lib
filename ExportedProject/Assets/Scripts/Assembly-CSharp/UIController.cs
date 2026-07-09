using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200055F")]
public abstract class UIController : GameMonoBehaviour
{
	[Token(Token = "0x4001C7C")]
	[FieldOffset(Offset = "0x48")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x170004EC")]
	public List<DataModel> Models
	{
		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x15831B4", Offset = "0x15831B4", VA = "0x15831B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60021FC")]
	[Address(RVA = "0x15831D0", Offset = "0x15831D0", VA = "0x15831D0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60021FD")]
	public T GetVariable<T>(string name)
	{
		return (T)null;
	}

	[Token(Token = "0x60021FE")]
	[Address(RVA = "0x1583264", Offset = "0x1583264", VA = "0x1583264")]
	public int GetIntVariable(string name)
	{
		return default(int);
	}

	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x1583280", Offset = "0x1583280", VA = "0x1583280")]
	public bool GetBoolVariable(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6002200")]
	[Address(RVA = "0x158329C", Offset = "0x158329C", VA = "0x158329C")]
	public float GetFloatVariable(string name)
	{
		return default(float);
	}

	[Token(Token = "0x6002201")]
	[Address(RVA = "0x15832B8", Offset = "0x15832B8", VA = "0x15832B8")]
	public void IncrementVariable(string name)
	{
	}

	[Token(Token = "0x6002202")]
	[Address(RVA = "0x15832D8", Offset = "0x15832D8", VA = "0x15832D8")]
	public void IncrementVariable(string name, int step)
	{
	}

	[Token(Token = "0x6002203")]
	[Address(RVA = "0x15832F4", Offset = "0x15832F4", VA = "0x15832F4")]
	public void SetVariable(string name, object value)
	{
	}

	[Token(Token = "0x6002204")]
	[Address(RVA = "0x1583314", Offset = "0x1583314", VA = "0x1583314")]
	public void SetVariable(string name, int value)
	{
	}

	[Token(Token = "0x6002205")]
	[Address(RVA = "0x1583334", Offset = "0x1583334", VA = "0x1583334")]
	public void SetVariable(string name, bool value)
	{
	}

	[Token(Token = "0x6002206")]
	[Address(RVA = "0x1583358", Offset = "0x1583358", VA = "0x1583358")]
	public void SetVariable(string name, float value)
	{
	}

	[Token(Token = "0x6002207")]
	[Address(RVA = "0x1583378", Offset = "0x1583378", VA = "0x1583378")]
	public void SetVariable(string name, object value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x6002208")]
	[Address(RVA = "0x1583398", Offset = "0x1583398", VA = "0x1583398")]
	public void SetVariable(string name, int value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x6002209")]
	[Address(RVA = "0x15833B8", Offset = "0x15833B8", VA = "0x15833B8")]
	public void SetVariable(string name, bool value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x600220A")]
	[Address(RVA = "0x15833DC", Offset = "0x15833DC", VA = "0x15833DC")]
	public void SetVariable(string name, float value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x600220B")]
	[Address(RVA = "0x15833FC", Offset = "0x15833FC", VA = "0x15833FC")]
	protected UIController()
	{
	}
}
