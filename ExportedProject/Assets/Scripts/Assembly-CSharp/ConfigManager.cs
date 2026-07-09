using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200022A")]
[Scope]
public class ConfigManager<T, U> : GameSingleton<T> where T : ConfigManager<T, U> where U : BaseConfig<U>
{
	[Token(Token = "0x6000CEB")]
	public U GetConfig()
	{
		return null;
	}

	[Token(Token = "0x6000CEC")]
	protected virtual U DoGetConfig(ContractData contractData)
	{
		return null;
	}

	[Token(Token = "0x6000CED")]
	public ConfigManager()
	{
	}
}
[Token(Token = "0x2000849")]
[Scope]
public class ConfigManager : GameSingleton<ConfigManager>
{
	[NonSerialized]
	[Token(Token = "0x4002EC7")]
	[FieldOffset(Offset = "0x48")]
	public List<DisplayableConfig> Configs;

	[Token(Token = "0x6003620")]
	[Address(RVA = "0x8DFC50", Offset = "0x8DFC50", VA = "0x8DFC50")]
	public void Register(DisplayableConfig config)
	{
	}

	[Token(Token = "0x6003621")]
	[Address(RVA = "0x8DFCB4", Offset = "0x8DFCB4", VA = "0x8DFCB4")]
	public void Unregister(DisplayableConfig config)
	{
	}

	[Token(Token = "0x6003622")]
	[Address(RVA = "0x8DFD18", Offset = "0x8DFD18", VA = "0x8DFD18", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6003623")]
	[Address(RVA = "0x8DFEB4", Offset = "0x8DFEB4", VA = "0x8DFEB4")]
	public ConfigManager()
	{
	}
}
