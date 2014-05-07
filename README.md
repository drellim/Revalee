Revalee
=======

Scheduled callbacks for your web applications

![Workflow Diagram](Diagram.png?raw=true)

Rationale
---------

Revalee can simplify your web application's workflow when events are required AFTER the normal handling of a web request. You can write all of your scheduled activities in the same toolset and application as the rest of your web code. No more command line utilities or custom batch jobs. 

Here are some common ways to utilize the power of scheduled callbacks:

*   Sending reminder email messages.
*   Running recurring automated reports.
*   Scheduling daily maintenance functions.
*   Expiring accounts or subscriptions.
*   Canceling incomplete transactions.
*   Consolidating multiple notification messages.
*   Purging temporary files.

Getting Started
---------------

The Revalee service can be downloaded [here](http://revalee.sageanalytic.com#Download) or built from the source code.

To install the service, extract the files into a folder (e.g., C:\Program Files\Revalee\) and run the following command with elevated permissions:

```
Revalee.Service.exe -install
```


The Revalee client library is available on NuGet. To include in a .NET 4.0+ project, use:

```
Install-Package Revalee.Client
```


Alternatively for ASP.NET MVC projects targeting .NET 4.5+, a specialized Revalee client library is also available on NuGet. To install:

```
Install-Package Revalee.Client.Mvc
```

Usage Examples
--------------

Request a one-time web callback in 1 hour for id=123456

```c#
var callbackDelay = TimeSpan.FromHours(1.0);
var callbackUri = new Uri("http://localhost/Home/Callback?id=123456");

Guid callbackId = RevaleeRegistrar.ScheduleCallback(callbackDelay, callbackUri);
```

Request a recurring web callback every night at 3:30 AM

```c#
var manifest = RecurringTasks.RecurringTaskModule.GetManifest();
var callbackUri = new Uri("http://localhost/Recurring/Nightly");

manifest.AddDailyTask(3, 30, callbackUri);
```

Supported Platforms
-------------------
*  Windows XP or later

Client library

*  .NET Framework 4.0+ (only System, System.Core, System.Web assemblies are referenced)

The ASP.NET MVC client library requires .NET Framework 4.5+ and Microsoft ASP.NET MVC 5+.


More information is available at the [Revalee Project Site](http://revalee.sageanalytic.com).
