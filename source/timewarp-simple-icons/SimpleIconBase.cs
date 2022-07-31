namespace TimeWarp.Simple.Icons;

using Microsoft.AspNetCore.Components;

public partial class SimpleIconBase : ComponentBase
{
  [Parameter(CaptureUnmatchedValues = true)]
  public IReadOnlyDictionary<string, object> Attributes { get; set; } = new Dictionary<string, object>();

  [Parameter] public string FillColor { get; set; }

  [Parameter] public int Size { get; set; } = 16;
}