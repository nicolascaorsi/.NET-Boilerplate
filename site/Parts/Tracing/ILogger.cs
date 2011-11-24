using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Parts {
    public interface ILogger {
        void Write(string text);
    }
}