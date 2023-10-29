// See https://aka.ms/new-console-template for more information
using Patagames.Ocr;
using Patagames.Ocr.Enums;

Console.WriteLine("Hello, World!");


//var api = OcrApi.Create();

using (var api = OcrApi.Create())
{
    api.Init(Languages.Arabic);
    //ScaleByPercent
    string plainText = api.GetTextFromImage("C:\\Work\\Projects\\Testing Projects\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\images\\img4.jpeg");

    Console.WriteLine(plainText);
    Console.Read();
}