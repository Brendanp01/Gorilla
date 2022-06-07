# Gorilla Browser
Gorilla is my attempt to make an open-source, cross-platform browser using a custom browser engine, written entirely is C#.

Note: In this README, I refer to the project as if it is complete, in reality, I just started development. Think of this README as what I would like the end product to be.

## The Engine
The engine uses a few Nuget packages to handle the basic parts of a browser engine.
1. Microsoft.Clearscript.V8, for embedding the V8 JavaScript engine. This does require me to implement the entire browser API in C#.
2. HtmlAgilityPack, for parsing HTML into a DOM.
3. ExCSS, for parsing CSS into a C# LINQ Object.

The idea is that the browser, written using Gtk# (more on that later), will make an HTTP/HTTPS request to the server, and when it (hopefully) gets a response, it will pass it to the engine. The engine will then use HtmlAgilityPack (HAP) to parse the HTML into a DOM. Then it will loop through the DOM, determine if it links to a stylesheet or script and use ExCSS and ClearScript, respectively, to parse them.
