Stamp
=====

Stamp is an ASP.Net MVC-based rapid website prototyping template. Use it to create prototype websites with common base templates and reuseable parts, in pure HTML, without Visual Studio or a C# compiler.


Requires
--------
- Mono 4.5 or .Net 4.5, with MVC3 support
- XSP or IIS or similar
- MonoDevelop or Visual Studio for initial build (no binary release available yet)


Setup
-----
 - Grab the code, throw it in some folder.
 - Build it (see below)
 - Set the build output folder (default is /build) to be an IIS app.
 - In any text editor, create some page like mypage.cshtml, in /build/views/pages. Put some HTML in it.
 - Launch your app in a browser, you should see a link to mypage.cshtml now. Click it. Now go write a site.


Build 
-----
MsBuild
- Make sure msbuild has been added to your environemental path.
- run build.msbuild.bat


How to use
----------
Standard Razor rules apply. No C# necesary, but any C# that you can fit in a .cshtml is valid ,like
    
    @{ string myString = "hello";}
    @myString

Create parts and themes anywhere in /views/, point to them as you would normally. Use any text editor, refresh browser to view changes. 


How not to use
--------------
Leave /views/home and /controllers/homecontroller.cs alone. These belong to Stamp, and will hopefully be updated by Stamp at some point.


Why?
----
So you can prototype a complex "frontendy" site focusing on HTML, CSS and Javascript. The only backend stuff you need is server-side rendering of HTML, and reuse of either base templates or parts. Maybe a tiny bit of logic. No heavy backend coding or IDE needed.


Credits
-------
Based on ideas I shameless and badly copied from smarter people at DigitasLBi.
