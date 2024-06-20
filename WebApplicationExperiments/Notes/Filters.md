# Filters in ASP.Net Core

Filters are a way to run code before or after the execution of an action method.
Filters are used to perform cross-cutting concerns like logging, exception handling, etc.
Filters are implemented as attributes in ASP.Net Core.

Filters run within the ASP.NET Core action invocation pipeline, sometimes referred to as the filter pipeline. The filter pipeline runs after ASP.NET Core selects the action to execute.

Each filter type is executed at a different stage in the filter pipeline:

- Authorization filters run first. They are used to determine whether the current user is authorized to access the resource.
- Resource filters run next. They are used to perform logic before and after the action method is called.
- Action filters run next. They are used to perform logic before and after the action method is called.
- Exception filters run next. They are used to handle exceptions thrown by the action method.
- Result filters run last. They are used to perform logic before and after the action result is executed.

The filter pipeline runs in reverse order after the action method has been selected.
Note: Implement either the synchronous or the async version of a filter interface, not both. The runtime checks first to see if the filter implements the async interface, and if so, it calls that.
      If not, it calls the synchronous interface's method(s). If both asynchronous and synchronous interfaces are implemented in one class, only the async method is called.
      When using abstract classes like ActionFilterAttribute, override only the synchronous methods or the asynchronous methods for each filter type.