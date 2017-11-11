using System;
using Xamarin.Forms;

namespace Advanced.Lib.Behaviors.EntryBehavior
{
  public class XUppercaseBehavior : Behavior<Entry>
  {
    protected override void OnAttachedTo(Entry entry)
    {
      base.OnAttachedTo(entry);
      entry.TextChanged += UpperAction;
    }

    protected override void OnDetachingFrom(Entry entry)
    {
      base.OnDetachingFrom(entry);
      entry.TextChanged -= UpperAction;
    }

    private void UpperAction(object sender, TextChangedEventArgs args)
    {
      //args.OldTextValue Antes do usuario digitar
      //args.NewTextValue Depois que o usuario digitar

      if (!string.IsNullOrEmpty(args.NewTextValue))
        ((Entry)sender).Text = args.NewTextValue.ToUpper();
    }
  }
}
