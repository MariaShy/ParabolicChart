using React;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MyChartASPnetMVC.ReactConfig), "Configure")]

namespace MyChartASPnetMVC
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			// Регистрация движка V8
			JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
			JsEngineSwitcher.Current.EngineFactories.AddV8();
		}
	}
}