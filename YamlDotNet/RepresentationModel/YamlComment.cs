using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamlDotNet.RepresentationModel;
public class YamlComment
{
    public string Text { get; }
    public bool IsInline { get; }

    public YamlComment(string text, bool isInline)
    {
        Text = text;
        IsInline = isInline;
    }
}
