using System;
namespace WatsynDocs.Services.App
{
    //static class to avoid magic string when call partial view name
    public static class PartialView
    {
        public static string StatusMessage => "_StatusMessage";
    }
}