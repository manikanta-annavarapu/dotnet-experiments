// See https://aka.ms/new-console-template for more information
using AMK.Exp.CsharpLang.AboutStatic;

Console.WriteLine("Hello, World!");
StaticClass.DisplayValue();

var staticClass = new StaticClass(); // static constructor will not be called because it is already called when accessing static member(DisplayValue()).
