﻿namespace DesignPatternsConsole.Strategy
{
    public class Tester
    {
        public static void Run(string[] args)
        {
            CompressionContext ctx = new CompressionContext(new ZipCompression());
            ctx.CreateArchive("DotNetDesignPattern");
            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("DotNetDesignPattern");
        }
    }
}