using System;

namespace Week7.Esercitazione.Master.MVC.Models
{ 
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
