Server Error in '/' Application.

Unable to cast object of type 'DefaultStatusCodeHandlerResult' to type 'nsWeb.Models.Person'.

Description: An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code. 

Exception Details: System.InvalidCastException: Unable to cast object of type 'DefaultStatusCodeHandlerResult' to type 'nsWeb.Models.Person'.

Source Error: 

An unhandled exception was generated during the execution of the current web request. Information regarding the origin and location of the exception can be identified using the exception stack trace below.

Stack Trace: 


[InvalidCastException: Unable to cast object of type 'DefaultStatusCodeHandlerResult' to type 'nsWeb.Models.Person'.]
   Nancy.ViewEngines.Razor.NancyRazorViewBase`1.Initialize(RazorViewEngine engine, IRenderContext renderContext, Object model) +50
   CallSite.Target(Closure , CallSite , Object , RazorViewEngine , IRenderContext , Object ) +254
   System.Dynamic.UpdateDelegates.UpdateAndExecuteVoid4(CallSite site, T0 arg0, T1 arg1, T2 arg2, T3 arg3) +723
   CallSite.Target(Closure , CallSite , Object , RazorViewEngine , IRenderContext , Object ) +311
   Nancy.ViewEngines.Razor.RazorViewEngine.GetViewInstance(ViewLocationResult viewLocationResult, IRenderContext renderContext, Assembly referencingAssembly, Object model) +1007
   System.Dynamic.UpdateDelegates.UpdateAndExecute5(CallSite site, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) +762
   CallSite.Target(Closure , CallSite , RazorViewEngine , ViewLocationResult , IRenderContext , Assembly , Object ) +394
   Nancy.ViewEngines.Razor.<>c__DisplayClass2b.<RenderView>b__2a(Stream stream) +339
   Nancy.Responses.MaterialisingResponse.WriteContents(Stream stream) +28
   Nancy.Hosting.Aspnet.NancyHandler.SetNancyResponseToHttpResponse(HttpContextBase context, Response response) +193
   Nancy.Hosting.Aspnet.NancyHandler.EndProcessRequest(Task`1 task) +125
   Nancy.Hosting.Aspnet.NancyHttpRequestHandler.EndProcessRequest(IAsyncResult result) +33
   System.Web.CallHandlerExecutionStep.OnAsyncHandlerCompletion(IAsyncResult ar) +129
   System.Web.AsyncStepCompletionInfo.ReportError() +34
   System.Web.CallHandlerExecutionStep.System.Web.HttpApplication.IExecutionStep.Execute() +9711535
   System.Web.HttpApplication.ExecuteStep(IExecutionStep step, Boolean& completedSynchronously) +155