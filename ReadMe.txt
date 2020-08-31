To run the Application you should open the solution file "MyChartASPnetMVC.sln" via VisualStudio 2019 and then browse it through the IISExpress.

Your Browser will load the page https://localhost:XXXX/Home/Index

You should input the needed numbers and submit the button "Plot"
(it is a pity but the second part of the page named "REACT form below" is not working yet, but in progress...)

Than your figures will be pushed to the server (unfortunately not in JSON - also still in proogress...), calculated and saved to a local Database whitch is initialized by default by Database.SetInitializer, and you will get your chart on another page.

There are some additional libraries that were needed for a solution (got from NuGet packages):

Entity Framework
React.Web.Mvc4
JavaScriptEngineSwitcher.V8
JavaScriptEngineSwitcher.V8.Native.win-x64
JavaScriptEngineSwitcher.V8.Native.win-x86

Thank you!

