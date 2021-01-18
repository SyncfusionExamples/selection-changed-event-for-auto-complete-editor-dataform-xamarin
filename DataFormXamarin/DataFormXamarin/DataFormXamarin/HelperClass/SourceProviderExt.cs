using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class SourceProviderExt : SourceProvider
        {
            public override IList GetSource(string sourceName)
            {
                var list = new List<string>();
                if (sourceName == "City")
                {
                    list.Add("Indonesia");
                    list.Add("Italy");
                    list.Add("India");
                }
                return list;
            }
        }
}
