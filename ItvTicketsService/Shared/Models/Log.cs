﻿
namespace ItvTicketsService.Shared.Models
{
    public class Log
    {
        public int LogId { get; set; }
        public string LogLevel { get; set; }
        public string EventName { get; set; }
        public string Source { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public string CreatedDate { get; set; }
        public int UserId { get; set; }
    }
}
