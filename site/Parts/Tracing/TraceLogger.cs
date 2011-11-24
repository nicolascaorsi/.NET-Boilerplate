using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.Composition.Web.Mvc;

namespace Site.Parts {
    [ApplicationShared]
    public class TraceLogger : ILogger {
        public void Write(string text) {
            System.Diagnostics.Trace.WriteLine(text);
        }
    }
}