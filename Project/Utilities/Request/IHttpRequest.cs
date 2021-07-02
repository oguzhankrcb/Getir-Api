using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GetirAPI.Utilities.Request
{
    public interface IHttpRequest
    {
        string Endpoint { get; set; }
        string Body { get; set; }
        string Method { get; set; }
        ArrayList HeaderKeys { get; set; }
        ArrayList HeaderValues { get; set; }
    }
}
