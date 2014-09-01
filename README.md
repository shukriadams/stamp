Stamp
=====

Stamp is an ASP.Net MVC-based website prototyping template. Use it to create prototype websites with common base templates and reuseable parts, in pure HTML, without Visual Studio or a C# compiler. Sort of.

Requires
--------
- Mono 4.5 or .Net 4.5, with MVC3 support
- XSP or IIS or similar
- MonoDevelop or Visual Studio for initial build (no binary release available yet)

Setup
-----
 - Grab the code, throw it in some folder.
 - Set the folder up to be an IIS app.
 - If you haven't yet, open the solution and compile it. This is needed once only.
 - In any text editor, create some page like mypage.cshtml, in /views/pages. Put some HTML in it.
 - Launch your app in a browser, you should see a link to mypage.cshtml now. Click it. That's a blank canvas waiting for ideas. 

How to use
----------
Standard Razor rules apply. No C# necesary, but any C# that you can fit in a .cshtml is valid ,like
    @{ string myString = "hello";}
    @myString

Create parts and themes anywhere in /views/, point to them as you would normally.

How not to use
--------------
Leave /views/home and /controllers/homecontroller.cs alone. These belong to Stamp, and will hopefully be updated without warning.

Why?
----
When you're prototyping a complex "frontendy" page, your focus is on HTML, CSS and Javascript. The only backend stuff you want is server-side rendering of HTML, and reuse of either base templates or parts. Maybe a tiny bit of logic. You don't need heavy backend coding or even a heavy backend IDE.

Credits
-------
Based on ideas I shameless and badly copied from smarter people at DigitasLBi.
